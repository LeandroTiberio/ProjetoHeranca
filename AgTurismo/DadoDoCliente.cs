namespace ProjetoHeranca.AgTurismo
{
    public class DadoDoCliente
    {
        public string CPF { get; }
        public string Nome { get; }
        public DateTime DataDeNascimento { get; }

        public DadoDoCliente(string nome, DateTime dataNascimento, string cpf)
        {
            Nome = nome;
            DataDeNascimento = dataNascimento;
            CPF = cpf;
        }
    }
}