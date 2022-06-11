using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Data.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll(); 
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        void Update(T entity); 
        void Remove(T entity);
        

    }
}
