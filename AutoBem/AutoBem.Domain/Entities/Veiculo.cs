namespace AutoBem.Domain.Entities
{
    public class Veiculo : EntityBase
    {
        protected Veiculo() { }
        public Veiculo(string placa, string modelo, string marca, string cor, int anoLancamento, bool eSegurado, int proprietarioId)
        {
            Placa = placa; 
            Modelo = modelo;
            Marca = marca;
            Cor = cor;
            AnoLancamento = anoLancamento;
            ESegurado = eSegurado;
            ProprietarioId = proprietarioId;
        }

        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int AnoLancamento { get; set; }
        public bool ESegurado { get; set; }
        public int ProprietarioId { get; set; }
        public Proprietario Proprietario { get; set; }
    }
}
