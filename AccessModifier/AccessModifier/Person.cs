using System;

namespace AccessModifier
{
  //Object should hide its implementation and reveal what it can do rather than how and what suppose to do.
  public class Person
  {
    private DateTime _birthdate;

    public void SetBirthDate(DateTime birthdate)
    {
      _birthdate = birthdate;
    }

    public DateTime GetBirthdate()
    {
      return _birthdate;
    }
  }
}
