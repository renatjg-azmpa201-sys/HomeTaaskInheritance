using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask2
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sound { get; set; }

        public Animal()
        {
            Name = "Unknown";
            Age = 0;
            Sound = "Silent";
        }

        public Animal(string name, int age, string sound, string breed)
        {
            Name = name;
            Age = age;
            Sound = sound;
            
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Sound: {Sound}");
        }
    }
}
