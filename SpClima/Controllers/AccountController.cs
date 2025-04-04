
using SpClima.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SpClima.ViewModels;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SpClima.Controllers;
public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly SignInManager<Usuario> _singInManager;
        private readonly UserManager<Usuario> _userManager;
        private readonly IWebHostEnvironment _host;

        public AccountController(
            ILogger<AccountController> logger,
            SignInManager<Usuario> signInManager,
            UserManager<Usuario> userManager,
            IWebHostEnvironment host
        )
        {
            _logger = logger;
            _singInManager = signInManager;
            _userManager = userManager;
            _host = host;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            LoginVM login = new()
            {
                UrlRetorno = returnUrl ?? Url.Content("~/")
            };
            return View(login);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (ModelState.IsValid)
            {
                string userName = login.Email;
                if (IsValidEmail(login.Email))
                {
                    var user = await _userManager.FindByEmailAsync(Login.Email);
                    if(user != null)
                     userName = user.userName;
                }

                var result = await _signInManager.PasswordSignInAsync(
                    userName, login.Senha, login.Lembrar, lockoutOnFailure: true
                );
                 if (result.Succeeded) {
                    _logger.LogWarning($"Usuário {login.Email} acessou o sistema");
                    return LocalRedirect(login.UrlRetorno);
                 }
                
                if(result.IsLockedOut) {
                    _logger.LogWarning($"Usuário {login.Email} está bloqueado");
                }
            }
        }
    }