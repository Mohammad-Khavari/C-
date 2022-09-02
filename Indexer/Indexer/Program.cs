using System;

namespace Indexer
{
  class Program
  {
    static void Main(string[] args)
    {
      var cookie = new HttpCookie();

      // "name" is key.
      cookie["name"] = "Hash Mahdi";
      Console.WriteLine(cookie["name"]);
    }
  }
}
