using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
 
  //Old way of initializing an object.
  public class Person
  {
    public int Id;
    public string firstName;
    public string lastName;
    public string DateTime;
    public Person() { }
    public Person(int id) { }
    public Person (int id, string firstName) { }
    public Person (int id, string firstName, string lastName) { }
    public Person(int id, DateTime birthDay) { }

   
  }


}
