using System;

namespace MethodOverriding
{
  // Poly in Greek means many
  // morph in Greek means form
  public class Circle: Shape
  {
    public override void Draw()
    {
      #region
      //base is reference to the parent class.
      //any code specific to the circle itself.
      //base.Draw();
      #endregion
      Console.WriteLine("Draw a circle.");
    }
  }

  public class Rectangle: Shape
  {
    public override void Draw()
    {
      Console.WriteLine("Draw a rectangle.");
    }
  }


  public class Shape
  {
    public int Width { get; set; }
    public int Height { get; set; }

    // Enumeration type
    public ShapeType Type { get; set; }

    public virtual void Draw()
    {

    }
  }
}
