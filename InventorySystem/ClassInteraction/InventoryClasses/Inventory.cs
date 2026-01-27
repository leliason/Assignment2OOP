using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassInteraction
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
        private List<string> ItemHistory;

        public Inventory()
        {
            ItemId = 0;
            Name = "Empty";
            Description = "An empty slot";
            TotalInventorySlots = 10;
            ItemHistory = new List<string>();
        }

        public Inventory(int ID, string name, ItemCategory category, int slots)
        {
            ItemId = ID;
            Name = name;
            Description = "";
            TotalInventorySlots = slots;
            Category = category;
            ItemHistory = new List<string>();
        }


        public virtual void AddItem(string itemname, int quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than 0");
            }
            ItemHistory.Add($"Added {quantity}x {itemname} on {DateTime.Now}");
        }
        public virtual bool RemoveItem(string itemname, int quantity)
        {
            if (quantity <= 0 || quantity > TotalInventorySlots)
            {
                return false;
            }
            ItemHistory.Add($"Removed {quantity}x {itemname} on {DateTime.Now}");
            return true;
        }

        public List<string> RetrieveItemHistory()
        {
            return ItemHistory;
        }

        public override string ToString()
        {
            return $"Item ID: {ItemId}, Name: {Name}, Category: {Category}, Description: {Description}, Slots: {TotalInventorySlots}";
        }
        public void ClearInventory()
        {
            ItemHistory.Add($"Inventory cleared on {DateTime.Now}");
        }

        public void ClearInventory(string reason)
        {
            ItemHistory.Add($"Inventory cleared on {DateTime.Now}. Reason: {reason}");
        }
    }
}

