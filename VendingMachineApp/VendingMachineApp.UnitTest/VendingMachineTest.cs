using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineApp;


namespace VendingMachineApp.UnitTest
{
    class VendingMachineTest
    {
        [Test]
        public void TestsIfDepositingCashWorksCorrectly()
        {
            int expected=5; string input = "5";
             VendingMachine vm = new VendingMachine();
            vm.Money.AddMoney(input);
            decimal result = vm.Money.MoneyInMachine;

            Assert.AreEqual((decimal)expected, result);
        }
        [Test]
        public void TestsIfReturnCashAsExpected()
        {
            VendingMachine vm = new VendingMachine();
            vm.Money.AddMoney("1.35");
            string result = vm.Money.GiveChange();

            Assert.AreEqual(result, "Your change is 5 quarters and 1 dimes");

        }

        [Test]
        public void TestsIfWillReturnOutOfStockIfSold5orMore()
        {
            VendingMachine vm = new VendingMachine();
            var menu = new Menu();
            vm.Money.AddMoney("10");
            vm.RetreiveItem("A4");
            vm.RetreiveItem("A4");
            vm.RetreiveItem("A4");
            vm.RetreiveItem("A4");
            vm.RetreiveItem("A4");
            vm.RetreiveItem("A4");
            string result = vm.VendingMachineItems["A4"].MessageWhenSoldOut;
            string expected = "Sold out of Zapp's Blood Moon Chip!\nBuy something else!";

            Assert.AreEqual(expected, result);

        }

        [Test]
        public void TestsIfNotEnoughMoneyEnteredToPurchaseItem()
        {
            VendingMachine vm = new VendingMachine();
            vm.RetreiveItem("A1");
            string result = vm.NotEnoughMoneyError;
            Assert.AreEqual("Not enough money in the machine to complete the transaction.", result);
        }

    }
}
