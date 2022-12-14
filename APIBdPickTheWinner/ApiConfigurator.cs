using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using APIBdPickTheWinner.Contexts;

namespace APIBdPickTheWinner;

public static partial class ApiConfigurator
{
    public static (WebApplicationBuilder, IServiceCollection) GetAppBuilder(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Configuration.AddJsonFile("appsettings.local.json", true, true);

        return (builder, builder.Services);
    }

    public static async Task RunDatabaseMigration<T>(this WebApplication app, IServiceProvider serviceProvider, ILogger logger)
    {
        if (app is null)
            throw new ArgumentNullException(nameof(app));

        logger.LogInformation("Program start, applying migrations");

        try
        {
            var db = serviceProvider.GetRequiredService<Context>();

            await db.Database.MigrateAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Migrations error");
        }
    }
}
