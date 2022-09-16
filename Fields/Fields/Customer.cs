using System.Collections.Generic;

namespace Fields
{
  public class Customer
  {
    //public_Private_protected_inrernal_Protected Internal -1 ( Access modify )
    
    // public string hashMamad { get; set }`   -2 Class member ( properti ) 
    // Static 
    //  Public only
    // public List<HashMamd> ourList = new List<HashMamd>;




    public int Id;
    public string Name;
    public readonly List<Order> Orders;


    //public readonly List<Order> Orders = new List<Order>();

    public Customer()
    {
      Orders = new List<Order>();
    }

    public Customer(int id)
    {
      this.Id = id;
    }
    public Customer(int id, string name)
       :this(id)
    {
      this.Name = name;
    }

    public void Promot()
    {
      //Orders = new List<Order>();
      //...
    }

  }

  public class Order
  {

  }
}
