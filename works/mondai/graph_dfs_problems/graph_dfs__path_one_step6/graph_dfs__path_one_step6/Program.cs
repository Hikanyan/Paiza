// https://paiza.jp/works/mondai/graph_dfs_problems/graph_dfs__path_one_step6

using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static int n, s, t;
    static int[] k;
    static Dictionary<int, List<int>> adList;
    static List<int> minPath = null;

    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        n = input[0]; //頂点数
        s = input[1]; //始点
        t = input[2]; //終点


        Console.ReadLine();
        k = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); //除外する頂点


        adList = new Dictionary<int, List<int>>();
        for (int i = 1; i <= n; i++)
        {
            Console.ReadLine();
            adList[i] = new List<int>();
            int[] adInput = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            foreach (int ad in adInput)
            {
                if (!k.Contains(ad))
                    adList[i].Add(ad);
            }
        }
        
        DFS(s, new List<int> { s });

        Console.WriteLine(string.Join(" ", minPath));
    }

    //深さ優先探索
    //v:現在の頂点
    //path:現在の経路
    static void DFS(int v, List<int> path)
    {
        //現在の頂点から行ける頂点を全て探索する
        foreach (int next in adList[v - 1])
        {
            //もし、現在の頂点に行ったことがなければ、その頂点に行く
            if (!path.Contains(next))
            {
                //現在の経路に頂点を追加する
                path.Add(next);
                if (next == t)
                {
                    if ((minPath == null || path.Count < minPath.Count))
                    {
                        minPath = new List<int>(path);
                    }
                }

                //そうでなければ、その頂点から探索を続ける
                else
                {
                    DFS(next, path);
                }

                //現在の経路から頂点を削除する
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}