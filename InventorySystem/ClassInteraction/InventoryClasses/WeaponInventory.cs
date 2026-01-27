using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInteraction.InventoryClasses
{
    internal class WeaponInventory : Inventory
    {
        public int WeaponDurability { get; private set; }
        public int MaxWeaponDurability { get; private set; }

        public WeaponInventory(int ItemID, string name, int slots, int maxDurability)
        : base(ItemID, name, ItemCategory.Weapon, slots)
        {
            MaxWeaponDurability = maxDurability;
            WeaponDurability = maxDurability;
        }

        public void RepairWeapon()
        {
            WeaponDurability = MaxWeaponDurability;
        }
        public override bool RemoveItem(string itemname, int quantity)
        {
            if (WeaponDurability <= 0) return false;
            WeaponDurability -= quantity;
            return base.RemoveItem(itemname, quantity);
        }
    }
}
