using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var h = int.Parse(input[0]);
        var w = int.Parse(input[1]);
        var t = new int[h, w];
        for (int i = 0; i < h; i++)
        {
            var input2 = Console.ReadLine().Split(' ');
            for (int j = 0; j < w; j++)
            {
                t[i, j] = int.Parse(input2[j]);
            }
        }

        var sum = 0;
        var x = 0;
        var y = 0;

        // スタート地点のコストを加算
        sum += t[y, x];

        // 「右」に移動
        if (x < w - 1)
        {
            x++;
            sum += t[y, x];
        }

        // 「下」に移動
        if (y < h - 1)
        {
            y++;
            sum += t[y, x];
        }

        // 「右」に移動
        if (x < w - 1)
        {
            x++;
            sum += t[y, x];
        }

        // 「上」に移動
        if (y > 0)
        {
            y--;
            sum += t[y, x];
        }

        // 「左」に移動
        if (x > 0)
        {
            x--;
            sum += t[y, x];
        }

        Console.WriteLine(sum);
    }
}