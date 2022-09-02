using System;

namespace Method
{
  partial class Program
  {
    static void Main(string[] args)
    {
      
      
    }
    #region Using params
    static void UseParams()
    {
      // Here is the usage of "params" keyword.
      var calculator = new Calculator();
      Console.WriteLine(calculator.Add(1, 2));
      Console.WriteLine(calculator.Add(1, 2, 6));
      Console.WriteLine(calculator.Add(1, 2, 3, 8));

      //This is old way of using array notation 
      Console.WriteLine(calculator.Add(new int[] { 2, 3, 5, 8, 6 }));
    }
    #endregion
    #region Point
    static void UsePoint()
    {
      try
      {
        var point = new Point(10, 30);

        point.Move(null);
        Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

        point.Move(new Point(60, 30));
        Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

        point.Move(new Point(100, 200));
        Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);
      }
      catch (Exception)
      {

        Console.WriteLine("You entered a Null or invalid value!");
      }
    }

    #endregion
  }
}
