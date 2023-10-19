using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n, x, y;
        Queue<int> Q = new Queue<int>();

        // 入力を読み込み
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        n = input[0];
        x = input[1] - 1; // インデックスを0ベースに調整
        y = input[2] - 1; // インデックスを0ベースに調整

        List<List<int>> graph = new List<List<int>>(n);
        for (int i = 0; i < n; i++)
        {
            graph.Add(new List<int>());
        }

        List<int> len = Enumerable.Repeat(-1, n).ToList();
        List<int> prev = Enumerable.Repeat(-1, n).ToList();
        List<int> ans = new List<int>();

        // グラフの構築
        for (int i = 0; i < n - 1; i++)
        {
            input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = input[0] - 1; // インデックスを0ベースに調整
            int b = input[1] - 1; // インデックスを0ベースに調整
            graph[a].Add(b);
            graph[b].Add(a);
        }

        Q.Enqueue(x);
        len[x] = 0;

        // 幅優先探索（BFS）
        while (Q.Count > 0)
        {
            int now = Q.Dequeue();

            if (now == y)
            {
                break; // yに到達したら探索を終了
            }

            foreach (int next in graph[now])
            {
                if (len[next] == -1)
                {
                    len[next] = len[now] + 1;
                    prev[next] = now;
                    Q.Enqueue(next);
                }
            }
        }

        int tmp = y;

        // 結果の出力
        while (tmp != -1)
        {
            ans.Add(tmp);
            tmp = prev[tmp];
        }

        ans.Reverse();

        foreach (int item in ans)
        {
            Console.WriteLine(item + 1); // インデックスを1ベースに戻して出力
        }
    }
}