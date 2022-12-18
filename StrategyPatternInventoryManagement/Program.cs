using System;
using System.Collections.Generic;

namespace StrategyPatternInventoryManagement
{
    // The 'Strategy' abstract class
    abstract class InventoryManagementStrategy
    {
        public abstract void UpdateInventory(int itemId, int quantity);
    }

    // A 'ConcreteStrategy' class
    class JustInTimeStrategy : InventoryManagementStrategy
    {
        public override void UpdateInventory(int itemId, int quantity)
        {
            Console.WriteLine("Updating inventory using just-in-time strategy for item with ID {0} and quantity {1}", itemId, quantity);
            Console.ReadKey();
        }
    }

    // A 'ConcreteStrategy' class
    class JustInCaseStrategy : InventoryManagementStrategy
    {
        public override void UpdateInventory(int itemId, int quantity)
        {
            Console.WriteLine("Updating inventory using just-in-case strategy for item with ID {0} and quantity {1}", itemId, quantity);
            Console.ReadKey();
        }
    }

    // The 'Context' class
    class InventoryManager
    {
        private InventoryManagementStrategy _strategy;

        // Constructor
        public InventoryManager(InventoryManagementStrategy strategy)
        {
            this._strategy = strategy;
        }

        // Set new strategy
        public void SetStrategy(InventoryManagementStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void UpdateInventory(int itemId, int quantity)
        {
            _strategy.UpdateInventory(itemId, quantity);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Demo data
            List<InventoryItem> inventory = new List<InventoryItem>
            {
                new InventoryItem { ItemId = 1, Quantity = 10 },
                new InventoryItem { ItemId = 2, Quantity = 20 },
                new InventoryItem { ItemId = 3, Quantity = 30 }
            };

         
            // Create inventory manager with just-in-time strategy
            InventoryManager inventoryManager = new InventoryManager(new JustInTimeStrategy());

            // Update inventory for all items using just-in-time strategy

            foreach (var item in inventory)
            {
                Console.WriteLine("Updating inventory for item with ID {0} and current quantity {1}:", item.ItemId, item.Quantity);
                inventoryManager.UpdateInventory(item.ItemId, item.Quantity);
            }

            Console.ReadKey();

            

            // Set just-in-case strategy
            inventoryManager.SetStrategy(new JustInCaseStrategy());

            // Update inventory for all items using just-in-case strategy
            foreach (var item in inventory)
            {
                Console.WriteLine("Updating inventory for item with ID {0} and current quantity {1}:", item.ItemId, item.Quantity);
                inventoryManager.UpdateInventory(item.ItemId, item.Quantity);
            }

            Console.ReadLine();
        }
    }

    // Inventory item data model
    class InventoryItem
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
    }
}