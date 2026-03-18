using LowLevelDesign.DesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignPattern.Factory
{
    public class PaymentFactory
    {
        public static IPaymentStrategy Create(string type)
        {
            return type switch
            {
                "CARD" => new CardPayment(),
                "NEFT" => new NEFTPayment(),
                "UPI" => new UPIPayment(),
                _ => throw new NotSupportedException("Invalid type selected"),
            };
        }
    }
}
