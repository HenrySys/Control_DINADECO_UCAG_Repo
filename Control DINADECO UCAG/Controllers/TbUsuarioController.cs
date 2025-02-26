using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Control_DINADECO_UCAG.Data;
using Control_DINADECO_UCAG.Models;
using Control_DINADECO_UCAG.ViewModels;
using Control_DINADECO_UCAG.Services;

namespace Control_DINADECO_UCAG.Controllers
{
    public class TbUsuarioController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly HashingService _hashingService;

		public TbUsuarioController(ApplicationDbContext context, HashingService hashingService)
		{
			_context = context;
			_hashingService = hashingService;
		}

		// GET: TbUsuario
		public async Task<IActionResult> Index()
        {
            var usuarios = await _context.TbUsuarios
                                  .Include(u => u.IdRolNavigation)
                                  .ToListAsync();

            return View(usuarios);
        }

        // GET: TbUsuario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbUsuario = await _context.TbUsuarios
                .FirstOrDefaultAsync(m => m.IdUser == id);
            if (tbUsuario == null)
            {
                return NotFound();
            }

            return View(tbUsuario);
        }

        // GET: TbUsuario/Create
        public IActionResult Create()
        {
            var roles = _context.TbRols.ToList();

            var model = new UsuarioRolesVM
            {
                Usuario = new TbUsuario(), 
                Roles = roles ?? new List<TbRol>()
			};

            return View(model);
        }

        // POST: TbUsuario/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UsuarioRolesVM model)
        {
            if (ModelState.IsValid)
            {

				model.Usuario.Contraseña = _hashingService.GenerateHash(model.Usuario.Contraseña);

				_context.Add(model.Usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
			model.Roles = _context.TbRols.ToList() ?? new List<TbRol>();
			return View(model);
        }


        // GET: TbUsuario/Edit/?
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbUsuario = await _context.TbUsuarios.FindAsync(id);
            if (tbUsuario == null)
            {
                return NotFound();
            }
            var roles = await _context.TbRols.ToListAsync(); // Asumiendo que TbRoles es la tabla de roles

            // Crear el ViewModel
            var model = new UsuarioRolesVM
            {
                Usuario = tbUsuario,
                Roles = roles
            };

            return View(model);
        }

		// POST: TbUsuario/Edit/?
		
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, UsuarioRolesVM model)
		{
			if (id != model.Usuario.IdUser)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					// Verificar si se ingresó una nueva contraseña
					if (!string.IsNullOrEmpty(model.Usuario.Contraseña))
					{
						// Hashear la nueva contraseña antes de guardarla
						model.Usuario.Contraseña = _hashingService.GenerateHash(model.Usuario.Contraseña);
					}
					else
					{
						// Mantener la contraseña original
						var originalUsuario = await _context.TbUsuarios.AsNoTracking()
												 .FirstOrDefaultAsync(u => u.IdUser == id);

						if (originalUsuario != null)
						{
							model.Usuario.Contraseña = originalUsuario.Contraseña;
						}
					}

					// Actualizar los datos del usuario
					_context.Update(model.Usuario);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!TbUsuarioExists(model.Usuario.IdUser))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}

			// Recargar los roles en caso de error de validación
			model.Roles = _context.TbRols.ToList() ?? new List<TbRol>();

			return View(model);
		}


		// GET: TbUsuario/Delete/?
		public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbUsuario = await _context.TbUsuarios
                .FirstOrDefaultAsync(m => m.IdUser == id);
            if (tbUsuario == null)
            {
                return NotFound();
            }

            return View(tbUsuario);
        }

        // POST: TbUsuario/Delete/?
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbUsuario = await _context.TbUsuarios.FindAsync(id);
            if (tbUsuario != null)
            {
                _context.TbUsuarios.Remove(tbUsuario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbUsuarioExists(int id)
        {
            return _context.TbUsuarios.Any(e => e.IdUser == id);
        }




    }


}
