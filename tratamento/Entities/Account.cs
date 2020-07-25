using tratamento.Entities.Exceptions;

namespace tratamento.Entities
{
    public class Account
    {
        public int Number {get; set;}
        public string Holder {get; set;}
        public double Balance {get; set;}
        public double WithDrawLimit {get; set;}

        public Account(int number, string holder, double balance, double withdrawlimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withdrawlimit;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void WithDraw(double amount)
        {
            if(amount > WithDrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if(Balance < amount){
                throw new DomainException("Not enough balance");
            }
            else{
                Balance -= amount;
            }
        }
    }
}