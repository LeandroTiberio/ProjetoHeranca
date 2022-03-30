namespace ProjetoHeranca.Escola
{
    public class Secretaria
    {
        public void CadastrarNovasTurmas()
        {

            var salasDeAulas = new List<SalaDeAula>();
            var opcaoContinuar = 0;
            do
            {
                Console.WriteLine("Deseja adicionar uma nova sala de aula ? 1 = S | 2 = N");
                opcaoContinuar = int.Parse(Console.ReadLine());
                if (opcaoContinuar == 1)
                {
                    Console.WriteLine("Qual o nome do professor ?");
                    var nomeProfessor = Console.ReadLine();
                    Console.WriteLine("Qual a serie ?");
                    var serie = Console.ReadLine();
                    var alunos = CadastraPrimeirosAlunosDaTurma();
                    var Professores = CadastraPrimeirosProfessoresDaTurma();
                    salasDeAulas.Add(new SalaDeAula(serie, alunos, Professores));
                }
            } while (opcaoContinuar != 2);

        }
        private List<Professor> CadastraPrimeirosProfessoresDaTurma(){
            var continuarAdicionando = 0;
            Console.WriteLine("Deseja adicionar novos professores ? 1 = S | 2 = N");
            continuarAdicionando = int.Parse(Console.ReadLine());
            var primeirosProfessores = new List<Professor>();
            while (continuarAdicionando == 1)
            {
                Console.WriteLine("Qual a disciplina do professor ?");
                var disciplina = Console.ReadLine();
                primeirosProfessores.Add(new Professor(CadastrarNovaPessoa(), disciplina));
                Console.WriteLine("Deseja adicionar novos professores ? 1 = S | 2 = N");
                continuarAdicionando = int.Parse(Console.ReadLine());

            }
            return primeirosProfessores;
        }
        private List<Aluno> CadastraPrimeirosAlunosDaTurma(){
        
            var continuarAdicionando = 0;
            Console.WriteLine("Deseja adicionar novos alunos ? 1 = S | 2 = N");
            continuarAdicionando = int.Parse(Console.ReadLine());
            var primeirosAlunos = new List<Aluno>();
            while (continuarAdicionando == 1)
            {
                var pessoa = (CadastrarNovaPessoa());
                primeirosAlunos.Add(new Aluno(pessoa));
                Console.WriteLine("Deseja adicionar novos alunos ? 1 = S | 2 = N");
                continuarAdicionando = int.Parse(Console.ReadLine());

            }
            return primeirosAlunos;
        }
    
        private Pessoa CadastrarNovaPessoa(){
        
            Console.WriteLine("Qual o nome ?");
            var nome = Console.ReadLine();
            Console.WriteLine("Qual o CPF ?");
            var cpf = Console.ReadLine();
            Console.WriteLine("Qual a data de nascimento ?");
            var dataNascimento = DateTime.Parse(Console.ReadLine());
            return new Pessoa(nome, dataNascimento, cpf);

        }
    }
}
         

