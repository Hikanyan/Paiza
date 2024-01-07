using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var n = int.Parse(input[0]);
        var m = int.Parse(input[1]);
        var g = new int[n, n];
        var h = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            h[i] = new List<int>();
        }

        for (int i = 0; i < m; i++)
        {
            var line = Console.ReadLine().Split(' ');
            var a = int.Parse(line[0]) - 1;
            var b = int.Parse(line[1]) - 1;
            g[a, b] = 1;
            h[a].Add(b + 1);
        }

        // 隣接行列の出力
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(g[i, j]);
            }
            Console.WriteLine();
        }

        // 隣接リストの出力
        for (int i = 0; i < n; i++)
        {
            h[i].Sort(); // 隣接リストをソート
            Console.WriteLine(string.Join("", h[i]));
        }
    }
}