using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var n = int.Parse(input[0]);
        var m = int.Parse(input[1]);
        var x = int.Parse(input[2]);
        var graph = new int[n, n];

        for (int i = 0; i < m; i++)
        {
            var input2 = Console.ReadLine().Split(' ');
            var a = int.Parse(input2[0]);
            var b = int.Parse(input2[1]);
            graph[a - 1, b - 1] = 1;
            graph[b - 1, a - 1] = 1;
        }

        var visited = new bool[n];
        visited[x - 1] = true;
        Console.WriteLine(x);
        Dfs(graph, visited, x - 1);
    }

    static void Dfs(int[,] graph, bool[] visited, int x)
    {
        for (int i = 0; i < graph.GetLength(0); i++)
        {
            if (graph[x, i] == 1 && !visited[i])
            {
                visited[i] = true;
                Console.WriteLine(i + 1);
                Dfs(graph, visited, i);
            }
        }
    }
}