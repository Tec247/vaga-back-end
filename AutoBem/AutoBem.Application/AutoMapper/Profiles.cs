using AutoBem.Application.Dtos.Proprietario;
using AutoBem.Application.Dtos.Veiculo;
using AutoBem.Domain.Entities;
using AutoMapper;

namespace AutoBem.Application.AutoMapper
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Proprietario, ProprietarioDto>().ReverseMap();
            CreateMap<CreateProprietarioDto, Proprietario>();
            CreateMap<UpdateProprietarioDto, Proprietario>();
            CreateMap<Veiculo, VeiculoDto>().ReverseMap();
            CreateMap<CreateVeiculoDto, Veiculo>();
            CreateMap<UpdateVeiculoDto, Veiculo>();

        } 
    }
}
