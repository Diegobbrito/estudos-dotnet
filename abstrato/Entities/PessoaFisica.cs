namespace abstrato.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double Saude {get; set;}

        public PessoaFisica(string nome, double renda, double saude) : base(nome, renda)
        {
            Saude = saude;
        }

         public override double Imposto()
        {
            if(Saude > 0){
                Saude = Saude / 2;
            }
            if(Renda < 20000.00){
                return Renda * 0.15 - Saude;                
            }
            return Renda * 0.25 - Saude;
        }
    }
}