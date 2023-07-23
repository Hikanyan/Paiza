// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__min
using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int min = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
            if (min > a[i])
            {
                min = a[i];
            }
        }
        Console.WriteLine(min);
    }
}