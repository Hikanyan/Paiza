// https://paiza.jp/works/mondai/graph_dfs_problems/graph_dfs__path_one_step5
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //この問題は、深さ優先探索を用いて解くことができる。

    static int n, s, t, p;
    static List<List<int>> adList = new List<List<int>>();
    static List<int> minPath = null;

    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        n = input[0];
        s = input[1];
        t = input[2];
        p = input[3];
        
;
        for (int i = 1; i <= n; i++)
        {
            Console.ReadLine();
            var newList = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            adList.Add(newList.ToList());
        }


        List<int> path = new List<int> { s };
        DFS(s, path);

        Console.WriteLine(minPath == null ? "-1" : string.Join(" ", minPath));
    }

    //深さ優先探索
    //v:現在の頂点
    //path:現在の経路
    static void DFS(int v, List<int> path)
    {
        //現在の頂点から行ける頂点を全て探索する
        foreach (int next in adList[v-1])
        {
            //もし、現在の頂点に行ったことがなければ、その頂点に行く
            if (!path.Contains(next))
            {
                //現在の経路に頂点を追加する
                path.Add(next);
                if (next == t)
                {
                    if (path.Contains(p) && (minPath == null || path.Count < minPath.Count))
                    {
                        minPath = new List<int>(path);
                    }
                }

                //そうでなければ、その頂点から探索を続ける
                else
                {
                    DFS(next, path);
                }
            }

        }

        //現在の経路から頂点を削除する
        path.RemoveAt(path.Count - 1);
    }
}