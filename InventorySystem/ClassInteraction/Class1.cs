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
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsObtained { get; set; }

        public enum ItemCount
        {
            Money,
            ItemCount,

        }
    }
}
