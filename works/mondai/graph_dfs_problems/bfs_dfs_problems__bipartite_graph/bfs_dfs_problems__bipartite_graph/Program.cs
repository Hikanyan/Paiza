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

        var color = new int[n];
        var isBipartite = true;
        for (int i = 0; i < n; i++)
        {
            if (color[i] == 0)
            {
                if (!dfs(graph, color, i, 1))
                {
                    isBipartite = false;
                    break;
                }
            }
        }

        Console.WriteLine(isBipartite ? "Yes" : "No");
    }

    static bool dfs(int[,] graph, int[] color, int v, int c)
    {
        color[v] = c;
        for (int i = 0; i < graph.GetLength(0); i++)
        {
            if (graph[v, i] == 1)
            {
                if (color[i] == c) return false;
                if (color[i] == 0 && !dfs(graph, color, i, -c)) return false;
            }
        }

        return true;
    }
}