using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignPattern.State
{
    public interface IOrderState
    {
        void Next(Order order);
        void Cancel(Order order);
    }
}
