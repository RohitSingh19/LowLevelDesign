using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignPattern.Observer
{
    public interface IObserver
    {
        void Update(User user);
    }
}
