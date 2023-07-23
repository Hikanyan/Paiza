// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__max

using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int max = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
            if (max < a[i])
            {
                max = a[i];
            }
        }
        Console.WriteLine(max);
    }
}