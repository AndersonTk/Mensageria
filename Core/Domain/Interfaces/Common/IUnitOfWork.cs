﻿namespace Domain.Interfaces.Base;

public interface IUnitOfWork : IDisposable
{
    public IProductRepository Product { get; set; }
    public ICategoryRepository Category { get; set; }

    Task SaveChangesAsync();
    void Atach<T>(T entity) where T : class;
    Task BeginTransactionAsync();
    Task CommitTransactionAsync();
    Task RollbackTransactionAsync();
}
