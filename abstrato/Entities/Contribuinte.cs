namespace abstrato.Entities
{
    abstract class Contribuinte
    {
        public string Nome {get; set;}
        public double Renda {get; set;}

        public Contribuinte(string nome, double renda)
        {
            Nome = nome;
            Renda = renda;
        }

        public abstract double Imposto();
        
    }
}