// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__sum
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int line = int.Parse(Console.ReadLine());
        int sum = 0;
        for(int i = 0; i < line; i++)
        {
            int n = int.Parse(Console.ReadLine());
            sum += n;
        }
        Console.WriteLine(sum);
    }
}