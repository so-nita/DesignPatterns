using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.BreadExample
{
    public class WhiteBread : Bread
    {
        protected override void Bake()
        {
            Console.WriteLine("Baking the white bread for 15 minutes.");
        }

        protected override void MixIngredients()
        {
            Console.WriteLine("Gathering ingredients for white bread.");
        }
    }
}
