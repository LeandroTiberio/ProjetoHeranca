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

 