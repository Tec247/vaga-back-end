using AutoBem.Domain.Entities;

namespace AutoBem.Domain.Contracts.Services
{
    public interface IDomainService<TEntity> where TEntity: EntityBase
    {
        Task<TEntity> Adicionar(TEntity entity);
        Task<TEntity> Atualizar(TEntity entity);
        Task<bool> Excluir(int id); 
        Task <IList<TEntity>> Consultar();
        Task<TEntity> Consultar(int id);
    }
}
