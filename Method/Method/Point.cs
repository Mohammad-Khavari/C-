using System;

namespace Method
{
  public class Point
  {
    public int X;
    public int Y;

    //This is constructor
    public Point(int x, int y)
    {
      this.Y = y;
      this.X = x;
    }

    //This is move method
    public void Move(int x, int y) {
      this.X = x;
      this.Y = y;
    }

    //public void Move(Point newLocation)
    //{
    //  this.X = newLocation.X;
    //  this.Y = newLocation.Y;
    //}


    /// <summary>
    /// This overloading method has problem with passing null as reference
    /// </summary>
    /// <param name="newLocation"></param>
    public void Move(Point newLocation)
    {
      if (newLocation == null)
        throw new ArgumentNullException("newLocation");
      Move(newLocation.X,newLocation.Y);
    }
  }
}
