using PrototypePattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.ColorRegistryExample
{
    public class Color : IColorPrototype
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
        
        public void Customize(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public IColorPrototype Clone()
        {
            Console.WriteLine($"\nCloning color RGB: {Red},{Green},{Blue}");
            return (MemberwiseClone() as IColorPrototype)!;
        }

    }
}
