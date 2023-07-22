//https://paiza.jp/works/mondai/stack_queue/stack_queue__queue_step2
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int q = int.Parse(Console.ReadLine());
        Queue<string> a = new Queue<string>();
        
        for (int i = 0; i < q; i++)
        {
            string[] query = Console.ReadLine().Split();
            int queryType = int.Parse(query[0]);
            
            if (queryType == 1)
            {
                a.Enqueue(query[1]);
            }
            else if (queryType == 2)
            {
                if (a.Count > 0)
                {
                    Console.WriteLine(string.Join(" ", a.Dequeue()));
                }
            }
            Console.WriteLine(string.Join(" ", a));
        }
    }
}