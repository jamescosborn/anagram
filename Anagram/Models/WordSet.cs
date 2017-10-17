using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram.Models
{
  public class WordSet
  {
    private string _source;
    private string _target;
    private List<string> _targetList = new List<string>{};

    public WordSet(string a, string b)
    {
      _source = a;
      _target = b;
    }
    public WordSet(string a , string[] b)
    {
      _source = a;
      _target = b[0];
      foreach (string newStr in b)
      { _targetList.Add(newStr); }
    }

    public string GetSource(){return _source;}
    public string GetTarget(){return _target;}
    public List<string> GetTargetList(){return _targetList;}
/*
    public bool IsAnagram()
    {
      _source = _source.ToLower();
      _target = _target.ToLower();

      if (_source == _target) //if str1 contains str2 and length is equal they are the same and should throw a false bool
      {Console.WriteLine("These are the same!");return false;}

      if (_source!=_target && _source.Length == _target.Length)
      {
        char[] a = _source.ToCharArray();
        char[] b = _target.ToCharArray();
        Array.Sort(a);
        Array.Sort(b);
        string c = new string(a);
        string d = new string(b);
        if (c.Contains(d))
        {Console.WriteLine("These are anagrams!");return true;}
      }
      if ((_source != _target) && (_source.Length > _target.Length))
      {
        char[] a = _source.ToCharArray();
        char[] b = _target.ToCharArray();
        Array.Sort(a);
        Array.Sort(b);
        string c = new string(a);
        string d = new string(b);
        Console.WriteLine("a: "+c+" b: "+d+" in if");
        if (c.Contains(d))
        // abeltt !contain abt, abeltt contains ab
        {
          Console.WriteLine("These are partial anagrams!");return true;
        }
      }
      Console.WriteLine("These are not anagrams!");return false;
    }
*/
    public bool PartialAnagram()
    {
      string src = _source.ToLower();
      string tgt = _target.ToLower();
      Console.WriteLine("These are the args : "+src+" "+tgt);
      bool result = false;
      if (tgt == src) {Console.WriteLine("These are not anagrams!");return false;}
      if (tgt.Length <= src.Length && tgt != src)
      {
        for(int i = 0; (i <= tgt.Length-1); i++)
        {
          if (src.Contains(tgt[i]))
          {
            result = true;
            continue;
          }
          if(!src.Contains(tgt[i])){result = false;}
          break;
        }
      }
      if (result == true && tgt.Length < src.Length) {Console.WriteLine("These are partial anagrams!");return true;}
      if (result == true && tgt.Length == src.Length) {Console.WriteLine("These are anagrams!");return true;}
      Console.WriteLine("These are not anagrams!");return false;
    }
  }
}
