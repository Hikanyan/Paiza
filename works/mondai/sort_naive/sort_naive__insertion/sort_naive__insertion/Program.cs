using System;
using System.Collections.Generic;

public class InsertSort
{
    static void Main(string[] args)
    {
        Console.ReadLine(); // 最初の行は不要なので読み飛ばす
        var array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        List<string> ans = new List<string>();

        insertSort(array, ans);

        Console.WriteLine(string.Join("\n", ans)); // 各ステップの結果を改行で区切って出力
    }

    // 挿入ソート
    private static void insertSort(int[] array, List<string> ans) 
    {
        // ここに、挿入ソートを実装して、途中経過を ans に追加する
        for (int i = 0; i < array.Length; i++)
        {
            int temp = array[i]; //配列のi番目の値をtempに代入
            int j = i - 1; //配列のi番目の値の一つ前の値をjに代入
            while (j >= 0 && array[j] > temp)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = temp;

            // 挿入ソートの各ステップごとの途中結果を文字列としてansに追加
            //最初のArrayは出力しない
            if (i == 0) continue;
            ans.Add(string.Join(" ", array));
        }
    }
}