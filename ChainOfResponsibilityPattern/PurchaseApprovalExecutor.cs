using ChainOfResponsibilityPattern.Handlers;
using ChainOfResponsibilityPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public static class PurchaseApprovalExecutor
    {
        public static void Excute()
        {
            Console.WriteLine("Purchase approval example");

            Approver manager = new Manager();
            Approver director = new Director();
            Approver president = new President();
            Approver meeting = new ExecutiveMeeting();

            manager.RegisterNext(director)
                   .RegisterNext(president)
                   .RegisterNext(meeting);

            var lowCostPurchase = new Purchase { Number = 1, Cost = 400, Purpose = "Whiteboard purchase." };
            var mediumCostPurchase = new Purchase { Number = 2, Cost = 3000, Purpose = "Laptops purchase." };
            var highCostPurchase = new Purchase { Number = 3, Cost = 11500, Purpose = "Car purchase." };

            manager.Approve(lowCostPurchase);
            manager.Approve(mediumCostPurchase);
            manager.Approve(highCostPurchase);
        }
    }
}
