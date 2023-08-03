// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__exam
using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] m = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[][] scores = new int[n][];
        int max = 0;
        
        for (int i = 0; i < n; i++)
        {
            scores[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        }
    }
}