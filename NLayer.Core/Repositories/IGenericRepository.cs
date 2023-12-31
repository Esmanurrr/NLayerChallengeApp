﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        // productRepository.where(x=>x.Id>5).orderby.tolistasync()
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
    
}
