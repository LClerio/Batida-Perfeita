using BatidaPerfeita.Context;
using BatidaPerfeita.Services.Interfaces;

//namespace BatidaPerfeita.Extensions
//{
//    public static class SeedExtension
//    {
//        public static void Seed(this WebApplication app)
//        {
//            using var scope = app.Services.CreateScope();

//            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

//            context.Database.EnsureCreated();

//            var service = scope.ServiceProvider.GetRequiredService<SeedInitialData>();
//            service.Seed();
//        }
//    }
//}


namespace BatidaPerfeita.Extensions
{
    public static class SeedExtension
    {
        // Alteramos para Task para suportar await, já que o Identity é assíncrono
        public static async Task SeedAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            // 1. Contexto do Banco de Dados
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();

            // 2. Seed de Dados Iniciais (Categorias/Produtos)
            var serviceData = scope.ServiceProvider.GetRequiredService<SeedInitialData>();
            serviceData.Seed(); // Se este for síncrono, mantenha assim

            // 3. Seed de Identity (Roles/Users) - O novo serviço que criamos
            var seedUserRole = scope.ServiceProvider.GetRequiredService<ISeedUserRoleInitial>();

            // Chamadas assíncronas para garantir que perfis e usuários existam
            await seedUserRole.SeedRolesAsync();
            await seedUserRole.SeedUsersAsync();
        }
    }
}