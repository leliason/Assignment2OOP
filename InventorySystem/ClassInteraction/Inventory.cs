using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary
{
    public class Inventory
    {
        public int ItemId { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalInventorySlots { get; set; }

        public enum ItemCategory
        {
            Weapon,
            Consumable,
            Currency
        }
        public ItemCategory Category { get; private set; }
        private List<String> ItemHistory;

        public Inventory()
        {
            ItemId = 0;
            Name = "Empty";
            Description = "An empty slot";
            TotalInventorySlots = 10;
            ItemHistory = new List<String>();
        }

    }
}

