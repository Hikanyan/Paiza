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
                if (IsSurroundedByHashes(board, y, x, h))
                {
                    Console.WriteLine($"{y} {x}");
                }
            }
        }
    }

    // 上下のマスがどちらも '#' であるかをチェック
    static bool IsSurroundedByHashes(char[][] board, int y, int x, int h)
    {
        if (y == 0 && y + 1 < h && board[y + 1][x] == '#')
        {
            return true; // 上端のマスで下のマスが '#' の場合
        }
        else if (y == h - 1 && y - 1 >= 0 && board[y - 1][x] == '#')
        {
            return true; // 下端のマスで上のマスが '#' の場合
        }
        else if (y > 0 && y < h - 1 && board[y - 1][x] == '#' && board[y + 1][x] == '#')
        {
            return true; // 一般の場合で上下のマスが '#' の場合
        }

        return false; // どの条件にも合致しない場合
    }
}