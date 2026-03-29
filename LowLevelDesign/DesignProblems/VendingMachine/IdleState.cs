using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignProblems.VendingMachine
{
    public class IdleState : IVendingMachineState
    {
        public void DispenseItem(VendingMachine context)
        {
            Console.WriteLine("Can not dispense, select item");
        }

        public void InsertCoin(VendingMachine context, double coin)
        {
            Console.WriteLine("Select item before inserting coin");
        }

        public void SelectItem(VendingMachine context, string itemCode)
        {
            context.SetSelectedItem(itemCode);
            Console.WriteLine("Item is selected");
            context.SetState(new ItemSelectedState());
        }
    }
}
