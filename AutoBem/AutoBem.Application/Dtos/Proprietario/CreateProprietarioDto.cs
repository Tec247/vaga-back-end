
namespace AutoBem.Application.Dtos.Proprietario
{
    public  class CreateProprietarioDto
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public string NumeroTelefone { get; set; }
    }
}
