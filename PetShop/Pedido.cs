namespace ProjetoHeranca.PetShop
{
    public class Pedido
    {
        public string NomeDoDono { get; set; }
        public string TelefoneDoDono { get; set; }
        public Animal[] Animais { get; set; }
        public Pedido (string nomeDoDono, string telefoneDoDono, Animal[] animais)
        {
            NomeDoDono = nomeDoDono;
            TelefoneDoDono = telefoneDoDono;
            Animais = animais;
        }

        public float CalcularValor(){
            float valorAtual = 0;
            for(var contador = 0; contador < Animais.Length; contador++){
                Animal animalAtual = Animais[contador];
                valorAtual = valorAtual + ( (animalAtual.Comer() *2) + (animalAtual.TomarBanho() *3) ); 
            }
            return valorAtual;
        }

    }
}