using System;

namespace Fields
{
  class Program
  {
    static void Main(string[] args)
    {
      var customer = new Customer(1);

      customer.Orders.Add(new Order());
      customer.Orders.Add(new Order());
      customer.Orders.Add(new Order());
      customer.Orders.Add(new Order());


      customer.Promot();
      Console.WriteLine(customer.Orders.Count);

    }
  }
}
