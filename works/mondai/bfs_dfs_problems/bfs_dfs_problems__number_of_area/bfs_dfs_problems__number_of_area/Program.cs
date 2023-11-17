using System;

class Program
{
    static void Main()
    {
        var inputs = Console.ReadLine().Split(' ');

        var h = int.Parse(inputs[0]);
        var w = int.Parse(inputs[1]);

        var map = new char[h, w];
        for (var i = 0; i < h; i++)
        {
            var line = Console.ReadLine();
            for (var j = 0; j < w; j++)
            {
                map[i, j] = line[j];
            }
        }

        var count = 0;

        for (var i = 0; i < h; i++)
        {
            for (var j = 0; j < w; j++)
            {
                if (map[i, j] == '.')
                {
                    Dfs(map, j, i);
                    count++;
                }
            }
        }

        Console.WriteLine(count); // 区画数の出力
    }

    static void Dfs(char[,] map, int x, int y)
    {
        var h = map.GetLength(0);
        var w = map.GetLength(1);

        if (x < 0 || w <= x || y < 0 || h <= y || map[y, x] == '#')
        {
            return;
        }

        map[y, x] = '#';

        Dfs(map, x - 1, y);
        Dfs(map, x + 1, y);
        Dfs(map, x, y - 1);
        Dfs(map, x, y + 1);
    }
}