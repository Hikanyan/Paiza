// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__delete

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // 要素数n
        int[] a = new int[n]; // 配列a
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine()); // 配列aの要素を入力
        }

        int b = int.Parse(Console.ReadLine()) - 1; // 削除する要素の番号

        // 配列aから指定された要素を削除
        for (int i = b; i < n - 1; i++)
        {
            a[i] = a[i + 1];
        }

        // 要素数n-1の配列aの各要素を出力
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}