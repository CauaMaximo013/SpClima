using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SpClima.Data;
using SpClima.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Conexão com o banco de dados
string conexao = builder.Configuration.GetConnectionString("SpClimaConn");
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseMySQL(conexao)
);

// Configuração do identity
builder.Services.AddIdentity<Usuario, IdentityRole>(
    options => options.SingIn.RequiredConfirmedEmail = false
).AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
