using BatidaPerfeita.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BatidaPerfeita.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login(string returnUrl)
        {
            var model = new LoginViewModel { ReturnUrl = returnUrl };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            if (!ModelState.IsValid)
                return View(loginVM);

            var user = await _userManager.FindByNameAsync(loginVM.UserName);

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(loginVM.ReturnUrl))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    return Redirect(loginVM.ReturnUrl);
                }
            }
            ModelState.AddModelError("", "Falha ao realizar o login!");
            return View(loginVM);
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult ChangeUser()
        {
            return View();
        }
        public IActionResult ChangeEmail()
        {
            return View();
        }
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registroVM)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                { 
                    UserName = registroVM.UserName,
                    Email = registroVM.Email,
                    EmailConfirmed = true,
                };
                var result = await _userManager.CreateAsync(user, registroVM.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Member");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");

                    //return RedirectToAction("Login", "Account");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(registroVM);
        }


        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login");

            var model = new ProfileViewModel { UserName = user.UserName, Email = user.Email };

            ViewBag.AbaAtiva = "visao-geral";
            ViewBag.TituloCard = "Informações pessoais";
            ViewBag.PartialName = "_ProfilePartial";

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> PersonalData()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login");

            var model = new ProfileViewModel { UserName = user.UserName, Email = user.Email };

            ViewBag.AbaAtiva = "pessoais";
            ViewBag.TituloCard = "Alterar dados cadastrais";
            ViewBag.PartialName = "_PersonalDataPartial";

            return View("Profile", model);
        }

        [HttpGet]
        public async Task<IActionResult> Security()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login");


            var model = new ProfileViewModel { UserName = user.UserName, Email = user.Email };

            ViewBag.AbaAtiva = "seguranca";
            ViewBag.TituloCard = "Alterar senha de acesso";
            ViewBag.PartialName = "_SecurityPartial";

            return View("Profile", model);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeUser(ProfileViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AbaAtiva = "pessoais";
                ViewBag.TituloCard = "Alterar dados cadastrais";
                ViewBag.PartialName = "_PersonalDataPartial";
                return View("Profile", model);
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login");

            user.UserName = model.UserName;

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                await _signInManager.RefreshSignInAsync(user);

                TempData["SuccessMessage"] = "Dados atualizados com sucesso!";
                return RedirectToAction("Profile");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            ViewBag.AbaAtiva = "pessoais";
            ViewBag.TituloCard = "Alterar dados cadastrais";
            ViewBag.PartialName = "_PersonalDataPartial";
            return View("Profile", model);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeEmail(ProfileViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AbaAtiva = "pessoais";
                ViewBag.TituloCard = "Alterar dados cadastrais";
                ViewBag.PartialName = "_PersonalDataPartial";
                return View("Profile", model);
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login");

            user.Email = model.Email;
            user.NormalizedEmail = model.Email.ToUpper();
            user.EmailConfirmed = true;

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                await _signInManager.RefreshSignInAsync(user);

                TempData["SuccessMessage"] = "Dados updated com sucesso!";
                return RedirectToAction("Profile");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            ViewBag.AbaAtiva = "pessoais";
            ViewBag.TituloCard = "Alterar dados cadastrais";
            ViewBag.PartialName = "_PersonalDataPartial";
            return View("Profile", model);
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AbaAtiva = "seguranca";
                ViewBag.TituloCard = "Alterar senha de acesso";
                ViewBag.PartialName = "_SecurityPartial";


                var profileModel = new ProfileViewModel();
                return View("Profile", profileModel);
            }


            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login");

            
            var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);

            if (result.Succeeded)
            {
                await _signInManager.RefreshSignInAsync(user);

                TempData["SuccessMessage"] = "Senha alterada com sucesso!";
                return RedirectToAction(nameof(Profile));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            ViewBag.AbaAtiva = "seguranca";
            ViewBag.TituloCard = "Alterar senha de acesso";
            ViewBag.PartialName = "_SecurityPartial";

            var fallbackModel = new ProfileViewModel { UserName = user.UserName, Email = user.Email };
            return View("Profile", fallbackModel);
        }

        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.User = null;
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
