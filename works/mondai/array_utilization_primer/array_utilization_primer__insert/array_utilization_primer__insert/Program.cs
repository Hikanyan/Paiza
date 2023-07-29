// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__insert

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> array = new List<int>();
        //arrayに値を追加
        for (int i = 0; i < n; i++)
        {
            array.Add(int.Parse(Console.ReadLine()));
        }

        //追加したい値を配列bに格納
        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        //arrayのb[0]番目の要素の後ろにb[1]を追加
        array.Insert(b[0], b[1]);
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
    }
}