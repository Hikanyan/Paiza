using System;

class Program
{
    static void Main()
    {
        var line = Console.ReadLine().Split(' ');
        var h = int.Parse(line[0]);
        var w = int.Parse(line[1]);
        var s = new string[h];//盤面
        for (int i = 0; i < h; i++)//盤面の入力
        {
            s[i] = Console.ReadLine();
        }

        var t = new char[h, w];//結果の盤面

        // 入力された盤面をコピー
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                t[i, j] = s[i][j];
            }
        }

        // '*' から隣接する '.' を '*' に変更
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                if (s[i][j] == '*')
                {
                    if (i > 0 && s[i - 1][j] == '.') t[i - 1, j] = '*';
                    if (i < h - 1 && s[i + 1][j] == '.') t[i + 1, j] = '*';
                    if (j > 0 && s[i][j - 1] == '.') t[i, j - 1] = '*';
                    if (j < w - 1 && s[i][j + 1] == '.') t[i, j + 1] = '*';
                }
            }
        }

        // 結果の盤面を出力
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                Console.Write(t[i, j]);
            }
            Console.WriteLine();
        }
    }
}