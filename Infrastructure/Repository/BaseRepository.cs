using Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
   public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly BugTrackerContext _bugTrackerContext;

        public BaseRepository(BugTrackerContext bugTrackerContext)
        {
            _bugTrackerContext = bugTrackerContext;
        }

        public async Task<T> AddAsync(T entity)
        {
           await _bugTrackerContext.Set<T>().AddAsync(entity);
            _bugTrackerContext.SaveChanges();
            return entity;
     
        }


        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _bugTrackerContext.Set<T>().ToListAsync();
        }


    }
}
