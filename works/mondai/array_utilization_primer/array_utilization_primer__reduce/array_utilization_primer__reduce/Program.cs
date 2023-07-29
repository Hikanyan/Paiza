// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__reduce

using System;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        //二重ループで全ての組み合わせを出力
        for(int i = 1; i < n; i++)
        {
            for(int j = 0; j < i ; j++)
            {
                int result = a[i] * a[j];
                Console.WriteLine(result);
            }
        }
    }
}