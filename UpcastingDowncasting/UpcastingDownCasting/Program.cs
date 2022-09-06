using System;

namespace UpcastingDownCasting
{
  class Program
  {
    static void Main(string[] args)
    {
      ////Up-casting
      //Cat cat = new Cat();
      ////Here the Animal class converted to the base class.
      ////cat and animal object both pointing to the same object in memory. references to same object in memory.
      ////object created from base class has limited options.
      //Animal animal = cat;

      //cat.Age = 10;
      //animal.Age = 5;
      //Console.WriteLine(cat.Age);


      //Down Casting
      //Here there are no options Color and Nationality in animal.
      Animal animal = new Cat();

      //Down casting is needed to access all options from Cat class.
      Cat cat = (Cat)animal;




    }
  }
}
