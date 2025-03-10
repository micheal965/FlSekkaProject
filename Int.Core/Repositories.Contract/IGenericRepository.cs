﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int.Core.Repositories.Contract
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        //   Task<IEnumerable<TEntity>> GetAllAsync();
        // Task<TEntity> GetByIdAsync(int id);
        Task AddAsync(TEntity entity);

        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
