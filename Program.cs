using Microsoft.EntityFrameworkCore;
using tarea_semana_3.Models;

var builder = WebApplication.CreateBuilder(args);

var cn = builder.Configuration.GetConnectionString("cn");

builder.Services.AddDbContext<ClientesDbContext>(
    (opciones) => {
        opciones.UseMySQL(cn);
    });

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
