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
        Console.ReadLine();//いらない

        //hashSetには、削除する頂点の番号が入る
        HashSet<int> hashSet = new HashSet<int>(Console.ReadLine().Split().Select(int.Parse));
        //adListには、隣接リストが入る
        List<List<int>> adList = new List<List<int>>();
        //隣接リストの初期化
        for (int i = 0; i <= n; i++)
        {
            adList.Add(new List<int>());
        }

        //隣接リストを作成
        for (int i = 1; i <= n; i++)
        {
            Console.ReadLine();
            adList[i] = Console.ReadLine().Split().Select(int.Parse).ToList();
        }
        //削除する頂点を隣接リストから削除
        for (int i = 1; i <= n; i++)
        {
            if (hashSet.Contains(i))//削除する頂点の場合
            {
                foreach (int j in adList[i].ToList())//隣接リストから削除
                {
                    adList[j].Remove(i);
                }
                adList[i].Clear();
            }
        }

        //最短経路を探索
        List<int> minPath = Enumerable.Range(1, n + 1).ToList();
        Dfs(s, new List<int> { s }, adList, t, ref minPath);

        //結果を出力
        if (minPath.Count == n + 1)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(string.Join(" ", minPath));
        }
    }

    //深さ優先探索
    static void Dfs(int v, List<int> path, List<List<int>> adList, int target, ref List<int> minPath)
    {
        //終了条件
        if (path.Count < minPath.Count)
        {
            //隣接リストを探索
            foreach (int i in adList[v])
            {
                //探索済みでない場合
                if (!path.Contains(i))
                {
                    //探索済みにする
                    path.Add(i);
                    if (i == target)
                    {
                        minPath = new List<int>(path);
                    }
                    else
                    {
                        //再帰呼び出し
                        Dfs(i, path, adList, target, ref minPath);
                    }
                    //探索済みを解除
                    path.RemoveAt(path.Count - 1);
                }
            }
        }
    }
}
