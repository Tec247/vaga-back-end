using AutoBem.Application.Contracts;
using AutoBem.Application.Dtos.Proprietario;
using AutoBem.Domain.Contracts.Services;
using AutoBem.Domain.Entities;
using AutoMapper;

namespace AutoBem.Application.Services
{
    public class ProprietarioApplication : ApplicationService<ProprietarioDto, Proprietario, CreateProprietarioDto, UpdateProprietarioDto>, IProprietarioApplication
    {
        public ProprietarioApplication(IMapper mapper, IDomainService<Proprietario> service): base(mapper, service)
        {

        }

    }
}
