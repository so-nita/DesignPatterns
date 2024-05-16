using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.BreadExample
{
    public abstract class Bread
    {
        public void Make()
        {
            MixIngredients();
            Bake();
            Slice();
        }

        protected abstract void MixIngredients();

        protected abstract void Bake();

        protected virtual void Slice() =>
            Console.WriteLine($"Slicing the {GetType().Name}!");
    }
}
