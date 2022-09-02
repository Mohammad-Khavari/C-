using System.Collections.Generic;

namespace Constructor
{
  public class Customer
  {
    public int Id;
    public string firstName;
    public string lastName;
    public string DateTime;
    public List<Order> Order;

    public Customer()
    {
      Order = new List<Order>();
    }
    public Customer(int id)
      :this()
    {
      this.Id = id;
    }
    public Customer(int id, string name)
      :this(id)
    {
          
      this.firstName = name;
    }
  }
}
