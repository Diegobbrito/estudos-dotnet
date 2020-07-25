namespace abstrato.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int Funcionarios {get; set;}

        public PessoaJuridica(string nome, double renda, int funcionarios) : base(nome, renda)
        {
            Funcionarios = funcionarios;
        }

        public override double Imposto()
        {
            if(Funcionarios > 10){
                return Renda * 0.14;
            }
            return Renda * 0.16;
        }
    }
}