//https://paiza.jp/works/mondai/sort_naive/sort_naive__selection
using System;
using System.Collections.Generic;

public class SelectionSort
{
    static void Main(string[] args)
    {
        Console.ReadLine(); // 最初の行は不要なので読み飛ばす
        var array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        List<string> ans = new List<string>();

        SelectionSortArray(array, ans);

        Console.WriteLine(string.Join("\n", ans)); // 各ステップの結果を改行で区切って出力
    }

    // 選択ソート
    private static void SelectionSortArray(int[] array, List<string> ans)
    {
        //array.Length - 1 は最後の要素のインデックス
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = Int32.MaxValue; // 最小値のインデックスを保持
            //i + 1 は最初の要素のインデックス
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            // 最小値を先頭に移動(Paizaではできない)
            //(array[i], array[minIndex]) = (array[minIndex], array[i]);

            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;

            // 選択ソートの各ステップごとの途中結果を文字列としてansに追加
            ans.Add(string.Join(" ", array));
        }
    }
}