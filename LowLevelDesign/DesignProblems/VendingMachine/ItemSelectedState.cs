using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignProblems.VendingMachine
{
    internal class ItemSelectedState : IVendingMachineState
    {
        public void DispenseItem(VendingMachine context)
        {
            Console.WriteLine("Pla pay for selected item");
        }

        public void InsertCoin(VendingMachine context, double coin)
        {
            context.SetInsertedAmount(coin);
            context.SetState(new HasMoneyState());
            Console.WriteLine($"you paid {coin} for item: ${context.GetSelectedItem()}");
        }

        public void SelectItem(VendingMachine context, string itemCode)
        {
            Console.WriteLine("Item already selected" + context.GetSelectedItem());
        }
    }
}
