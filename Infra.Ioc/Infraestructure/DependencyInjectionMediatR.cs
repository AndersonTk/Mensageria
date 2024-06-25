﻿using Application.Common.MediatR.Queries;
using Application.Common.Queries;
using Common.MediatR.Commands;
using Domain.Entities;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Ioc.Infraestructure;

public static class DependencyInjectionMediatR
{
    public static IServiceCollection AddMediatR(this IServiceCollection service)
    {
        #region Mediator
        var myHandlers = AppDomain.CurrentDomain.Load("Application");
        service.AddMediatR(myHandlers);

        service.AddScoped<IRequestHandler<GetAllQuery<Product>, IEnumerable<Product>>, GetAllQueryHandler<Product>>();
        service.AddScoped<IRequestHandler<GetByIdQuery<Product>, Product>, GetByIdQueryHandler<Product>>();
        service.AddScoped<IRequestHandler<GetQuerablePredicated<Product>, IQueryable<Product>>, GetQuerablePredicatedHandler<Product>>();
        service.AddScoped<IRequestHandler<PutEntityCommand<Product>, Product>, PutEntityCommandHandler<Product>>();
        service.AddScoped<IRequestHandler<DeleteEntityCommand<Product>, bool>, DeleteEntityCommandHandler<Product>>();
        #endregion

        return service;
    }
}
