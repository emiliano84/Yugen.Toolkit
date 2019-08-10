﻿using System;
using Microsoft.EntityFrameworkCore;
using UwpCommunity.Standard.Data.Models;

namespace UwpCommunity.Standard.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity;
        int SaveChanges<TEntity>(bool updateModified = true) where TEntity : BaseEntity;
    }

    public interface IUnitOfWork<TContext> : IUnitOfWork where TContext : DbContext
    {
        TContext Context { get; }
    }
}