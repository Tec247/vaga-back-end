using AutoBem.Domain.Contracts.Repositories;
using AutoBem.Domain.Entities;
using AutoBem.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AutoBem.Repository.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        protected readonly AutoBemContext _context;

        public Repository(AutoBemContext context)
        {
            _context = context;

        }
        
        public virtual async Task<TEntity> Adicionar(TEntity entity)
        {
            this._context.Set<TEntity>().Add(entity);
            await this._context.SaveChangesAsync();
            return entity;

        }

        public virtual async Task<TEntity> Atualizar(TEntity entity)
        {
            this._context.Entry(entity).State = EntityState.Modified;
            await this._context.SaveChangesAsync();
            return entity;
        }

        protected IQueryable<TEntity> Consultar(Expression<Func<TEntity, bool>> expression)
        {
            return this._context.Set<TEntity>().Where(expression).AsQueryable();
        }

        public virtual async Task<TEntity> Consultar(int id)
        {
            var entity = await this.Consultar(x => x.Id == id).FirstOrDefaultAsync();
            return entity;
        }

        public async Task<IList<TEntity>> Consultar()
        {
            return await this._context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<bool> Excluir(int id)
        {
            var entityRemover = await this.Consultar(id);
            if (entityRemover == null) return false;
            this._context.Set<TEntity>().Remove(entityRemover);
            return (await this._context.SaveChangesAsync()) > 0;
        }

        public async virtual Task<IList<TEntity>> Listar(Expression<Func<TEntity, bool>> expression)
        {
            return await this.Consultar(expression).ToListAsync();
        }

        public async Task<bool> Any(Expression<Func<TEntity, bool>> expression)
        {
            return await this._context.Set<TEntity>().AnyAsync(expression);
        }

    }
}
