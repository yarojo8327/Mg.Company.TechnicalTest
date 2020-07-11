using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Mg.Company.Infraestructure.Core.Repository.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        #region IRepository<T> Members

       
        IQueryable<TEntity> AsQueryable();

      
        IEnumerable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity Find(Expression<Func<TEntity, bool>> predicate);

     
        IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties);

        
        IEnumerable<TEntity> FindAllNoTracking(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties);

       
        TEntity First(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties);

       
        TEntity Last(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties);

       
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties);

      
        TEntity LastOrDefault(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties);

        
        TEntity Single(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties);

     
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties);

      
        void Insert(TEntity entity);

       
        void Insert(IEnumerable<TEntity> entities);

        
        void Update(TEntity entity);

       
        void Update(IEnumerable<TEntity> entities);

      
        void Delete(TEntity entity);

       
        void Delete(object id);

       
        void Delete(IEnumerable<TEntity> entities);

        #endregion IRepository<T> Members

        #region SQL Queries

        int ExecuteSqlCommand(string query, params object[] parameters);

        #endregion SQL Queries
    }
}
