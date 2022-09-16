using System.Collections.Generic;

namespace MethodOverriding
{
  partial class Program
  {
    public class Canvas
    {
      public void DrawShape(List<Shape> shapes)
      {
        foreach(var shape in shapes)
        {
          #region
          //switch (shape.Type)
          //{
          //  case ShapeType.Circle:
          //    Console.WriteLine("Draw a circle.");
          //    break;
          //  case ShapeType.Rectangle:
          //    Console.WriteLine("Draw a rectangle.");
          //    break;
          //}
          #endregion
          shape.Draw();
        }
      }
    }
  }
}
