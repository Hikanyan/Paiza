using System;

class Program
{
    static void Main()
    {
        // 盤面の行数と列数を読み込む
        string[] dimensions = Console.ReadLine().Split();
        int h = int.Parse(dimensions[0]);
        int w = int.Parse(dimensions[1]);

        // 盤面を文字の2次元配列として読み込む
        char[][] board = new char[h][];
        for (int i = 0; i < h; i++)
        {
            board[i] = Console.ReadLine().ToCharArray();
        }

        // 条件を満たすマスの座標を出力
        for (int y = 0; y < h; y++)
        {
            for (int x = 0; x < w; x++)
            {
                // 左端のマスの場合は右のマスが "#" かどうかを確認
                // 右端のマスの場合は左のマスが "#" かどうかを確認
                if ((x == 0 && board[y][x + 1] == '#') ||
                    (x == w - 1 && board[y][x - 1] == '#'))
                {
                    Console.WriteLine($"{y} {x}");
                }
                // それ以外のマスは左右のマスが "#" かどうかを確認
                else if ((x - 1 >= 0 && board[y][x - 1] == '#') &&
                         (x + 1 < w && board[y][x + 1] == '#'))
                {
                    Console.WriteLine($"{y} {x}");
                }
            }
        }
    }
}