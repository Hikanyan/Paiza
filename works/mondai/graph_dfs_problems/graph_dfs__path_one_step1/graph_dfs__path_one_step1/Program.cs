//https://paiza.jp/works/mondai/graph_dfs_problems/graph_dfs__path_one_step1
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        var date = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var n = date[0];//n 個の頂点
        var s = date[1];//頂点 s に隣接している頂点
        List<int[]> adjacencyList = new List<int[]>();

        //隣接リストの作成
        for (int i = 0; i < n; i++)
        {
            Console.ReadLine();//次に来る頂点個数なのだがC#においては不要
            date = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            adjacencyList.Add(date);
        }
        Console.WriteLine(adjacencyList[s-1].Max());
    }
}