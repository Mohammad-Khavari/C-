using System.Collections.Generic;

namespace Indexer
{
  public class HttpCookie
  {
    private readonly Dictionary<string, string> _dictionary;

    public HttpCookie()
    {
      _dictionary = new Dictionary<string, string>();
    }

    //This is the indexer 
    //Without indexer in this example we must write to method Getter and Setter.
    public string this[string Key]
    {
      get { return _dictionary[Key]; }
      set { _dictionary[Key] = value; }
    }
  }
}
