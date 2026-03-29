using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignProblems.VendingMachine
{
    public class HasMoneyState : IVendingMachineState
    {
        public void DispenseItem(VendingMachine context)
        {
            Console.WriteLine("Dispensing item: " + context.GetSelectedItem());
            context.SetState(new DispensingState());
        }

        public void InsertCoin(VendingMachine context, double coin)
        {
            Console.WriteLine("Money already inserted");
        }

        public void SelectItem(VendingMachine context, string itemCode)
        {
            Console.WriteLine("Can not select item after inserting money");
        }
    }
}
