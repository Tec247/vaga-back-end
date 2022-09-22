
using AutoBem.Application.Dtos.Veiculo;

namespace AutoBem.Application.Dtos.Proprietario
{
    public class ProprietarioDto : BaseDto
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string DtNascimento { get; set; }
        public string NumeroTelefone { get; set; }
        public ICollection<VeiculoDto>? Veiculos { get; set; }

    }
}
