using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignPattern.State
{
    public class Order
    {
        public IOrderState state;
        public void SetState(IOrderState newState)
        {
            this.state = newState; 
        }

        public void Next()
        {
            state.Next(this);
        }

        public void Cancel()
        {
            state.Cancel(this);
        }
    }
}
