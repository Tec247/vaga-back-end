namespace AutoBem.Application.Dtos.Veiculo
{
    public class CreateVeiculoDto
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int AnoLancamento { get; set; }
        public bool ESegurado { get; set; }
        public int ProprietarioId { get; set; }
    }
}
