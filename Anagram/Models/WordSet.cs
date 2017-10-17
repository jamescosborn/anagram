using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class WordSet
  {
    private string _source;
    private string _target;

    public WordSet(string a, string b)
    {
      _source = a;
      _target = b;
    }

    public string GetSource(){return _source;}
    public string GetTarget(){return _target;}

    public bool IsAnagram()
    {
      _source = _source.ToLower();
      _target = _target.ToLower();

      Console.WriteLine(_source + " " + _target);
      Console.WriteLine(_source == _target);
      Console.WriteLine(string.ReferenceEquals(_source, _target));
      if (_source == _target)
      //if (string.ReferenceEquals(_source, _target))
      {
        return false;
      }
      else
      {
        char[] a = _source.ToCharArray();
        char[] b = _target.ToCharArray();
        Array.Sort(a);
        Array.Sort(b);
        Console.WriteLine(a);
        Console.WriteLine(b);
        if (a == b)
        {return true;}
        else
        {return false;}
      }
    }

  }
}
