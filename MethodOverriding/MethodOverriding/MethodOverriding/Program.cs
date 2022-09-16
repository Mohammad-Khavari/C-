using System;
using System.Collections.Generic;

namespace MethodOverriding
{
  partial class Program
  {
    static void Main(string[] args)
    {
      List<Shape> shapes = new List<Shape>();
      shapes.Add(new Shape { Width = 100, Height = 100, Type = ShapeType.Circle });
      shapes.Add(new Shape { Width = 299, Height = 10, Type = ShapeType.Circle });

      //shapes.Add(new Circle());
      //shapes.Add(new Rectangle());

      Canvas canvas = new Canvas();
      canvas.DrawShape(shapes);
    }
  }
}
