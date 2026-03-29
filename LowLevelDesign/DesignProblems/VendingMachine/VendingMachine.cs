using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignProblems.VendingMachine
{
    public class VendingMachine
    {
        IVendingMachineState currentSelectedState;
        string selectedItem = string.Empty;
        double selectedItemCost = 0;
        public VendingMachine()
        {
            currentSelectedState = new IdleState();
        }

        /// <summary>
        /// Sets the state of Vending Machine
        /// </summary>
        /// <param name="vendingMachineState"></param>
        public void SetState(IVendingMachineState vendingMachineState)
        {
            currentSelectedState = vendingMachineState;
        }

        /// <summary>
        /// Returns the state of Vending Machine
        /// </summary>
        /// <returns></returns>
        public IVendingMachineState GetState() 
        {
            return currentSelectedState;
        }

        /// <summary>
        /// Returns selected item
        /// </summary>
        /// <returns></returns>
        public string GetSelectedItem()
        {
            return selectedItem; 
        }

        /// <summary>
        /// Set Selected Item
        /// </summary>
        /// <param name="itemCode"></param>
        public void SetSelectedItem(string itemCode)
        {
            selectedItem = itemCode;
        }

        /// <summary>
        /// Accept inserted amount
        /// </summary>
        /// <param name="amount"></param>
        public void SetInsertedAmount(double amount) 
        {
            selectedItemCost = amount;
        }

        public void SelectItem(string itemCode) 
        {
            currentSelectedState.SelectItem(this, itemCode);
        }

        public void InsertCoin(double amount) 
        {
            currentSelectedState.InsertCoin(this, amount);        
        }

        public void DispenseItem() 
        {
            currentSelectedState.DispenseItem(this);
        }
    }
}
