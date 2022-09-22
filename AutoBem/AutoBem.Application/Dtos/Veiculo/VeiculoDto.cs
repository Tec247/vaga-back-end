using AutoBem.Application.Dtos.Proprietario;

namespace AutoBem.Application.Dtos.Veiculo
{
    public class VeiculoDto: BaseDto
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int AnoLancamento { get; set; }
        public bool ESegurado { get; set; }
        public int ProprietarioId { get; set; }
        public ProprietarioDto? Proprietario { get; set; }
    }
}
