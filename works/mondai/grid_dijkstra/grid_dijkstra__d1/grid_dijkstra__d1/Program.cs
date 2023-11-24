using System;
using System.Collections.Generic;

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
        var start = new int[] { 0, 0 };
        var goal = new int[] { h - 1, w - 1 };
        var result = Bfs(t, start, goal);
        Console.WriteLine(result);
    }

    private static int Bfs(int[,] t, int[] start, IReadOnlyList<int> goal)
    {
        var h = t.GetLength(0);
        var w = t.GetLength(1);
        var d = new int[h, w];
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                d[i, j] = int.MaxValue;
            }
        }
        var q = new Queue<int[]>();
        q.Enqueue(start);
        d[start[0], start[1]] = 1;

        while (q.Count > 0)
        {
            var p = q.Dequeue();
            var x = p[0];
            var y = p[1];
            var v = d[x, y];
            if (x == goal[0] && y == goal[1])
            {
                return v;
            }
            var dx = new int[] { 1, 0, -1, 0 };
            var dy = new int[] { 0, 1, 0, -1 };

            for (int i = 0; i < 4; i++)
            {
                var nx = x + dx[i];
                var ny = y + dy[i];
                if (nx >= 0 && nx < h && ny >= 0 && ny < w && t[nx, ny] == 0 && d[nx, ny] == int.MaxValue)
                {
                    d[nx, ny] = v + 1;
                    q.Enqueue(new int[] { nx, ny });
                }
            }
        }
        return -1;
    }
}