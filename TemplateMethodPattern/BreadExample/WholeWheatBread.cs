using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.BreadExample
{
    public class WholeWheatBread : Bread
    {
        protected override void Bake()
        {
            Console.WriteLine("Baking the whole wheat bread for 20 minutes.");
        }

        protected override void MixIngredients()
        {
            Console.WriteLine("Gathering ingredients for whole wheat bread.");
        }
    }
}
