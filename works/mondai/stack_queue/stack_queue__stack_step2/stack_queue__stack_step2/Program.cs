//https://paiza.jp/works/mondai/stack_queue/stack_queue__stack_step2

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int q = int.Parse(Console.ReadLine());
        Stack<string> a = new Stack<string>();

        // このforでは、命令の数だけ繰り返し処理を行う
        for (int i = 0; i < q; i++)
        {
            // 命令を表す文字列 query_i が与えられます。
            string[] query = Console.ReadLine().Split();
            // 命令の種類を表す整数 queryType と、X の値を表す整数 X が与えられます。
            int queryType = int.Parse(query[0]);

            // 命令の種類が 1 の場合は、スタックに X を積む命令です。
            if (queryType == 1)
            {
                a.Push(query[1]);
            }
            // 命令の種類が 2 の場合は、スタックから要素を 1 つ取り出す命令です。
            else if (queryType == 2)
            {
                if (a.Count > 0)
                {
                    //stackの中から取り出した値を出力します。
                    Console.WriteLine(a.Pop());
                }
            }
            //要素の数を反転させて出力します。
            Console.WriteLine(string.Join(" ", a.Reverse()));
        }
    }
}