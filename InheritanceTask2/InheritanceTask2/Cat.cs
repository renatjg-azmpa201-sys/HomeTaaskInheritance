using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask2
{
    internal class Cat : Animal
    {
        public string Color { get; set; }

        public Cat(string name, int age, string sound, string breed, string color) : base(name, age, sound, breed)
        {
            Color = color;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Sound: {Sound}, Color: {Color}");
        }
    }
}
