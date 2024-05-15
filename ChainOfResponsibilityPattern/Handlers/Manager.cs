using ChainOfResponsibilityPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class Manager : Approver
    {
        public override void Approve(Purchase purchase)
        {
            if(purchase.Cost < 500)
            {
                Console.WriteLine($"The manager approved the purchase #{purchase.Number} which cost {purchase.Cost:C}");
            }
            else
            {
                Next?.Approve(purchase);
            }
        }
    }
}
