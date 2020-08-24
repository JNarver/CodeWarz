public static int[] ArrayDiff(int[] a, int[] b)
  {
    return a.Where(n => !b.Contains(n)).ToArray();
  }