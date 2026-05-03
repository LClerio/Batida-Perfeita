using BatidaPerfeita.Context;

namespace BatidaPerfeita.Extensions
{
    public static class SeedExtension
    {
        public static void Seed(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var service = scope.ServiceProvider.GetRequiredService<SeedInitialData>();
            service.Seed();
        }
    }
}
