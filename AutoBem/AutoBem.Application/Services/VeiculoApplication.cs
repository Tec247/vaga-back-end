using AutoBem.Application.Contracts;
using AutoBem.Application.Dtos.Veiculo;
using AutoBem.Domain.Contracts.Services;
using AutoBem.Domain.Entities;
using AutoMapper;

namespace AutoBem.Application.Services
{
    public class VeiculoApplication : ApplicationService<VeiculoDto, Veiculo, CreateVeiculoDto, UpdateVeiculoDto>, IVeiculoApplication
    {
        public VeiculoApplication(IMapper mapper, IDomainService<Veiculo> service) : base(mapper, service)
        {
        }
    }
}
