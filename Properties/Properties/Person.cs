using System;

namespace Properties
{
  public class Person
  {
    //private DateTime _birthdate;

    #region this is another way of doing getter and setter
    //public DateTime Birthdate
    //{

    //  //They are code block.
    //  get { return _birthdate; }
    //  // Value keyword set the value to the private field.
    //  set { _birthdate = value; }
    //}
    #endregion
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime Birthdate { get; private set; }

    public Person(DateTime birthdate)
    {
      Birthdate = birthdate;
    }
    #region Auto implemented property
    //public DateTime Birthdate { get; set; }
    //Property
    public int Age
    {
      get
      {
        var timeSpan = DateTime.Today - Birthdate;
        var years = timeSpan.Days / 365;
        
        return years;
      }
    }

    #endregion
  }
  
}
