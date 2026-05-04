using BatidaPerfeita.Context;
using Microsoft.Extensions.DependencyInjection; // Certifique-se de ter este using

namespace BatidaPerfeita.Extensions
{
    public static class SeedExtension
    {
        public static void Seed(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            context.Database.EnsureCreated();

            var service = scope.ServiceProvider.GetRequiredService<SeedInitialData>();
            service.Seed();
        }
    }
}