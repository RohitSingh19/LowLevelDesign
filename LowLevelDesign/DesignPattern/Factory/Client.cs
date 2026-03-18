using LowLevelDesign.DesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignPattern.Factory
{
    public class Client { 
    
        public void Pay(string paymentType, decimal amount)
        {
            IPaymentStrategy paymentStrategy = PaymentFactory.Create(paymentType);
            paymentStrategy.Pay(amount);
        }
    }
}
