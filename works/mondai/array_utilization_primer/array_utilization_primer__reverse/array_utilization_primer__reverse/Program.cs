// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__reverse
using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int[] b = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
            b[n - i - 1] = a[i];
        }
        Console.WriteLine(string.Join("\n", b));
    }
}