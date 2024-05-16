using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ChainOfResponsibilityPattern.Models
{
    public abstract class Approver
    {
        protected Approver? Next { get; set; }
        public Approver RegisterNext(Approver next)
        {
            Next = next;
            return Next;
        }
        public abstract void Approve(Purchase purchase);
    }
}
