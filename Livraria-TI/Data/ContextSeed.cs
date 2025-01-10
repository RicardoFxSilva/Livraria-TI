using Microsoft.AspNetCore.Identity;

namespace Livraria_TI.Data
{
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Moderator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Basic.ToString()));
        }

        public static async Task SeedSuperAdminAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var defaultUser = new IdentityUser
            {
                UserName = "admin",
                Email = "admin@admin.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            // Check if the user already exists
            var user = await userManager.FindByEmailAsync(defaultUser.Email);
            if (user == null)
            {
                // Use a custom password here for the SuperAdmin
                var createResult = await userManager.CreateAsync(defaultUser, "123");  // Simple password

                if (createResult.Succeeded)
                {
                    // Add roles to the SuperAdmin
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Basic.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Moderator.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Admin.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.SuperAdmin.ToString());
                }
                else
                {
                    // Handle creation failure (optional: log the errors or throw an exception)
                    var errors = string.Join(", ", createResult.Errors.Select(e => e.Description));
                    Console.WriteLine($"Error creating user: {errors}");
                }
            }
        }


        public static async Task SeedAdminAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {

            var defaultUser = new IdentityUser
            {
                UserName = "admin@mail.com",
                Email = "admin@mail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "1234Abcd#");
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Basic.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Moderator.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Admin.ToString());
                }
            }

        }

        public static async Task SeedModeratorAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {

            var defaultUser = new IdentityUser
            {
                UserName = "moderator@mail.com",
                Email = "moderator@mail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "1234Abcd#");
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Basic.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Moderator.ToString());
                }
            }

        }

        public static async Task SeedBasicAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {

            var defaultUser = new IdentityUser
            {
                UserName = "basic@mail.com",
                Email = "basic@mail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "1234Abcd#");
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Basic.ToString());
                }
            }

        }
    }
}
