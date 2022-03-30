namespace ProjetoHeranca.AgTurismo
{
    public class Pacote
    {
        public string Ida { get; set; }
        public string Volta { get; set; }

        public void DataIdaEVolta()
        {
            var dataDeIdaEvolta = 0;
            var opcao = 0;
            do
            {
                Console.WriteLine("Qual a data de ida e volta:");
                dataDeIdaEVolta = int.Parse(Console.ReadLine()); 
                Console.WriteLine("Adicionar café da manhã no pacote, valor de R$ 25: 1 = S | 2 = N");
                Opcao = int.Parse(Console.ReadLine());
                Cosole.WriteLine("Adicionar almoço no pacote, valor de R$ 50: 1 = S | 2 = N");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("Adicionar jantao no pacote, valor de R$ 60: 1 = S | 2 = N");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("As informações estão corretas: 1 = S | 2 = N");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("Deseja sair: esc = S ");
                opcao = int.Parse(Console.ReadLine());

            } while (esc);
        }
        public void Voo(){
            public string EmpresaAerea { get, set, }
            public string Classe { get; set; }
            public string Poltrona { get; set; }
            public double Valor { get; set; }
            public string HorarioDeEmbarque { get; set; }
            public dataTime DataDaPassagem { get; set; }

        }
        
    }
}