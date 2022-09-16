namespace AbstractClass
{
  public class Shape
  {
    public int With { get; set; }
    public int Height { get; set; }

    public virtual void Draw()
    {

    }

    //public abstract void Draw();

    public void Copy()
    {
      System.Console.WriteLine("Copy shape to clipboard");
    }

    public void Pase()
    {
      System.Console.WriteLine("Paste shape from clipboard");
    }
  }
}
