namespace ProjetoHeranca.Escola
{
    public class Aluno
    {
        public string CPF { get; }
        public string Nome { get; }
        public DataTime DataDeNascimeto { get; }

        public Aluno(string nome, DataTime dataNascimento, string CPF)
        {
            Nome = nome;
            DataDeNascimento = dataNascimento;
            CPF = cpf;
        }
    }
}