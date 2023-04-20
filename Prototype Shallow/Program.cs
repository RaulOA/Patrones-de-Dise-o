using System;

namespace Prototype_Shallow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal() { Nombre = "Oveja Dolly", Patas = 4 };
            Animal animalClonado = animal;
            //Animal animalClonado = animal.Clone() as Animal;
            animalClonado.Patas = 5;
            Console.WriteLine(animal.Patas);
        }
    }
}
