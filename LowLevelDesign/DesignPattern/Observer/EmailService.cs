using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignPattern.Observer
{
    public class EmailService : IObserver
    {
        public void Update(User user)
        {
            Console.WriteLine("Updating user from Email Service");
        }
    }
}
