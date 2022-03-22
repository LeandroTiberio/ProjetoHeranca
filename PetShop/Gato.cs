namespace ProjetoHeranca.PetShop
{
    public class Gato : Animal
    {
        public override int TomarBanho(){
            return 10;
        }

        public override int Comer (){
            return 50;
        }
    }
}