// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__filter
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        
        for(int i = 0; i < n[0]; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if (n[1] <= a)
            {
                Console.WriteLine(a);
            }
        }
    }
}