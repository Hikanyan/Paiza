using System;

class Program
{
    static void Main()
    {
        var inputs = Console.ReadLine().Split(' ');
        var h = int.Parse(inputs[0]);
        var w = int.Parse(inputs[1]);
        var y = int.Parse(inputs[2]);
        var x = int.Parse(inputs[3]);

        Dfs(0, y, x, h, w);
    }

    static void Dfs(int times, int y, int x, int h, int w)
    {
        if (times == 3)
        {
            Console.WriteLine($"{y} {x}");
        }
        else
        {
            if (y - 1 >= 0) // 上に移動
            {
                Dfs(times + 1, y - 1, x, h, w);
            }

            if (x + 1 < w) // 右に移動
            {
                Dfs(times + 1, y, x + 1, h, w);
            }

            if (y + 1 < h) // 下に移動
            {
                Dfs(times + 1, y + 1, x, h, w);
            }

            if (x - 1 >= 0) // 左に移動
            {
                Dfs(times + 1, y, x - 1, h, w);
            }
        }
    }
}