using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignPattern.Strategy
{
    public class Client
    {
        IPaymentStrategy strategy;

        public void Pay(decimal amount, string paymentMethod)
        {
            if(paymentMethod == "CARD")
            {
                strategy = new CardPayment();
            }
            else if (paymentMethod == "UPI")
            {
                strategy = new UPIPayment();
            }
            else if (paymentMethod == "NEFT")
            {
                strategy = new NEFTPayment();
            }else
            {
                throw new ArgumentException("Given payment method is not supported..");
            }

            strategy.Pay(amount);
        }
    }
}
