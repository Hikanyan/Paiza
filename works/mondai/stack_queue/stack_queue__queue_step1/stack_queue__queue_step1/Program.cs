//https://paiza.jp/works/mondai/stack_queue/stack_queue__queue_step1

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
                //Enqueueメソッドは、キューの末尾に要素を追加します。
                a.Enqueue(query[1]);
                Console.WriteLine(string.Join(" ", a));
            }
            else if (queryType == 2)
            {
                if (a.Count > 0)
                {
                    //Dequeueメソッドは、キューの先頭から要素を取り出します。
                    a.Dequeue();
                    Console.WriteLine(string.Join(" ", a));
                }
            }
        }
    }
}