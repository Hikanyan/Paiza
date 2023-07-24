// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__excange

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        Console.WriteLine($"{array[1]} {array[0]}");
    }
}