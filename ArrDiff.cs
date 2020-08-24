public static int[] ArrayDiff(int[] a, int[] b)
  {
    var a1 = a.ToArray();
    var b1 = b.Distinct().ToArray();
    
    int max = Math.Max(a1.Length,b1.Length);
    
    List<int> a2 = new List<int>();
    foreach(var el in a1)
    {
        a2.Add(el);
    }
    
    for(int i = 0; i<a1.Length; i++)
      {
      for(int j = 0; j<b1.Length; j++)
        {
        if(a1[i] == b1[j]) a2.Remove(a1[i]);
      }
    }
    return a2.ToArray();
  }