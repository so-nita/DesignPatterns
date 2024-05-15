using ChainOfResponsibilityPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class Director : Approver
    {
        public override void Approve(Purchase purchase)
        {
            if (purchase.Cost < 1000)
            {
                Console.WriteLine($"The director approved the purchase #{purchase.Number} which cost {purchase.Cost:C}");
            }
            else
            {
                Next?.Approve(purchase);
            }
        }
    }
}
