using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var line = Console.ReadLine().Split(' ');
        var h = int.Parse(line[0]);
        var w = int.Parse(line[1]);
        var n = int.Parse(line[2]);
        var map = new char[h, w];
        var distance = new int[h, w];
        var queue = new Queue<int[]>();

        // 盤面の初期化
        for (int i = 0; i < h; i++)
        {
            var s = Console.ReadLine();
            for (int j = 0; j < w; j++)
            {
                map[i, j] = s[j];
                if (s[j] == '*')//爆弾の位置をキューに追加
                {
                    queue.Enqueue(new int[] { i, j });
                    distance[i, j] = 0;
                }
                else//爆弾以外の位置を-1で初期化
                {
                    distance[i, j] = -1;
                }
            }
        }

        // 距離リストの初期化
        var l = new HashSet<int>();//重複を許さないリスト
        for (int i = 0; i < n; i++)
        {
            l.Add(int.Parse(Console.ReadLine()));
        }

        // 幅優先探索で距離を計算
        var dx = new int[] { 0, 1, 0, -1 };
        var dy = new int[] { -1, 0, 1, 0 };
        while (queue.Count > 0)//キューが空になるまで繰り返す
        {
            var point = queue.Dequeue();
            var x = point[1];
            var y = point[0];

            for (int i = 0; i < 4; i++)//上下左右の4方向を調べる
            {
                var nx = x + dx[i];
                var ny = y + dy[i];
                if (nx >= 0 && nx < w && ny >= 0 &&
                    ny < h && map[ny, nx] != '#' && distance[ny, nx] == -1)
                {
                    distance[ny, nx] = distance[y, x] + 1;
                    queue.Enqueue(new int[] { ny, nx });
                    if (l.Contains(distance[ny, nx]))
                    {
                        map[ny, nx] = '?';
                    }
                    else
                    {
                        map[ny, nx] = '*';
                    }
                }
            }
        }

        // 結果の出力
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
