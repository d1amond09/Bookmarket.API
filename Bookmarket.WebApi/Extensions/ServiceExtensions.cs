﻿using Bookmarket.Persistence;
using Contracts;
using LoggerService;
using Microsoft.EntityFrameworkCore;

namespace Bookmarket.WebApi.Extensions;

public static class ServiceExtensions
{
	public static void ConfigureCors(this IServiceCollection services) =>
		services.AddCors(options =>
		{
			options.AddPolicy("CorsPolicy", builder =>
			builder.AllowAnyOrigin()
			.AllowAnyMethod()
			.AllowAnyHeader());
		});

	public static void ConfigureIISIntegration(this IServiceCollection services) =>
		services.Configure<IISOptions>(options =>
		{
		});

	public static void ConfigureLoggerService(this IServiceCollection services) =>
		services.AddSingleton<ILoggerManager, LoggerManager>();

	public static void ConfigureSqlContext(this IServiceCollection services,
		IConfiguration configuration) =>
		services.AddDbContext<BookmarketDbContext>(opts =>
		opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"), b =>
		{
			b.MigrationsAssembly("Bookmarket.WebApi");
			b.EnableRetryOnFailure();
		}
		));
}