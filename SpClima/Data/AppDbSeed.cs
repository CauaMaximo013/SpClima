using SpClima.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SpClima.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        List<Categoria> categorias = new() {
            new Categoria { Id = 1, Nome = "Smartphones" },
            new Categoria { Id = 2, Nome = "Notebooks" },
            new Categoria { Id = 3, Nome = "Smartwatches" },
            new Categoria { Id = 4, Nome = "Fones de Ouvido" },
            new Categoria { Id = 5, Nome = "Monitores" },
            new Categoria { Id = 6, Nome = "Teclados e Mouses" },
            new Categoria { Id = 7, Nome = "Consoles" },
            new Categoria { Id = 8, Nome = "Action Figures" },
            new Categoria { Id = 9, Nome = "Drones" },
            new Categoria { Id = 10, Nome = "Câmeras Digitais" }
        };
        builder.Entity<Categoria>().HasData(categorias);

        List<Produto> produtos = new List<Produto>
        {
            // Smartphones
            new Produto { Id = 1, CategoriaId = 1, Nome = "iPhone 14 Pro", Descricao = "Apple A16 Bionic, 128GB", ValorCusto = 4500.00m, ValorVenda = 6999.00m, QtdeEstoque = 10, Destaque = true },
            new Produto { Id = 2, CategoriaId = 1, Nome = "Samsung Galaxy S23", Descricao = "Snapdragon 8 Gen 2, 256GB", ValorCusto = 4000.00m, ValorVenda = 6499.00m, QtdeEstoque = 15, Destaque = true },
            new Produto { Id = 3, CategoriaId = 1, Nome = "Xiaomi 13 Pro", Descricao = "Snapdragon 8 Gen 2, 512GB", ValorCusto = 3500.00m, ValorVenda = 5299.00m, QtdeEstoque = 20 },
            new Produto { Id = 4, CategoriaId = 1, Nome = "Motorola Edge 30 Ultra", Descricao = "Snapdragon 8 Gen 1, 256GB", ValorCusto = 3200.00m, ValorVenda = 4799.00m, QtdeEstoque = 12 },
            new Produto { Id = 5, CategoriaId = 1, Nome = "Asus ROG Phone 6", Descricao = "Gaming Phone, 512GB", ValorCusto = 4200.00m, ValorVenda = 6999.00m, QtdeEstoque = 8 },

            // Notebooks
            new Produto { Id = 6, CategoriaId = 2, Nome = "MacBook Pro M2", Descricao = "Apple M2, 16GB RAM, 512GB SSD", ValorCusto = 8000.00m, ValorVenda = 11999.00m, QtdeEstoque = 5, Destaque = true },
            new Produto { Id = 7, CategoriaId = 2, Nome = "Dell XPS 15", Descricao = "Intel i7, 16GB RAM, 1TB SSD", ValorCusto = 7000.00m, ValorVenda = 9999.00m, QtdeEstoque = 7 },
            new Produto { Id = 8, CategoriaId = 2, Nome = "Asus ROG Strix G15", Descricao = "Ryzen 9, RTX 3070, 16GB RAM", ValorCusto = 7500.00m, ValorVenda = 10999.00m, QtdeEstoque = 6 },
            new Produto { Id = 9, CategoriaId = 2, Nome = "Lenovo ThinkPad X1", Descricao = "Intel i5, 8GB RAM, 512GB SSD", ValorCusto = 5000.00m, ValorVenda = 7999.00m, QtdeEstoque = 10 },
            new Produto { Id = 10, CategoriaId = 2, Nome = "HP Spectre x360", Descricao = "Intel i7, 16GB RAM, 1TB SSD", ValorCusto = 7200.00m, ValorVenda = 10499.00m, QtdeEstoque = 8 },

            // Smartwatches
            new Produto { Id = 11, CategoriaId = 3, Nome = "Apple Watch Series 8", Descricao = "GPS + Cellular, 45mm", ValorCusto = 2500.00m, ValorVenda = 3999.00m, QtdeEstoque = 10, Destaque = true },
            new Produto { Id = 12, CategoriaId = 3, Nome = "Samsung Galaxy Watch 5", Descricao = "LTE, 44mm", ValorCusto = 1500.00m, ValorVenda = 2499.00m, QtdeEstoque = 15 },
            new Produto { Id = 13, CategoriaId = 3, Nome = "Garmin Fenix 7", Descricao = "MultiSport GPS Watch", ValorCusto = 3500.00m, ValorVenda = 4999.00m, QtdeEstoque = 5 },
            new Produto { Id = 14, CategoriaId = 3, Nome = "Xiaomi Mi Watch", Descricao = "Bluetooth, 46mm", ValorCusto = 800.00m, ValorVenda = 1499.00m, QtdeEstoque = 20 },
            new Produto { Id = 15, CategoriaId = 3, Nome = "Fitbit Sense 2", Descricao = "Monitoramento de saúde", ValorCusto = 1200.00m, ValorVenda = 2099.00m, QtdeEstoque = 12 },

            // Fones de Ouvido
            new Produto { Id = 16, CategoriaId = 4, Nome = "AirPods Pro", Descricao = "Cancelamento de Ruído Ativo", ValorCusto = 900.00m, ValorVenda = 1499.00m, QtdeEstoque = 12, Destaque = true },
            new Produto { Id = 17, CategoriaId = 4, Nome = "Sony WH-1000XM5", Descricao = "Over-ear, Noise Cancelling", ValorCusto = 1400.00m, ValorVenda = 2199.00m, QtdeEstoque = 10 },
            new Produto { Id = 18, CategoriaId = 4, Nome = "JBL Live 660NC", Descricao = "Fone Bluetooth, Graves Potentes", ValorCusto = 600.00m, ValorVenda = 999.00m, QtdeEstoque = 20 },
            new Produto { Id = 19, CategoriaId = 4, Nome = "Beats Studio Buds", Descricao = "Fones In-Ear, Bluetooth", ValorCusto = 800.00m, ValorVenda = 1299.00m, QtdeEstoque = 15 },
            new Produto { Id = 20, CategoriaId = 4, Nome = "Razer Kraken X", Descricao = "Headset Gamer, Surround 7.1", ValorCusto = 400.00m, ValorVenda = 699.00m, QtdeEstoque = 25 },

            // Monitores
            new Produto { Id = 21, CategoriaId = 5, Nome = "LG Ultragear 27\"", Descricao = "IPS, 144Hz, 1ms", ValorCusto = 1200.00m, ValorVenda = 1899.00m, QtdeEstoque = 8, Destaque = true },
            new Produto { Id = 22, CategoriaId = 5, Nome = "Samsung Odyssey G5", Descricao = "Curvo, 165Hz, 2K", ValorCusto = 1400.00m, ValorVenda = 2399.00m, QtdeEstoque = 10 },
            new Produto { Id = 23, CategoriaId = 5, Nome = "AOC Hero 24\"", Descricao = "IPS, 144Hz, FreeSync", ValorCusto = 900.00m, ValorVenda = 1499.00m, QtdeEstoque = 15 },
            new Produto { Id = 24, CategoriaId = 5, Nome = "Dell P2723QE", Descricao = "4K UHD, 60Hz, USB-C", ValorCusto = 2000.00m, ValorVenda = 3299.00m, QtdeEstoque = 5 },
            new Produto { Id = 25, CategoriaId = 5, Nome = "BenQ Zowie XL2546", Descricao = "240Hz, 1ms, eSports", ValorCusto = 2500.00m, ValorVenda = 3999.00m, QtdeEstoque = 6 },

            // Teclados e Mouses
            new Produto { Id = 26, CategoriaId = 6, Nome = "Logitech G Pro X", Descricao = "Teclado Mecânico, RGB", ValorCusto = 700.00m, ValorVenda = 1099.00m, QtdeEstoque = 20, Destaque = true },
            new Produto { Id = 27, CategoriaId = 6, Nome = "Razer Huntsman Mini", Descricao = "Teclado Óptico, 60%", ValorCusto = 800.00m, ValorVenda = 1299.00m, QtdeEstoque = 12 },
            new Produto { Id = 28, CategoriaId = 6, Nome = "HyperX Alloy FPS", Descricao = "Teclado Mecânico, Red Switch", ValorCusto = 600.00m, ValorVenda = 999.00m, QtdeEstoque = 18 },
            new Produto { Id = 29, CategoriaId = 6, Nome = "Logitech G502 Hero", Descricao = "Mouse Gamer, 16K DPI", ValorCusto = 300.00m, ValorVenda = 599.00m, QtdeEstoque = 25 },
            new Produto { Id = 30, CategoriaId = 6, Nome = "Razer DeathAdder V2", Descricao = "Mouse Ergonômico, 20K DPI", ValorCusto = 400.00m, ValorVenda = 699.00m, QtdeEstoque = 20 },

            // Consoles
            new Produto { Id = 31, CategoriaId = 7, Nome = "PlayStation 5", Descricao = "Edição Standard, SSD 825GB", ValorCusto = 3500.00m, ValorVenda = 4999.00m, QtdeEstoque = 8, Destaque = true },
            new Produto { Id = 32, CategoriaId = 7, Nome = "Xbox Series X", Descricao = "1TB SSD, 4K Gaming", ValorCusto = 3500.00m, ValorVenda = 4899.00m, QtdeEstoque = 10 },
            new Produto { Id = 33, CategoriaId = 7, Nome = "Nintendo Switch OLED", Descricao = "Tela OLED, 64GB", ValorCusto = 1800.00m, ValorVenda = 2699.00m, QtdeEstoque = 12 },
            new Produto { Id = 34, CategoriaId = 7, Nome = "PlayStation 4 Slim", Descricao = "500GB HDD, Controle DualShock", ValorCusto = 1500.00m, ValorVenda = 2299.00m, QtdeEstoque = 15 },
            new Produto { Id = 35, CategoriaId = 7, Nome = "Xbox Series S", Descricao = "512GB SSD, Digital", ValorCusto = 2000.00m, ValorVenda = 2899.00m, QtdeEstoque = 18 },

            // Action Figures
            new Produto { Id = 36, CategoriaId = 8, Nome = "Batman (DC Collectibles)", Descricao = "Figura colecionável 1/6", ValorCusto = 500.00m, ValorVenda = 899.00m, QtdeEstoque = 15, Destaque = true },
            new Produto { Id = 37, CategoriaId = 8, Nome = "Homem de Ferro (Hot Toys)", Descricao = "Escala 1/6", ValorCusto = 1200.00m, ValorVenda = 1999.00m, QtdeEstoque = 8 },
            new Produto { Id = 38, CategoriaId = 8, Nome = "Goku (Dragon Ball Z)", Descricao = "SH Figuarts", ValorCusto = 300.00m, ValorVenda = 599.00m, QtdeEstoque = 25 },
            new Produto { Id = 39, CategoriaId = 8, Nome = "Naruto Uzumaki", Descricao = "Banpresto Figure", ValorCusto = 250.00m, ValorVenda = 449.00m, QtdeEstoque = 20 },
            new Produto { Id = 40, CategoriaId = 8, Nome = "Darth Vader (Star Wars)", Descricao = "Figura Hasbro Black Series", ValorCusto = 450.00m, ValorVenda = 799.00m, QtdeEstoque = 10 },
       
            // Drones
            new Produto { Id = 41, CategoriaId = 9, Nome = "DJI Mini 3 Pro", Descricao = "4K, Compacto, Smart Features", ValorCusto = 2500.00m, ValorVenda = 3999.00m, QtdeEstoque = 6, Destaque = true },
            new Produto { Id = 42, CategoriaId = 9, Nome = "DJI Mavic Air 2", Descricao = "48MP, 4K 60fps", ValorCusto = 3000.00m, ValorVenda = 4999.00m, QtdeEstoque = 7 },
            new Produto { Id = 43, CategoriaId = 9, Nome = "Parrot Anafi", Descricao = "Câmera HDR 4K, Compacto", ValorCusto = 2000.00m, ValorVenda = 3299.00m, QtdeEstoque = 10 },
            new Produto { Id = 44, CategoriaId = 9, Nome = "Ryze Tello", Descricao = "Drone Educacional, 720p", ValorCusto = 400.00m, ValorVenda = 799.00m, QtdeEstoque = 20 },
            new Produto { Id = 45, CategoriaId = 9, Nome = "Autel Evo Lite+", Descricao = "Câmera 6K, Bateria 40min", ValorCusto = 3500.00m, ValorVenda = 5499.00m, QtdeEstoque = 5 },

            // Câmeras Digitais
            new Produto { Id = 46, CategoriaId = 10, Nome = "Canon EOS R5", Descricao = "Mirrorless, 8K Video", ValorCusto = 12000.00m, ValorVenda = 15999.00m, QtdeEstoque = 4, Destaque = true },
            new Produto { Id = 47, CategoriaId = 10, Nome = "Sony A7 IV", Descricao = "Mirrorless Full-Frame, 33MP", ValorCusto = 9000.00m, ValorVenda = 12999.00m, QtdeEstoque = 6 },
            new Produto { Id = 48, CategoriaId = 10, Nome = "Nikon Z6 II", Descricao = "Mirrorless, 24MP, 4K", ValorCusto = 8000.00m, ValorVenda = 11499.00m, QtdeEstoque = 5 },
            new Produto { Id = 49, CategoriaId = 10, Nome = "GoPro Hero 11", Descricao = "Câmera de Ação, 5.3K", ValorCusto = 2000.00m, ValorVenda = 3199.00m, QtdeEstoque = 15 },
            new Produto { Id = 50, CategoriaId = 10, Nome = "Fujifilm X-T4", Descricao = "APS-C, 26MP, 4K", ValorCusto = 7500.00m, ValorVenda = 10999.00m, QtdeEstoque = 7 }
        };
        builder.Entity<Produto>().HasData(produtos);

        List<ProdutoFoto> produtoFotos = new List<ProdutoFoto>
        {
            // Produto 1
            new ProdutoFoto { Id = 1, ProdutoId = 1, ArquivoFoto = "/img/produtos/1/1.png" },
            new ProdutoFoto { Id = 2, ProdutoId = 1, ArquivoFoto = "/img/produtos/1/2.png" },
            new ProdutoFoto { Id = 3, ProdutoId = 1, ArquivoFoto = "/img/produtos/1/3.png" },

            // Produto 2
            new ProdutoFoto { Id = 4, ProdutoId = 2, ArquivoFoto = "/img/produtos/2/1.png" },
            new ProdutoFoto { Id = 5, ProdutoId = 2, ArquivoFoto = "/img/produtos/2/2.png" },
            new ProdutoFoto { Id = 6, ProdutoId = 2, ArquivoFoto = "/img/produtos/2/3.png" },

            // Produto 6
            new ProdutoFoto { Id = 7, ProdutoId = 6, ArquivoFoto = "/img/produtos/6/1.png" },
            new ProdutoFoto { Id = 8, ProdutoId = 6, ArquivoFoto = "/img/produtos/6/2.png" },
            new ProdutoFoto { Id = 9, ProdutoId = 6, ArquivoFoto = "/img/produtos/6/3.png" },

            // Produto 11
            new ProdutoFoto { Id = 10, ProdutoId = 11, ArquivoFoto = "/img/produtos/11/1.png" },
            new ProdutoFoto { Id = 11, ProdutoId = 11, ArquivoFoto = "/img/produtos/11/2.png" },
            new ProdutoFoto { Id = 12, ProdutoId = 11, ArquivoFoto = "/img/produtos/11/3.png" },

            // Produto 16
            new ProdutoFoto { Id = 13, ProdutoId = 16, ArquivoFoto = "/img/produtos/16/1.png" },
            new ProdutoFoto { Id = 14, ProdutoId = 16, ArquivoFoto = "/img/produtos/16/2.png" },
            new ProdutoFoto { Id = 15, ProdutoId = 16, ArquivoFoto = "/img/produtos/16/3.png" },

            // Produto 21
            new ProdutoFoto { Id = 16, ProdutoId = 21, ArquivoFoto = "/img/produtos/21/1.png" },
            new ProdutoFoto { Id = 17, ProdutoId = 21, ArquivoFoto = "/img/produtos/21/2.png" },
            new ProdutoFoto { Id = 18, ProdutoId = 21, ArquivoFoto = "/img/produtos/21/3.png" },

            // Produto 26
            new ProdutoFoto { Id = 19, ProdutoId = 26, ArquivoFoto = "/img/produtos/26/1.png" },
            new ProdutoFoto { Id = 20, ProdutoId = 26, ArquivoFoto = "/img/produtos/26/2.png" },

            // Produto 31
            new ProdutoFoto { Id = 21, ProdutoId = 31, ArquivoFoto = "/img/produtos/31/1.png" },
            new ProdutoFoto { Id = 22, ProdutoId = 31, ArquivoFoto = "/img/produtos/31/2.png" },
            new ProdutoFoto { Id = 23, ProdutoId = 31, ArquivoFoto = "/img/produtos/31/3.png" },

            // Produto 36
            new ProdutoFoto { Id = 24, ProdutoId = 36, ArquivoFoto = "/img/produtos/36/1.png" },
            new ProdutoFoto { Id = 25, ProdutoId = 36, ArquivoFoto = "/img/produtos/36/2.png" },
            new ProdutoFoto { Id = 26, ProdutoId = 36, ArquivoFoto = "/img/produtos/36/3.png" },

            // Produto 41
            new ProdutoFoto { Id = 27, ProdutoId = 41, ArquivoFoto = "/img/produtos/41/1.png" },
            new ProdutoFoto { Id = 28, ProdutoId = 41, ArquivoFoto = "/img/produtos/41/2.png" },
            new ProdutoFoto { Id = 29, ProdutoId = 41, ArquivoFoto = "/img/produtos/41/3.png" },

            // Produto 46
            new ProdutoFoto { Id = 30, ProdutoId = 46, ArquivoFoto = "/img/produtos/46/1.png" },
            new ProdutoFoto { Id = 31, ProdutoId = 46, ArquivoFoto = "/img/produtos/46/2.png" },
            new ProdutoFoto { Id = 32, ProdutoId = 46, ArquivoFoto = "/img/produtos/46/3.png" },
        };
        builder.Entity<ProdutoFoto>().HasData(produtoFotos);


        #region Populate Roles - Perfis de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole() {
               Id = "0b44ca04-f6b0-4a8f-a953-1f2330d30894",
               Name = "Administrador",
               NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole() {
               Id = "bec71b05-8f3d-4849-88bb-0e8d518d2de8",
               Name = "Funcionário",
               NormalizedName = "FUNCIONÁRIO"
            },
            new IdentityRole() {
               Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
               Name = "Cliente",
               NormalizedName = "CLIENTE"
            },
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate Usuário
        List<Usuario> usuarios = new() {
            new Usuario(){
                Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                Email = "maximocaua13@gmail.com",
                NormalizedEmail = "MAXIMOCAUA13@GMAIL.COM",
                UserName = "ManoGabs",
                NormalizedUserName = "MANOGABS",
                LockoutEnabled = true,
                EmailConfirmed = true,
                Nome = "Gabis Junior Junior",
                DataNascimento = DateTime.Parse("13/09/2007"),
                Foto = "/img/usuarios/no-photo.png"
            }
        };
        foreach (var user in usuarios)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "123456");
        }
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[1].Id
            },
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[2].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}