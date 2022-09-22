using AutoBem.Application.Dtos.Veiculo;


namespace AutoBem.Application.Contracts
{
    public interface IVeiculoApplication : IApplicationService<VeiculoDto, CreateVeiculoDto, UpdateVeiculoDto>
    {
    }
}
