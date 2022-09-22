using AutoBem.Application.Contracts;
using AutoBem.Application.Dtos;
using AutoBem.Domain.Contracts.Services;
using AutoBem.Domain.Entities;
using AutoMapper;

namespace AutoBem.Application.Services
{
    public  class ApplicationService<TEntityDto, TEntity, TCreateDto, TUpdateDto> : IApplicationService<TEntityDto, TCreateDto, TUpdateDto> where TEntityDto : BaseDto where TEntity : EntityBase
    {
        protected readonly IMapper _mapper;
        protected readonly IDomainService<TEntity> _service;

        public ApplicationService(IMapper mapper, IDomainService<TEntity> service)
        {
            _mapper = mapper;
            _service = service;
        }

        public virtual async Task<TEntityDto> Adicionar(TCreateDto viewModel)
        {
            var entity = this._mapper.Map<TEntity>(viewModel);
            await this._service.Adicionar(entity);
            return this._mapper.Map<TEntityDto>(entity);
        }

        public virtual async Task<TEntityDto> Consultar(int id)
        {
            var entity = await this._service.Consultar(id);
            return this._mapper.Map<TEntityDto>(entity);
        }

        public async Task<IList<TEntityDto>> Consultar()
        {
            return _mapper.Map<IList<TEntityDto>>(await _service.Consultar());
        }

        public virtual async Task<TEntityDto> Editar(TUpdateDto viewModel)
        {
            var entity = this._mapper.Map<TEntity>(viewModel);
            await this._service.Atualizar(entity);
            return this._mapper.Map<TEntityDto>(entity);
        }

        public virtual async Task<bool> Excluir(int id)
        {
            return await this._service.Excluir(id);
        }
    }
}
