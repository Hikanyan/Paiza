//https://paiza.jp/works/mondai/sort_naive/sort_naive__bubble
using System;
using System.Collections.Generic;

public class BubbleSort
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // 要素数を読み込む
        var array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        List<string> ans = new List<string>();

        BubbleSortArray(array, ans);

        Console.WriteLine(string.Join("\n", ans)); // 各ステップの結果を改行で区切って出力
    }

    // バブルソート
    //BubbleSortArrayは、配列の要素を小さい順に並べ替えるバブルソートを行うメソッドです。
    private static void BubbleSortArray(int[] array, List<string> ans)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = array.Length - 1; j > i; j--) // 末尾から順に比較
            {
                if (array[j - 1] > array[j])
                {
                    // 隣接する要素の大小を比較して順序を入れ替える
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                }
            }

            // バブルソートの各ステップごとの途中結果を文字列としてansに追加
            ans.Add(string.Join(" ", array));
        }
    }
}