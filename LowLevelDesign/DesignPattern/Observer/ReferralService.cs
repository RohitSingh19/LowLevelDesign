using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignPattern.Observer
{
    internal class ReferralService : IObserver
    {
        public void Update(User user)
        {
            Console.WriteLine("Referral service updated");
        }
    }
}
