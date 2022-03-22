namespace ProjetoHeranca.Lanchonete
{
    public class Salgadinho : Prato
    {
        public Salgadinho(string recheio, bool Frito) : base (recheio, 6)
        {
            if(Frito){  
                Adicional = true;
                Valor = Valor + 1;
            }   
        }
    }
} 