using BatidaPerfeita.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace BatidaPerfeita.Services
{
    public class SeedUserRoleInitial : ISeedUserRoleInitial
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedUserRoleInitial(UserManager<IdentityUser> userManager,
                                   RoleManager<IdentityRole> roleManager) 
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task SeedRolesAsync()
        {
            if (!await _roleManager.RoleExistsAsync("Member"))
                await _roleManager.CreateAsync(new IdentityRole("Member"));

            if (!await _roleManager.RoleExistsAsync("Admin"))
                await _roleManager.CreateAsync(new IdentityRole("Admin"));

            if (!await _roleManager.RoleExistsAsync("SuperAdmin"))
                await _roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
        }

        public async Task SeedUsersAsync()
        {
            if (await _userManager.FindByEmailAsync("usuario@localhost") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "Usuario",
                    Email = "usuario@localhost",
                    EmailConfirmed = true
                };

                var result = await _userManager.CreateAsync(user, "Test@321");

                if (result.Succeeded)
                    await _userManager.AddToRoleAsync(user, "Member");
            }

            if (await _userManager.FindByEmailAsync("admin@localhost") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "Admin",
                    Email = "admin@localhost",
                    EmailConfirmed = true
                };

                var result = await _userManager.CreateAsync(user, "Admin#321");

                if (result.Succeeded)
                    await _userManager.AddToRoleAsync(user, "Admin");
            }

            if (await _userManager.FindByEmailAsync("superadmin@localhost") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "SuperAdmin",
                    Email = "superadmin@localhost",
                    EmailConfirmed = true
                };

                var result = await _userManager.CreateAsync(user, "SuperAdmin#321");

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "SuperAdmin");
                    await _userManager.AddToRoleAsync(user, "Admin");
                }
            }
        }
    }
}
