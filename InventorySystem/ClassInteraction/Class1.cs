using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInteraction
{
    public class Item
    {
        public int ItemId { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public enum ItemCategory
        {
            Weapon,
            Consumable,
            Currency
        }
        public ItemCategory Category { get; private set; }
        private List<String> ItemHistory;

    }
}

