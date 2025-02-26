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

        AppDbSeed seed = new(builder);
       
    }

}
