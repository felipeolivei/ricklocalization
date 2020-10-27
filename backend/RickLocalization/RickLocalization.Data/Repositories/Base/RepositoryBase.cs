using Microsoft.EntityFrameworkCore;
using RickLocalization.Data.Context;
using RickLocalization.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RickLocalization.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        protected readonly RickLocalizationDbContext context;
        protected DbSet<TEntity> DbSet;

        public RepositoryBase(RickLocalizationDbContext dbContext)
        {
            this.context = dbContext;
            DbSet = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            entity.CreateAt = DateTime.Now;
            DbSet.Add(entity);
            SaveChanges();
        }

        public void AddRange(List<TEntity> entity)
        {
            entity.ForEach(x => x.CreateAt = DateTime.Now);
            DbSet.AddRange(entity);
            SaveChanges();
        }

        public TEntity Get(int id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public IEnumerable<TEntity> GetAllWhere(Func<TEntity, bool> predicate)
        {
            return DbSet.ToList().Where(predicate);
        }

        public void Remove(TEntity entity)
        {
            DbSet.Remove(entity);
            SaveChanges();
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
            SaveChanges();
        }

        private void SaveChanges()
        {
            context.SaveChanges();
        }

    }
}
