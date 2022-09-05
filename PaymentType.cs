using System;

namespace progbase_cw_2._2
{
    abstract class PaymentType 
    {
        protected double balance;
        public abstract bool Pay(double amount);
        public double Balance 
        {
            get { return balance; }
        }
    }
    class DebitCardPayment : PaymentType 
    {
        public DebitCardPayment(double balance)
        {
            this.balance = balance;
        }
        public override bool Pay(double amount)
        {
            amount *= 1.03;
            if(balance - amount < 0)
            {
                return false;
            }
            balance -= amount;
            return true;
        }
    }
    class CreditCardPayment : PaymentType
    {
        public CreditCardPayment(double balance)
        {
            this.balance = balance;
        }
        public override bool Pay(double amount)
        {
            amount *= 1.03;
            balance -= amount;
            return true;
        }
    }
    class CashPayment : PaymentType
    {
        public CashPayment(double balance)
        {
            this.balance = balance;
        }
        public override bool Pay(double amount)
        {
            if(balance - amount < 0)
            {
                return false;
            }
            balance -= amount;
            return true;
        }
    }
}
