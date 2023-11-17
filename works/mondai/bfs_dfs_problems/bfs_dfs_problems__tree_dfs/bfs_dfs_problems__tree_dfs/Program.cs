/*
木を構成する 1 〜 N の番号がつけられた頂点とそれらを結ぶ辺の情報と、
頂点番号 X が与えられるので、頂点 X から次のルールにしたがって深さ優先探索をしたときに
訪れる頂点番号を順に出力してください。

・現在の頂点に隣接している頂点のうち、未訪問かつ番号が一番小さい頂点を探索する。

入力される値
N X
a_1 b_1
...
a_{N-1} b_{N-1}

・ 1 行目では、頂点の数 N と、頂点番号 X が半角スペース区切りで与えられます。
・ 続く N-1 行では、N-1 個の辺の両端の頂点の番号 a_i, b_i (1 ≦ i ≦ N-1) が与えられます。

期待する出力
・与えられた木を頂点 X から深さ優先探索をしたときに訪れる頂点の番号を順に改行区切りで出力してください。

条件
すべてのテストケースにおいて、以下の条件をみたします。

・1 ≦ N ≦ 200
・1 ≦ X ≦ N
・1 ≦ a_i, b_i ≦ N (1 ≦ i ≦ N-1)
・a_i ≠ b_i (1 ≦ i ≦ N-1)

入力例1
5 2
1 2
1 3
2 4
4 5

出力例1
2
1
3
4
5
*/
/*
入力の処理
隣接行列の初期化
深さ優先探索 (DFS) の実装
探索の開始
出力
*/

using System;

class Program
{
    private static void Main()
    {
        var line = Console.ReadLine().Split(' ');
        var n = int.Parse(line[0]); //頂点の数
        var x = int.Parse(line[1]); //頂点番号
        var edges = new int[n, n]; //隣接行列

        for (int i = 0; i < n - 1; i++) //辺の数は頂点の数-1
        {
            line = Console.ReadLine().Split(' ');
            var a = int.Parse(line[0]); //頂点番号
            var b = int.Parse(line[1]); //頂点番号
            edges[a - 1, b - 1] = 1; //隣接行列に辺を追加
            edges[b - 1, a - 1] = 1; //隣接行列に辺を追加
        }

        var visited = new bool[n]; //訪問済みの頂点を記録する配列
        visited[x - 1] = true; //頂点xは訪問済み
        Console.WriteLine(x); //頂点xを出力
        Dfs(edges, visited, x - 1);
    }

    //深さ優先探索
    private static void Dfs(int[,] edges, bool[] visited, int current)
    {
        for (int i = 0; i < edges.GetLength(0); i++) //隣接行列の行数
        {
            if (edges[current, i] == 1 && !visited[i]) //辺があり、かつ未訪問の頂点
            {
                visited[i] = true; //頂点iは訪問済み
                Console.WriteLine(i + 1); //頂点iを出力
                Dfs(edges, visited, i); //頂点iから深さ優先探索
            }
        }
    }
}