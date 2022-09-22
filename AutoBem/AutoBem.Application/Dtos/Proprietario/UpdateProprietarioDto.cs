namespace AutoBem.Application.Dtos.Proprietario
{
    public class UpdateProprietarioDto
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public string NumeroTelefone { get; set; }
    }
}
