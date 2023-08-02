// https://paiza.jp/works/mondai/graph_dfs_problems/graph_dfs__path_one_step6
using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    static void Main()
    {
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = inputs[0];
        int s = inputs[1];
        int t = inputs[2];
        Console.ReadLine();

        HashSet<int> hashSet = new HashSet<int>(Console.ReadLine().Split().Select(int.Parse));

        List<List<int>> adList = new List<List<int>>();
        for (int i = 0; i <= n; i++)
        {
            adList.Add(new List<int>());
        }

        for (int i = 1; i <= n; i++)
        {
            Console.ReadLine();
            adList[i] = Console.ReadLine().Split().Select(int.Parse).ToList();
        }

        for (int i = 1; i <= n; i++)
        {
            if (hashSet.Contains(i))
            {
                foreach (int j in adList[i].ToList())
                {
                    adList[j].Remove(i);
                }
                adList[i].Clear();
            }
        }

        List<int> minPath = Enumerable.Range(1, n + 1).ToList();
        Dfs(s, new List<int> { s }, adList, t, ref minPath);

        if (minPath.Count == n + 1)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(string.Join(" ", minPath));
        }
    }

    static void Dfs(int v, List<int> path, List<List<int>> adList, int target, ref List<int> minPath)
    {
        if (path.Count < minPath.Count)
        {
            foreach (int i in adList[v])
            {
                if (!path.Contains(i))
                {
                    path.Add(i);
                    if (i == target)
                    {
                        minPath = new List<int>(path);
                    }
                    else
                    {
                        Dfs(i, path, adList, target, ref minPath);
                    }
                    path.RemoveAt(path.Count - 1);
                }
            }
        }
    }
}
