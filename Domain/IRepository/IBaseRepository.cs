using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepository
{
   public interface IBaseRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);

        Task<IReadOnlyList<T>> ListAllAsync();
    }
}
