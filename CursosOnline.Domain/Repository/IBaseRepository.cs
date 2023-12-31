﻿using CursosOnline.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CursosOnline.Domain.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetEntityById(int Id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> Find(Expression<Func<TEntity, bool>> filter);

        Task<IEnumerable<TEntity>> FindAll(Expression<Func<TEntity, bool>> filter);
        Task Save(TEntity entity);
        Task Save(params TEntity[] entities);
        Task Update(TEntity entity);
        Task Update(params TEntity[] entities);

        Task<bool> Exists(Expression<Func<TEntity, bool>> filter);
        Task SaveChanges();

    }
}
