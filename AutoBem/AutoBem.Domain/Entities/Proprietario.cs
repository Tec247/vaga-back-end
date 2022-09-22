
namespace AutoBem.Domain.Entities
{
    public class Proprietario : EntityBase
    {
        protected Proprietario() { }

        public Proprietario(string cpf, string nome, DateTime dtNascimento, string numeroTelefone)
        {
            Cpf = cpf;
            Nome = nome;
            DtNascimento = dtNascimento;
            NumeroTelefone = numeroTelefone;
        }

        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public string NumeroTelefone { get; set; }
        public ICollection<Veiculo> Veiculos { get; set; }
    }
}
