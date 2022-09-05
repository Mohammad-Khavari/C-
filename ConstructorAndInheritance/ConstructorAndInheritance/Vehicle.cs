using System;

namespace ConstructorAndInheritance
{
  public class Vehicle
  {
    private readonly string _registrationNumber;
    // if Parameterless constructor does not exist in vehicle class then it cause error in car class. See Car class.
    //public Vehicle()
    //{
    //  Console.WriteLine("Vehicle Class called.");
    //}

    public Vehicle(string registrationNumber)
    {
      _registrationNumber = registrationNumber;

      Console.WriteLine("Vehicle Class is called, Registration number is: {0}", registrationNumber);
    }
  }
}
