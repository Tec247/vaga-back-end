namespace AutoBem.Application.Contracts
{
    public interface IApplicationService<TEntityDto, TCreateDto, TUpdateDto>
    {
        Task<TEntityDto> Adicionar(TCreateDto viewModel);
        Task<TEntityDto> Editar(TUpdateDto viewModel);
        Task<bool> Excluir(int id);
        Task<TEntityDto> Consultar(int id);
        Task<IList<TEntityDto>> Consultar();
    }
}
