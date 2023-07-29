// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__resize
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arraySizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int arrayLength = arraySizes[0]; // 配列 A の要素数
        int newArraySize = arraySizes[1]; // 新たに作成する配列のサイズ

        int[] arrayA = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            arrayA[i] = int.Parse(Console.ReadLine()); // 配列 A の要素を入力
        }

        int[] newArray;
        if (newArraySize >= arrayLength)
        {
            // 新たに作成する配列のサイズが A の要素数以上の場合、サイズを合わせるため 0 を追加
            newArray = arrayA.Concat(Enumerable.Repeat(0, newArraySize - arrayLength)).ToArray();
        }
        else
        {
            // 新たに作成する配列のサイズが A の要素数よりも小さい場合、A の先頭から n 要素を切り取る
            newArray = arrayA.Take(newArraySize).ToArray();
        }

        // 新たに作成した配列を出力
        foreach (int num in newArray)
        {
            Console.WriteLine(num);
        }
    }
}
