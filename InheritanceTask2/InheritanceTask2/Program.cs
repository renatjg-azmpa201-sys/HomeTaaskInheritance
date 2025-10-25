using InheritanceTask2;
using System;

Dog dog = new Dog("Buddy", 3, "Woof", "Golden Retriever");
Dog anotherDog = new Dog("Max", 4, "Bark", "Beagle");
Cat cat = new Cat("Whiskers", 2, "Meow", "Persian", "Cream");
Cat anotherCat = new Cat("Shadow", 5, "Purr", "Siamese", "Gray");
Bird bird = new Bird("Tweety", 1, "Tweet", 0.25, "Canary");
Bird anotherBird = new Bird("Polly", 2, "Squawk", 0.5, "Parrot");

// If you want to display info individually, uncomment the following code:
//Console.WriteLine("===========================");
//dog.GetInfo();
//Console.WriteLine("===========================");
//anotherDog.GetInfo();
//Console.WriteLine("===========================");
//cat.GetInfo();
//Console.WriteLine("===========================");
//anotherDog.GetInfo();
//Console.WriteLine("===========================");
//bird.GetInfo();
//Console.WriteLine("===========================");
//anotherBird.GetInfo();
//Console.WriteLine("===========================");

Animal[] animals = { dog, anotherDog, cat, anotherCat, bird, anotherBird };

// If you want to use AllAnimals array to display info, uncomment the following code:
//foreach (Animal animal in animals)
//{
//    animal.GetInfo();
//    Console.WriteLine("===========================");
//}
