using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignProblems.VendingMachine
{
    public interface IVendingMachineState
    {
        public void SelectItem(VendingMachine context, string itemCode);
        public void InsertCoin(VendingMachine context, double coin);
        public void DispenseItem(VendingMachine context);

    }
}
