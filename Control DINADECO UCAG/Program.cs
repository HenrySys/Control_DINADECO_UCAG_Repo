using Microsoft.EntityFrameworkCore;
using Control_DINADECO_UCAG.Data; // Ajusta según el espacio de nombres

using Microsoft.AspNetCore.Authentication.Cookies;
using Control_DINADECO_UCAG.Services;


var builder = WebApplication.CreateBuilder(args);

// Configurar el servicio de DbContext para usar MySQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        MySqlServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection")) // Asegúrate de que coincida con tu versión de MySQL
    )
);

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Acceso/Login";
        options.SlidingExpiration = true;
        options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
        options.AccessDeniedPath = "/Acceso/Denegado";
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminPolicy", policy => policy.RequireRole("AsocAdmin"));
    options.AddPolicy("UnionCantonalPolicy", policy => policy.RequireRole("UCAGAdmin"));
});

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<HashingService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();