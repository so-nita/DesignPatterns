using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Models
{
    public class Purchase
    {
        public int Number { get; set; }
        public decimal Cost { get; set; }
        public string Purpose { get; set; } = string.Empty;
    }
}
