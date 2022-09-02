using System;

namespace Constructor
{
  class Program
  {
    static void Main(string[] args)
    {
      var customer = new Customer(20,"Mohammad");
      Console.WriteLine(customer.Id);
      Console.WriteLine(customer.firstName);



      // New way of object initialization
      var person = new Person
      {
        firstName = "Mohammad",
        lastName = "Khavari"

      };


    }
  }
}
