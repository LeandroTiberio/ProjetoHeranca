using ProjetoHeranca.Lanchonete;
namespace ProjetoHeranca
{
    public class Program

    {
        static void Main(string[] args){
            
            Prato[] pratos = new Prato[4];
            pratos[0] = new Pizza ("Napolitana", true);
            pratos[1] = new Lanche ("X Bacon", false);
            pratos[2] = new Salgadinho ("Risoli Carne", false);
            pratos[3] = new Salgadinho ("Coxinha", true);
            Pedido pedido = new Pedido("Leandro Tiberio", pratos);
            Console.WriteLine("O valor total é " + pedido.CalcularValor());
            Console.WriteLine("Seu troco é " + pedido.RealizarPagamento(100));

        }
 
    }
}

using ProjetoHeranca.Lanchonete;
namespace ProjetoHeranca
{
    public class Program
    {

        static void Main(string[] args){

            var numeros = new List<int>();
            var numerosMaisDez = new List<int>();
            var strings = new List<string>();
            for(var contador = 0; contador < 10; contador++){
                numeros.Add(contador);
                numerosMaisDez.Add(contador+10);
                strings.Add(contador.ToString());
            }
            numeros.AddRange(numerosMaisUm);
            var tentativaUm = numeros.Remove(5); // Remove o valor independente da posição e devolve se removido
            var tentativaDois = numeros.RemoveAt(3); // Remove do indice escolhido
            numeros.RemoveAll(numeroARemover => numeroARemover); // Remove todos os itens que atenda
            numeros.RemoveRange(0, 5); // Remove itens em sequencia, parametros a primeira posição e 
            Console.WriteLine("Finalizou");
            
        }
    }


}
 