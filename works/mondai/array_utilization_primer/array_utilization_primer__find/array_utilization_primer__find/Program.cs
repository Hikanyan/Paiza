// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__find

using System;

class Program
{
    static void Main()
    {
        int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int count = -1;
        for (int i = 0; i < n[0]; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if (a == n[1])
            {
                count = i + 1;
                break;
            }
        }
        Console.WriteLine(count);
    }
}