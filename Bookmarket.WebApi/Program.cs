using Bookmarket.WebApi.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;

namespace Bookmarket.WebApi;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		LogManager.Setup().LoadConfigurationFromFile("nlog.config", true);

		ConfigureServices(builder.Services, builder.Configuration);
		var app = builder.Build();
		ConfigureApp(app);

		app.MapControllers();
		app.Run();
	}

	public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
	{
		services.ConfigureCors();
		services.ConfigureIISIntegration();

		services.ConfigureSqlContext(configuration);

		services.ConfigureLoggerService();
		services.ConfigureRepositoryManager();
		services.ConfigureServiceManager();

		services.AddControllers();
	}

	public static void ConfigureApp(IApplicationBuilder app)
	{
		app.UseHttpsRedirection();

		app.UseForwardedHeaders(new ForwardedHeadersOptions
		{
			ForwardedHeaders = ForwardedHeaders.All
		});

		app.UseCors("CorsPolicy");

		app.UseAuthorization();
	}
}
