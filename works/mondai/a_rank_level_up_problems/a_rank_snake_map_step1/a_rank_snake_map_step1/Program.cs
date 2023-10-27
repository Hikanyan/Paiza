using System;
class Program
{
    /// <summary>
    /// アイスチェーン
    /// </summary>
    static void Main()
    {
        // 盤面の行数、列数、座標の数を読み込む
        string[] dimensions = Console.ReadLine().Split();
        int h = int.Parse(dimensions[0]);
        int w = int.Parse(dimensions[1]);
        int n = int.Parse(dimensions[2]);
        
        
        // 盤面を2次元配列として読み込む
        char[][] board = new char[h][];
        for (int i = 0; i < h; i++)
        {
            board[i] = Console.ReadLine().ToCharArray();
        }
        

        // 座標の数だけループ
        for (int i = 0; i < n; i++)
        {
            // 座標を読み込む
            string[] coordinates = Console.ReadLine().Split();
            int y = int.Parse(coordinates[0]);
            int x = int.Parse(coordinates[1]);

            // 盤面の文字を出力
            Console.WriteLine(board[y][x]);
        }
    }
}