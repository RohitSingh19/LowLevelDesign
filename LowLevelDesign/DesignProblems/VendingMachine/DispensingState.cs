using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignProblems.VendingMachine
{
    public class DispensingState : IVendingMachineState
    {
        public void SelectItem(VendingMachine context, string itemCode)
        {
            Console.WriteLine("Please wait, dispensing in progress.");
        }

        public void InsertCoin(VendingMachine context, double amount)
        {
            Console.WriteLine("Please wait, dispensing in progress.");
        }

        public void DispenseItem(VendingMachine context)
        {
            Console.WriteLine("Already dispensing. Please wait.");
        }
    }
}
