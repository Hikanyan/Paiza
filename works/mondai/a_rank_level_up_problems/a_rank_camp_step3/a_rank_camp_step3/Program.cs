using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var line = Console.ReadLine().Split(' ');
        var h = int.Parse(line[0]);
        var w = int.Parse(line[1]);
        var map = new char[h, w];
        var queue = new Queue<int[]>();

        for (int i = 0; i < h; i++)
        {
            var s = Console.ReadLine();
            for (int j = 0; j < w; j++)
            {
                map[i, j] = s[j];
                if (s[j] == '*')
                {
                    queue.Enqueue(new int[] { i, j });
                }
            }
        }

        var dx = new int[] { 0, 1, 0, -1 };
        var dy = new int[] { -1, 0, 1, 0 };

        while (queue.Count > 0)
        {
            var player = queue.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                var x = player[1] + dx[i];
                var y = player[0] + dy[i];
                if (x < 0 || x >= w || y < 0 || y >= h || map[y, x] != '.') continue;

                map[y, x] = '*';
                queue.Enqueue(new int[] { y, x });
            }
        }

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                Console.Write(map[i, j]);
            }
            Console.WriteLine();
        }
    }
}