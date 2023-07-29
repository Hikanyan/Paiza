// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__reduse_easy
using System;
class Program
{
    static void Main()
    {
        
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.Write($"{i * j}{(j == 9 ? "" : " ")}");
            }
            Console.WriteLine();
        }
    }
}