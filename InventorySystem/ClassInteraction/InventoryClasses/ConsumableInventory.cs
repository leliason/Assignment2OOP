using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInteraction.InventoryClasses
{
    public class ConsumableInventory : Inventory
    {
        public int UsesRemaining {  get; private set; }

        public ConsumableInventory(int ItemID, string name, int slots, int uses) 
            : base(ItemID, name, ItemCategory.Consumable, slots)
        {
            UsesRemaining = uses;
        }

        public override bool RemoveItem(string itemname, int quantity)
        {
            if (quantity <= 0 || UsesRemaining <= 0)
            {
                return false;
            }
            UsesRemaining -= quantity;
            return true;
        }




    }
}
