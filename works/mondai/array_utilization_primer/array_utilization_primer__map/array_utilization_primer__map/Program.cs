// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__map

using System;

class Program
{
    static void Main()
    {
        int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        for (int i = 0; i < n[0]; i++)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a + n[1]);
        }
    }
}