using NUnit.Framework;
using System.Collections.Generic;
using VendingMachineApp;

namespace VendingMachineApp.UnitTest
{
    public class FileHandlerTest
    {
        
        [Test]
        public static void TestIfItemsImportProperyly()
        {
            FileHandler fileHandler = new FileHandler();

                Dictionary<string, VendingItem> items = fileHandler.GetVendingItems();
                VendingItem item = new Chip("Zapp's Voodoo Chip", 3.05M, 5);
                Assert.AreEqual(item.ItemsRemaining, items["A1"].ItemsRemaining);
               
        }
        
    }
}