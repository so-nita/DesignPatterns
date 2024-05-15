using ChainOfResponsibilityPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class President : Approver
    {
        public override void Approve(Purchase purchase)
        {
            if (purchase.Cost < 5000)
            {
                Console.WriteLine($"The president approved the purchase #{purchase.Number} which cost {purchase.Cost:C}");
            }
            else
            {
                Next?.Approve(purchase);
            }
        }
    }
}
