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
        var distance = new int[h, w];
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
                    distance[i, j] = 0; // プレイヤーの初期位置
                }
                else
                {
                    distance[i, j] = -1; // 未到達を表す
                }
            }
        }

        BreadthFirstSearch(h, w, map, distance, queue);

        // 結果の出力
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                if (map[i, j] == '#')
                    Console.Write('#');
                else
                    Console.Write(distance[i, j]);
            }
            Console.WriteLine();
        }
    }

    // 幅優先探索の関数化
    static void BreadthFirstSearch(int h, int w, char[,] map, int[,] distance, Queue<int[]> queue)
    {
        var dx = new int[] { 0, 1, 0, -1 };
        var dy = new int[] { -1, 0, 1, 0 };

        while (queue.Count > 0)
        {
            var point = queue.Dequeue();
            var x = point[1];
            var y = point[0];

            for (int i = 0; i < 4; i++)
            {
                var nx = x + dx[i];
                var ny = y + dy[i];
                if (nx >= 0 && nx < w && ny >= 0 && ny < h && map[ny, nx] != '#' && distance[ny, nx] == -1)
                {
                    distance[ny, nx] = distance[y, x] + 1;
                    queue.Enqueue(new int[] { ny, nx });
                }
            }
        }
    }
}