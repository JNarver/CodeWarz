using System.Linq;

public class Kata
{
  public static string DuplicateEncode(string word)
  {  
    return new string(word.ToLower().Select(ch => word.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray());
  }
}