using ListaDeTarefas.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Conection to MySql
var strinConnection = "server=localhost; user=root; password=root; database=DB_Tarefas";
var serverVersion = ServerVersion.AutoDetect(strinConnection);

builder.Services.AddDbContext<AppDbContext>(dbContextOptions => 
    dbContextOptions.UseMySql(strinConnection, serverVersion));

// Adicionar injeção de dependência (repositório)

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
