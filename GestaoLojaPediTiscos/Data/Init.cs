using Microsoft.AspNetCore.Identity;

namespace GestaoLojaPediTiscos.Data;

public class Init{

    public static async Task CriaDadosIniciais(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {

        //Adicionar Default Roles
        String[] roles = { "Admin", "Funcionario", "Cliente" };

        foreach (var role in roles){

            if (!await roleManager.RoleExistsAsync(role))
                await roleManager.CreateAsync(new IdentityRole(role));

        }

        //Adicionar Default user - Admin
        var defaultUser = new ApplicationUser
        {

            UserName = "admin",
            Email = "admin@isec.pt",
            Nome = "Administrador",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,

        };

        if (userManager.Users.All(u => u.Id != defaultUser.Id)){

            var user = await userManager.FindByEmailAsync(defaultUser.Email);

            if (user == null){

                await userManager.CreateAsync(defaultUser, "Admin@123");

                await userManager.AddToRoleAsync(defaultUser, "Admin");

            }

        }
    }
    public static async Task CriaDadosIniciaisv2(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        // Add default roles
        String[] roles = { "Admin", "Funcionario", "Cliente" };

        foreach (var role in roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
                await roleManager.CreateAsync(new IdentityRole(role));
        }

        // Add default user - Admin
        var defaultUser = new ApplicationUser
        {
            UserName = "admin",
            Email = "admin@isec.pt",
            Nome = "Administrador",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
        };

        if (userManager.Users.All(u => u.Id != defaultUser.Id))
        {
            var user = await userManager.FindByEmailAsync(defaultUser.Email);

            if (user == null)
            {
                var result = await userManager.CreateAsync(defaultUser, "Str0ng!Passw0rd");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(defaultUser, "Admin");
                    Console.WriteLine("Default admin user created successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to create default admin user:");
                    foreach (var error in result.Errors)
                    {
                        Console.WriteLine($"- {error.Description}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Default admin user already exists.");
            }
        }
    }

}
