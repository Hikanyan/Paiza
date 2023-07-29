//https://paiza.jp/works/mondai/graph_dfs_problems/graph_dfs__path_one_step2

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var date = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var n = date[0]; // 頂点の数
        var s = date[1]; // スタートの頂点
        var k = date[2]; // 移動回数

        Random rnd = new Random();

        // ウォークのリストを生成し、最初の頂点を追加
        List<int> walk = new List<int>() { s };

        for (int i = 0; i < k; i++)
        {
            // 現在の頂点の隣接頂点のリストを作成
            List<int> neighbors = Enumerable.Range(1, n).Where(v => v != walk.Last()).ToList();

            // ランダムに次の頂点を選択し、ウォークに追加
            int nextVertex = neighbors[rnd.Next(neighbors.Count)];
            walk.Add(nextVertex);
        }

        Console.WriteLine(string.Join(" ", walk));
    }
}