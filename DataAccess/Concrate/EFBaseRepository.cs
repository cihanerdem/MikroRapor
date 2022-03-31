using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate
{
    public class EFBaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                await context.Set<TEntity>().AddAsync(entity);
                await context.SaveChangesAsync();
                return entity;
            };
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using (TContext context = new TContext())
            {
                var deleteEntitity = await context.Set<TEntity>().FindAsync(id);
                context.Set<TEntity>().Remove(deleteEntitity);
              var data=  await context.SaveChangesAsync();
                if (data>0)
                {
                    return true;
                }else
                {
                    return false;
                }

            };
        }

        public async  Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return  await context.Set<TEntity>().SingleOrDefaultAsync(filter);
            };
        }

        public async Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context=new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList()
                    : await context.Set<TEntity>().Where(filter).ToListAsync();
            };
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Set<TEntity>().Update(entity);
                await context.SaveChangesAsync();
                return entity;
            };
        }
    }
}
