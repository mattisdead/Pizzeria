using System;

namespace progbase_cw_2._2
{
    internal class Customer
    {
        public PaymentType paymentType;
        public Customer(PaymentType paymentType)
        {
            this.paymentType = paymentType;
        }
        public bool PayForOrder(double amount)
        {
            return paymentType.Pay(amount);
        }
    }
}
