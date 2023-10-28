using System;
using System.Collections.Generic;

class Program
{
    //キューを用意
    static Queue<int> queue = new Queue<int>();
    
    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int n = input[0]; //頂点の数 
        int m = input[1]; //辺の本数
        int x = input[2] - 1; //頂点番号X (0-indexed)
        int y = input[3] - 1; //頂点番号Y (0-indexed)

        //隣接行列
        int[,] matrix = new int[n, n];
        for (int i = 0; i < m; i++)
        {
            int[] input2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int a = input2[0] - 1;
            int b = input2[1] - 1;
            matrix[a, b] = 1;
            matrix[b, a] = 1;
        }

        //訪問済みの頂点を管理する配列
        bool[] visited = new bool[n];
        //各頂点への距離を管理する配列
        int[] distance = new int[n];
        for (int i = 0; i < n; i++)
        {
            visited[i] = false;
            distance[i] = -1; //初期値は-1 (未訪問)
        }

        //幅優先探索
        BFS(matrix, visited, distance, x);

        //頂点Yまでの距離を出力
        Console.WriteLine(distance[y]);
    }

    //幅優先探索
    static void BFS(int[,] matrix, bool[] visited, int[] distance, int x)
    {
        queue.Enqueue(x);
        visited[x] = true;
        distance[x] = 0;

        while (queue.Count > 0)
        {
            int v = queue.Dequeue();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[v, i] == 1 && !visited[i])
                {
                    queue.Enqueue(i);
                    visited[i] = true;
                    distance[i] = distance[v] + 1;
                }
            }
        }
    }
}