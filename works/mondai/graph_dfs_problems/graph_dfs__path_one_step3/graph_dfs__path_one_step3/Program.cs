// https://paiza.jp/works/mondai/graph_dfs_problems/graph_dfs__path_one_step3

using System;

class Program
{
    static void Main()
    {
        var date = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var n = date[0]; // 頂点の数
        var s = date[1]; // スタートの頂点
        var k = date[2]; // 移動回数

        var path = FindPath(n, ref s, ref k);
        Console.WriteLine(string.Join(" ", path));
    }

    // 頂点数n、スタートの頂点s、移動回数kから、ウォークのリストを生成する
    static int[] FindPath(int n, ref int s, ref int k)
    {
        int[] path = new int[k + 1]; // ウォークのリストを生成します。
        path[0] = s; // 最初の頂点をウォークのリストに追加します。

        // ウォークのリストに現在の頂点からの隣接頂点を追加します。
        for (int i = 1; i <= k; i++)
        {
            path[i] = (s + i) % n; // 現在の頂点 `s` から `i` 回移動した頂点を計算し、リストに追加します。
            if (path[i] == 0) // 頂点数 `n` で割った余りが0の場合、これは頂点数を超えた場合を示します。
                path[i] = n; // 頂点数 `n` に循環するように、0を `n` に置き換えます。
        }

        return path; // ウォークのリストを返します。
    }

}