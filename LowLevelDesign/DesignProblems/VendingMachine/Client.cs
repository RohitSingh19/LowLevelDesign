using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignProblems.VendingMachine
{
    /// <summary>
    /// Responsible to run Vending machine
    /// </summary>
    public class Client
    {
        public void RunVendingMachine()
        {
            VendingMachine vm = new VendingMachine();
            vm.InsertCoin(100); //this should fail, because item is not selected
            vm.SelectItem("A10");
            vm.SelectItem("A11"); //this should fail, because item is already selected
            vm.InsertCoin(100);
            vm.DispenseItem(); //dispense item
        }
    }
}
