using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var n = int.Parse(input[0]);
        var m = int.Parse(input[1]);
        var graph = new int[n, n];
        for (int i = 0; i < m; i++)
        {
            var input2 = Console.ReadLine().Split(' ');
            var a = int.Parse(input2[0]) - 1;
            var b = int.Parse(input2[1]) - 1;
            graph[a, b] = 1;
            graph[b, a] = 1;
        }

        var visited = new bool[n];
        var count = 0;
        for (int i = 0; i < n; i++)
        {
            if (visited[i]) continue;
            count++;
            Dfs(i, visited, graph);
        }

        Console.WriteLine(count);
    }

    static void Dfs(int v, bool[] visited, int[,] graph)
    {
        visited[v] = true;
        for (int i = 0; i < graph.GetLength(0); i++)
        {
            if (graph[v, i] == 1 && !visited[i])
            {
                Dfs(i, visited, graph);
            }
        }
    }
}