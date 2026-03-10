using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignPattern.Strategy
{
    public class PaymentProcessor
    {
        private IPaymentStrategy _strategy;
        public PaymentProcessor(IPaymentStrategy paymentStrategy) 
        {
            _strategy = paymentStrategy;
        }

        public void Process(decimal amount) 
        {
            _strategy.Pay(amount);
        }
    }
}
