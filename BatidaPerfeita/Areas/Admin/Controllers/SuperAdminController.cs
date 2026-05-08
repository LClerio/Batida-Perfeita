using BatidaPerfeita.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BatidaPerfeita.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy = "SuperAdminOnly")]
    public class SuperAdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SuperAdminController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddUserToRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Dados inválidos.";
                return RedirectToAction("Index", "Admin");
            }

            if (await _roleManager.RoleExistsAsync(model.RoleName))
            {
                TempData["Error"] = "Role já existe.";
            } else
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(model.RoleName));
                if (result.Succeeded)
                    TempData["Success"] = "Role criada com sucesso!";
                else
                    TempData["Error"] = "Erro ao criar role.";
            }

            return RedirectToAction("Index", "SuperAdmin");
        }


        [HttpPost]
        public async Task<IActionResult> AddUserToRole(UserRoleViewModel model)
        {
            if (!ModelState.IsValid) return RedirectToAction("Index", "SuperAdmin");

            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
                TempData["Error"] = "Usuário não encontrado.";
                return RedirectToAction("AddUserToRole", "SuperAdmin");
            }

            if (await _roleManager.RoleExistsAsync(model.RoleName))
            {
                var result = await _userManager.AddToRoleAsync(user, model.RoleName);
                if (result.Succeeded)
                    TempData["Success"] = "Usuário vinculado com sucesso!";
                else
                    TempData["Error"] = "Erro ao vincular usuário.";
            }

            return RedirectToAction("Index", "SuperAdmin");
        }
    }
}
