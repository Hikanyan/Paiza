// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__swap
using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] xy = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int x = xy[0] - 1;
        int y = xy[1] - 1;
        
        int temp = array[x];
        array[x] = array[y];
        array[y] = temp;
        
        //入れ替えをするコードを(array[x], array[y]) = (array[y], array[x]);で表すこともできますがPaizaでは使えません。C# 7.0 以降のバージョンで使用可能。

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
