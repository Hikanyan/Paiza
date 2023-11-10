using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        

        //a-zまでの文字を順番に調べる
        for (char c = 'a'; c <= 'z'; c++)
        {
            Console.WriteLine(input.Count(x => x == c)); //文字の出現回数を出力
            
            // var count = 0; //文字の出現回数
            // foreach (var ch in input) //文字列の各文字について
            // {
            //     if (ch == c) //文字が一致したら
            //     {
            //         count++; //カウントを増やす
            //     }
            // }
            //
            // //出現回数を出力
            // Console.WriteLine(count);
        }
    }
}