using System;

namespace ConstructorAndInheritance
{
  public class Car : Vehicle
  {
    // Here because we do not have parameterless constructor in Vehicle Class we should use the base keyword to use the Car Class constructor with param.
    public Car(string regNumber)
      :base(regNumber)
    {
      Console.WriteLine("Car Class called Registration number is: {0}.", regNumber);
    }
  }
}
