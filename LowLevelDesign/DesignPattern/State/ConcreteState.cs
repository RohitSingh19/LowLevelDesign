using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignPattern.State
{
    class CreatedState : IOrderState
    {
        public void Next(Order context)
        {
            context.SetState(new PaidState());
        }

        public void Cancel(Order context)
        {
            context.SetState(new CancelledState());
        }
    }

    class PaidState : IOrderState
    {
        public void Next(Order context)
        {
            context.SetState(new ShippedState());
        }

        public void Cancel(Order context)
        {
            context.SetState(new CancelledState());
        }
    }

    class ShippedState : IOrderState
    {
        public void Next(Order context)
        {
            context.SetState(new DeliveredState());
        }

        public void Cancel(Order context)
        {
            throw new Exception("Cannot cancel after shipping");
        }
    }

    class CancelledState : IOrderState
    {
        public void Cancel(Order order)
        {
            throw new Exception("Order is cancelled no further actions can be performed");
        }

        public void Next(Order order)
        {
            throw new NotImplementedException();
        }
    }

    class DeliveredState : IOrderState
    {
        public void Cancel(Order order)
        {
            throw new Exception("Order is delivered no further actions can be performed");
        }

        public void Next(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
