using System;
using System.Collections.Concurrent;
using System.Net.Http.Headers;
using ClassInteraction;

Console.WriteLine("Console Test Application for Lucas Eliasons Inventory System");

// acc test , Items from minecraft

Inventory test = new Inventory();
test.IsActive = true;
Console.WriteLine($"Total inventory slots: {test.TotalInventorySlots}");

// adding items
test.AddItem("Potion of Strength", 6);
test.AddItem("Diamond Sword", 1);
// adding item larger than inventory slots to see if exception works
test.AddItem("Dirt Blocks", 1000);

// Removing items
Console.WriteLine("Removing items:");
bool removedItem = test.RemoveItem("Potion of Strength", 3);
Console.WriteLine($"Removed 3 Potion of Strength: {(removedItem ? "Success" : "Failed")}");

// Logs
// viewing added / removed items (had to google this)
Console.WriteLine("== Item History: ==\n");
foreach (string record in test.RetrieveItemHistory())
{
    Console.WriteLine(record);
}
