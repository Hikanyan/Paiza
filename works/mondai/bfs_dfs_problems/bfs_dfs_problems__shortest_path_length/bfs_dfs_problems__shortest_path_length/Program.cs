using System;
using System.Collections.Generic; // 追加: Queueを使うため

class Program
{
    //キューを用意
    static Queue<int> queue = new Queue<int>();
    
    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int n = input[0]; //頂点の数 
        int m = input[1]; //辺の本数
        int x = input[2]; //頂点番号 

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
        for (int i = 0; i < n; i++)
        {
            visited[i] = false;
        }

        //幅優先探索
        BFS(matrix, visited, x - 1);
    }

    //幅優先探索
    static void BFS(int[,] matrix, bool[] visited, int x)
    {
        queue.Enqueue(x);
        visited[x] = true;

        while (queue.Count > 0)
        {
            int v = queue.Dequeue();
            Console.WriteLine(v + 1);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[v, i] == 1 && !visited[i])
                {
                    queue.Enqueue(i);
                    visited[i] = true;
                }
            }
        }
    }
}