﻿using Cache;
using Hangfire;
using Infra.Data.Context;
using Infra.Ioc.Configuration;
using Infra.Ioc.Configuration.Swagger;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SignalR.Hub.Configuration;

namespace Infra.Ioc.Infraestructure;
public static class ConfigureOptions
{
    public static void ConfigureConsumer(this IServiceCollection services, IConfiguration configuration, string xmlDocumentationName)
    {
        #region CORS
        services.AddCors(options =>
        {
            options.AddPolicy("CorsDevelopment", builder =>
            {
                builder.AllowAnyOrigin();
            });
        });

        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
            {
            });
        });
        #endregion

        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DbConnection"),
        b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        services.AddCacheModule(configuration);
        services.AddDependenceInjectionConsumer(configuration);
        services.AddMediatR();
        services.AddMassTransitConsumer(configuration);
        services.AddLoggerConfig(configuration);
        services.AddHangfire(configuration);
        services.AddVersioningConfig();
        services.AddSwaggerGenConfig(xmlDocumentationName);
        services.ConfigureServiceBroker();
    }

    public static void ConfigureProducer(this IServiceCollection services, IConfiguration configuration, string xmlDocumentationName)
    {
        services.AddDbContext<ProducerDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DbConnection"),
        b => b.MigrationsAssembly(typeof(ProducerDbContext).Assembly.FullName)));

        #region CORS
        services.AddCors(options =>
        {
            options.AddPolicy("CorsDevelopment", builder =>
            {
                builder.AllowAnyOrigin();
            });
        });

        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
            {
            });
        });
        #endregion

        services.AddDependenceInjectionProducer();
        services.AddMassTransitProducer(configuration);
        services.AddVersioningConfig();
        services.AddSwaggerGenConfig(xmlDocumentationName);
    }
}
