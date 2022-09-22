using AutoBem.Domain.Entities;
using System.Linq.Expressions;

namespace AutoBem.Domain.Contracts.Repositories
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        Task<TEntity> Adicionar(TEntity entity);
        Task<TEntity> Atualizar(TEntity entity);
        Task<bool> Excluir(int id);
        Task<TEntity> Consultar(int id);
        Task<IList<TEntity>> Consultar();
        Task<IList<TEntity>> Listar(Expression<Func<TEntity, bool>> expression);
        Task<bool> Any(Expression<Func<TEntity, bool>> expression);
    }
}
