using System;

class Program
{
    static void Main()
    {
        // 盤面の行数、列数、座標の数を読み込む
        string[] dimensions = Console.ReadLine().Split();
        int h = int.Parse(dimensions[0]);
        int w = int.Parse(dimensions[1]);//使われない
        int n = int.Parse(dimensions[2]);

        // 盤面を文字列の配列として読み込む
        string[] board = new string[h];
        for (int i = 0; i < h; i++)
        {
            board[i] = Console.ReadLine();
        }

        // 座標の数だけループ
        for (int i = 0; i < n; i++)
        {
            // 座標を読み込む
            string[] coordinates = Console.ReadLine().Split();
            int y = int.Parse(coordinates[0]);
            int x = int.Parse(coordinates[1]);

            // 盤面の指定された座標を "#" に書き換える
            board[y] = board[y].Remove(x, 1).Insert(x, "#");
        }

        // 書き換えた後の盤面を出力
        foreach (string row in board)
        {
            Console.WriteLine(row);
        }
    }
}