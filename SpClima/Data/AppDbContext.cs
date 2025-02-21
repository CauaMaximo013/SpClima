using System.ComponentModel;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpClima.Models;

namespace SpClima.Data;


public class AppDbContext : IdentityDbContext<Usuario>
{
    public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
    {      
    }

    public DbSet<Categoria> Categorias { get; set; }
    
    public DbSet<Produto> Produtos { get; set; }

    public DbSet<ProdutoFoto> ProdutoFotos{ get; set; }

    public DbSet<Usuario> Usuarios { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        #region Renomeação das tabelas do identity
        builder.Entity<Usuario>().ToTable("Usuario");
        builder.Entity<IdentityRole>().ToTable("perfil");
        builder.Entity<IdentityUserRole<string>>().ToTable("usuario_perfil");
        builder.Entity<IdentityUserToken<string>>().ToTable("usuario_token");
        builder.Entity<IdentityUserClaim<string>>().ToTable("usuario_regra");
        builder.Entity<IdentityUserLogin<string>>().ToTable("usuario_login");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("perfil_regra");
        #endregion

        #region Popular Categoria
        List<Categoria> categorias = new()
        {
            new Categoria()
            {
                Id = 1,
                Nome = "Ar"
            },
            new Categoria()
            {
                Id = 2,
                Nome = "Geladeira"
            },
            new Categoria()
            {
                Id = 3,
                Nome = "Maquina"
            },
        };
        builder.Entity<Categoria>().HasData(categorias);
        #endregion

        #region Produto
        List<Produto> produtos = new()
        {
            new Produto()
            {
                Id = 1,
                Nome = "Ar-Condicionado",
                Descricao = "Ar que Gela",
                CategoriaId = 1,
                Qtde = 5,
                ValorCusto = 2000,
                ValorVenda = 2500,
            },
            new Produto()
            {
                Id = 2,
                Nome = "Geladeira",
                CategoriaId = 2,
                Qtde = 3,
                ValorCusto = 3000,
                ValorVenda = 4750,
            },
            new Produto()
            {
                Id = 3,
                Nome = "Maquina de lava",
                CategoriaId = 3,
                Qtde = 3,
                ValorCusto = 1500,
                ValorVenda = 2000,
            },
        };
        builder.Entity<Produto>().HasData(produtos);
        #endregion

        #region Usuario
        List<Usuario> usuarios = new()
        {
            new Usuario()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "ManoGabs",
                NormalizedUserName = "MANOGABS",
                Email = "maximocaua13@gmail.com",
                NormalizedEmail = "MAXIMOCAUA13@GMAIL.COM",
                EmailConfirmed = true,
                Nome = "Gabis Junior Junior",
                DataNascimento = DateTime.Parse("13/09/2007"),
            }
        };
        foreach (Usuario usuario in usuarios)
        {
            PasswordHasher<Usuario> password = new();
            usuario.PasswordHash = password.HashPassword(usuario, "112233");
        }
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Perfil
        List<IdentityRole> perfis = new()
        {
            new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Funcionário",
                NormalizedName = "FUNCIONÁRIO"
            },
            new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Cliente",
                NormalizedName = "CLIENTE"
            }
        };
        builder.Entity<IdentityRole>().HasData(perfis);
        #endregion

        #region Usuario Perfil
        List<IdentityUserRole<string>> usuarioPerfis = new()
        {
            new IdentityUserRole<string>()
            {
                UserId = usuarios[0].Id,
                RoleId = perfis[0].Id
            },
            new IdentityUserRole<string>()
            {
                UserId = usuarios[0].Id,
                RoleId = perfis[1].Id
            },
            new IdentityUserRole<string>()
            {
                UserId = usuarios[0].Id,
                RoleId = perfis[2].Id
            },
        };
        builder.Entity<IdentityUserRole<string>>().HasData(usuarioPerfis);
        #endregion
    }

}
