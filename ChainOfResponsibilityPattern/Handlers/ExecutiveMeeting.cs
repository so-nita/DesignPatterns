using ChainOfResponsibilityPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class ExecutiveMeeting : Approver
    {
        public override void Approve(Purchase purchase)
        {
            Console.WriteLine($"The executive meeting in order to be approved the purchase #{purchase.Number} which cost {purchase.Cost:C}");
        }
    }
}
