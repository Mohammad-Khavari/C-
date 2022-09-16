using System;


namespace AccessModifier
{
  public class Program
  {
    static void Main(string[] args)
    {
      var person = new Person();
      person.SetBirthDate(new DateTime(1995,01,01));

      Console.WriteLine(person.GetBirthdate());

     

    }
  }
}
