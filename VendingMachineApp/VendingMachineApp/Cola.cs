using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp
{
   
        public class Cola : VendingItem
        {
            public const string Message = "Glug, Glug, Yum!";

            public Cola(
                string productName,
                decimal price,
                int itemsRemaining)
                    : base(
                    productName,
                    price,
                    itemsRemaining,
                    Message)
            {
            }
        }
    
}
