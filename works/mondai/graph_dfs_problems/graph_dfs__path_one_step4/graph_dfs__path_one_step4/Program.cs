// https://paiza.jp/works/mondai/graph_dfs_problems/graph_dfs__path_one_step4
using System;
using System.Collections.Generic;

class Program
{
    static int n, s, t;
    static Dictionary<int, List<int>> adList;
    static List<int> minPath;

    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        n = input[0];
        s = input[1];
        t = input[2];

        adList = new Dictionary<int, List<int>>();
        for (int i = 1; i <= n; i++)
        {
            Console.ReadLine();
            adList[i] = new List<int>();
            int[] adInput = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            foreach (int ad in adInput)
            {
                adList[i].Add(ad);
            }
        }

        minPath = new List<int>();
        for (int i = 0; i < n + 1; i++)
        {
            minPath.Add(i + 1);
        }

        DFS(s, new List<int> { s });

        Console.WriteLine(string.Join(" ", minPath));
    }

    static void DFS(int v, List<int> path)
    {
        if (path.Count < minPath.Count)
        {
            foreach (int i in adList[v])
            {
                if (!path.Contains(i))
                {
                    path.Add(i);
                    if (i == t)
                    {
                        minPath = new List<int>(path);
                    }
                    else
                    {
                        DFS(i, path);
                    }
                    path.RemoveAt(path.Count - 1);
                }
            }
        }
    }
}

