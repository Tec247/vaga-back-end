using AutoBem.Domain.Contracts.Repositories;
using AutoBem.Domain.Contracts.Services;
using AutoBem.Domain.Entities;

namespace AutoBem.Domain.Services
{
    public class DomainService<TEntity> : IDomainService<TEntity> where TEntity : EntityBase
    {
        #region [Properties]

        protected readonly IRepository<TEntity> _repository;

        #endregion

        #region [Constructors]

        public DomainService(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        #endregion

        #region [Public Methods]

        public async Task<TEntity> Adicionar (TEntity entity)
        {
            return await this._repository.Adicionar(entity);
        }
        public async Task<TEntity> Atualizar(TEntity entity)
        {
            return await this._repository.Atualizar(entity);
        }
        public async Task<TEntity> Consultar(int id)
        {
            return await this._repository.Consultar(id);
        }

        public async Task<IList<TEntity>> Consultar()
        {
            return await this._repository.Consultar();
        }

        public async Task<bool> Excluir(int id)
        {
            return await this._repository.Excluir(id);
        }

        #endregion

    }
}
