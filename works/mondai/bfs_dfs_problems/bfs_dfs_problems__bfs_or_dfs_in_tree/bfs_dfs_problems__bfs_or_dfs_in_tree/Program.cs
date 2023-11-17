using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var line = Console.ReadLine().Split(' ');
        var n = int.Parse(line[0]);
        var x = int.Parse(line[1]);
        var y = int.Parse(line[2]);
        var graph = new List<int>[n + 1];

        for (int i = 1; i <= n; i++)
        {
            graph[i] = new List<int>();
        }

        for (var i = 0; i < n - 1; i++)
        {
            line = Console.ReadLine().Split(' ');
            var a = int.Parse(line[0]);
            var b = int.Parse(line[1]);
            graph[a].Add(b);
            graph[b].Add(a);
        }

        var bfsVisitedCount = Bfs(graph, x, y);
        var dfsVisitedCount = Dfs(graph, x, y);

        if (bfsVisitedCount < dfsVisitedCount)
            Console.WriteLine("bfs");
        else if (dfsVisitedCount < bfsVisitedCount)
            Console.WriteLine("dfs");
        else
            Console.WriteLine("same");
    }

    private static int Bfs(List<int>[] graph, int start, int target)
    {
        var visited = new bool[graph.Length];
        var queue = new Queue<int>();
        queue.Enqueue(start);
        visited[start] = true;
        int visitedCount = 1;

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            if (current == target)
                return visitedCount;

            foreach (var neighbor in graph[current].Where(neighbor => !visited[neighbor]))
            {
                queue.Enqueue(neighbor);
                visited[neighbor] = true;
                visitedCount++;
            }
        }
        return -1;
    }

    private static int Dfs(List<int>[] graph, int start, int target)
    {
        var visited = new bool[graph.Length];
        return DfsUtil(graph, start, target, visited, 0);
    }

    private static int DfsUtil(List<int>[] graph, int current, int target, bool[] visited, int visitedCount)
    {
        if (current == target)
            return visitedCount;

        visited[current] = true;
        visitedCount++;

        foreach (var neighbor in graph[current].OrderBy(n => n))
        {
            if (!visited[neighbor])
            {
                var result = DfsUtil(graph, neighbor, target, visited, visitedCount);
                if (result != -1)
                    return result;
            }
        }
        return -1;
    }
}
