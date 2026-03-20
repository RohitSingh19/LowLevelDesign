using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignPattern.Observer
{
    internal class AnalyticsService : IObserver
    {
        public void Update(User user)
        {
            Console.WriteLine("Updating user from Analytics service");
        }
    }
}
