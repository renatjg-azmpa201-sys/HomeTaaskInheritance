using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask2
{
    internal class Bird : Animal
    {
        public double WingLength { get; set; }
        public Bird(string name, int age, string sound, double wingLength, string breed) : base(name, age, sound, breed)
        {
            WingLength = wingLength;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Sound: {Sound}, WingLength: {WingLength} meters");
        }
    }
}
