// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__unique

using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        List<int> b = new List<int>();
        foreach (var num in a)
        {
            if(!b.Contains(num))
            {
                b.Add(num);
            }
        }
        Console.WriteLine(string.Join("\n", b));
    }
}