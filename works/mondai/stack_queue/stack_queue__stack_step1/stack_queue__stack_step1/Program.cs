//https://paiza.jp/works/mondai/stack_queue/stack_queue__stack_step1

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1行目には、命令の数を表す整数 q が与えられます。
        int q = int.Parse(Console.ReadLine());
        // 続く q 行には、命令を表す文字列 s_i が与えられます。
        Stack<int> a = new Stack<int>();

        //このforでは、命令の数だけ繰り返し処理を行う
        for (int i = 0; i < q; i++)
        {
            //命令を表す文字列 s_i が与えられます。
            string[] query = Console.ReadLine().Split();
            //命令の種類を表す整数 type と、X の値を表す整数 X が与えられます。
            int type = int.Parse(query[0]);

            //命令の種類が 1 の場合は、スタックに X を積む命令です。
            if (type == 1)
                a.Push(int.Parse(query[1]));
            
            else if (type == 2)
                if (a.Count > 0)
                    a.Pop();

            //要素の数を反転させて出力します。
            Console.WriteLine(string.Join(" ", a.Reverse()));
        }
    }
}