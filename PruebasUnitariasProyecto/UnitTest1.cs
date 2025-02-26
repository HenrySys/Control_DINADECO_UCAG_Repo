using NUnit.Framework;
using Moq;
using Microsoft.EntityFrameworkCore;
using Control_DINADECO_UCAG.Controllers;
using Control_DINADECO_UCAG.Models;
using Control_DINADECO_UCAG.ViewModels;
using Control_DINADECO_UCAG.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using Control_DINADECO_UCAG.Data;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Tests
{
    [TestFixture]
    public class AccesoControllerTests : IDisposable
    {
        private Mock<DbSet<TbUsuario>> _mockUsuariosDbSet;
        private Mock<ApplicationDbContext> _mockDbContext;
        private Mock<HashingService> _mockHashingService;
        private AccesoController _controller;

        [SetUp]
        public void Setup()
        {
            // Configuración del DbSet mockeado
            var usuarioList = new List<TbUsuario>
            {
                new TbUsuario
                {
                    IdUser = 1,
                    NombreUsuario = "TestUser",
                    Correo = "test@correo.com",
                    Contraseña = "hashed_password"
                }
            }.AsQueryable();

            // Mock para DbSet
            _mockUsuariosDbSet = new Mock<DbSet<TbUsuario>>();
            _mockUsuariosDbSet.As<IQueryable<TbUsuario>>().Setup(m => m.Provider).Returns(usuarioList.Provider);
            _mockUsuariosDbSet.As<IQueryable<TbUsuario>>().Setup(m => m.Expression).Returns(usuarioList.Expression);
            _mockUsuariosDbSet.As<IQueryable<TbUsuario>>().Setup(m => m.ElementType).Returns(usuarioList.ElementType);
            _mockUsuariosDbSet.As<IQueryable<TbUsuario>>().Setup(m => m.GetEnumerator()).Returns(usuarioList.GetEnumerator());

            // Mock para ApplicationDbContext
            _mockDbContext = new Mock<ApplicationDbContext>();
            _mockDbContext.Setup(db => db.TbUsuarios).Returns(_mockUsuariosDbSet.Object);

            // Mock para HashingService
            _mockHashingService = new Mock<HashingService>();
            _controller = new AccesoController(_mockDbContext.Object, _mockHashingService.Object);
        }

        [Test]
        public async Task Login_ValidUser_RedirectsToHome()
        {
            // Arrange
            var loginModel = new LogInVM
            {
                Correo = "test@correo.com",
                Contraseña = "password123"
            };

            // Simulamos que la contraseña ingresada es correcta
            _mockHashingService.Setup(h => h.VeryfyHash(It.IsAny<string>(), It.IsAny<string>()))
                               .Returns(true);

            // Act
            var result = await _controller.Login(loginModel);

            // Assert
            var redirectToActionResult = result as RedirectToActionResult;
            Assert.IsNotNull(redirectToActionResult);
            Assert.AreEqual("Index", redirectToActionResult.ActionName);
            Assert.AreEqual("Home", redirectToActionResult.ControllerName);
        }

        [Test]
        public async Task Login_InvalidUser_ReturnsViewWithMessage()
        {
            // Arrange
            var loginModel = new LogInVM
            {
                Correo = "wrong@correo.com",
                Contraseña = "wrongpassword"
            };

            // Simulamos que no se encontró el usuario en la base de datos
            _mockUsuariosDbSet.Setup(m => m.AsQueryable()).Returns(Enumerable.Empty<TbUsuario>().AsQueryable());

            // Act
            var result = await _controller.Login(loginModel);

            // Assert
            var viewResult = result as ViewResult;
            Assert.IsNotNull(viewResult);
            Assert.AreEqual("Correo o contraseña incorrectos.", viewResult.ViewData["Mensaje"]);
        }

        public void Dispose()
        {
            // Dispose de cualquier recurso necesario
            _mockDbContext = null;
            _mockUsuariosDbSet = null;
            _mockHashingService = null;
            _controller = null;
        }
    }
}
