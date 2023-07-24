// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__kind
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //この変数は異なる値を格納するためのコレクションです。
        HashSet<int> uniqueValues = new HashSet<int>();
        for(int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            uniqueValues.Add(a);
        }
        Console.WriteLine(uniqueValues.Count);
    }
}