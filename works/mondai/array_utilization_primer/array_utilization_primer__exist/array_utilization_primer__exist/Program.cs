// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__exist
using System;
class Program
{
    static void Main()
    {
        int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        bool ans = false;
        for(int i = 0; i < n[0]; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if(a == n[1])
            {
                ans = true;
                break;
            }
        }
        Console.WriteLine(ans ? "Yes" : "No");
    }
}