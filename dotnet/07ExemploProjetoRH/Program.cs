using Microsoft.EntityFrameworkCore;
using _07ExemploProjetoRH.Models;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o contexto do banco usando a string de conexão do appsettings.json
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adiciona suporte a controllers e views (MVC)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configuração do pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Configura rota padrão para o MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
