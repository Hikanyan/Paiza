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
                if (IsSurroundedByHashes(board, y, x, h, w))
                {
                    Console.WriteLine($"{y} {x}"); // 条件を満たすマスの座標を出力
                }
            }
        }
    }

    // 上下左右のマスが全て '#' であるかをチェックするメソッド
    static bool IsSurroundedByHashes(char[][] board, int y, int x, int h, int w)
    {
        // 上端のマスの場合
        if (y == 0)
        {
            // 左上のマス
            if (x == 0)
            {
                return board[y + 1][x] == '#' && board[y][x + 1] == '#';
            }
            // 右上のマス
            else if (x == w - 1)
            {
                return board[y + 1][x] == '#' && board[y][x - 1] == '#';
            }
            // 上端の一般のマス
            else
            {
                return board[y + 1][x] == '#' && board[y][x - 1] == '#' && board[y][x + 1] == '#';
            }
        }
        // 下端のマスの場合
        else if (y == h - 1)
        {
            // 左下のマス
            if (x == 0)
            {
                return board[y - 1][x] == '#' && board[y][x + 1] == '#';
            }
            // 右下のマス
            else if (x == w - 1)
            {
                return board[y - 1][x] == '#' && board[y][x - 1] == '#';
            }
            // 下端の一般のマス
            else
            {
                return board[y - 1][x] == '#' && board[y][x - 1] == '#' && board[y][x + 1] == '#';
            }
        }
        // 一般のマスの場合
        else
        {
            // 左端の一般のマス
            if (x == 0)
            {
                return board[y - 1][x] == '#' && board[y + 1][x] == '#' && board[y][x + 1] == '#';
            }
            // 右端の一般のマス
            else if (x == w - 1)
            {
                return board[y - 1][x] == '#' && board[y + 1][x] == '#' && board[y][x - 1] == '#';
            }
            // 一般のマス
            else
            {
                return board[y - 1][x] == '#' && board[y + 1][x] == '#' && board[y][x - 1] == '#' &&
                       board[y][x + 1] == '#';
            }
        }
    }
}