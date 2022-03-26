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
                    salasDeAulas.Add(new SalaDeAula(serie, alunos, nomeProfessor));
                }
            } while (opcaoContinuar != 2);
        }
        private List<Aluno> CadastraPrimeirosAlunosDaTurma(){
        
            var continuarAdicionando = 0;
            Console.WriteLine("Deseja adicionar novos alunos ? 1 = S | 2 = N");
            continuarAdicionando = int.Parse(Console.ReadLine());
            var primeirosAlunos = new List<Aluno>();
            while (continuarAdicionando == 1)
            {
                primeirosAlunos.Add(CadastrarNovoAluno());
                Console.WriteLine("Deseja adicionar novos alunos ? 1 = S | 2 = N");
                continuarAdicionando = int.Parse(Console.ReadLine());

            }
            return primeirosAlunos;
        }
    
        private Aluno CadastrarNovoAluno(){
        
            Console.WriteLine("Qual o nome do aluno ?");
            var nomeAluno = Console.ReadLine();
            Console.WriteLine("Qual o CPF do aluno ?");
            var cpfAluno = Console.ReadLine();
            Console.WriteLine("Qual a data de nascimento ?");
            var dataNascimentoAluno = DateTime.Parse(Console.ReadLine());
            return new Aluno(nomeAluno, dataNascimentoAluno, cpfAluno);

        }
    }
}
         
