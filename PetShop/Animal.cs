namespace ProjetoHeranca.PetShop
{
    public class Animal 
    {
        public string Raca { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }

        public virtual int TomarBanho(){
            return 20;
        }

        public virtual int Comer(){
            return 40;
        }
    }
} 