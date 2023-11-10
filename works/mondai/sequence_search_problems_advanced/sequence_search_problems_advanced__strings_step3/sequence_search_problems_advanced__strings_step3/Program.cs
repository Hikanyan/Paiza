using System;

class Program
{
    static void Main()
    {
        //
        // var inputS = Console.ReadLine();
        // var s = inputS.Split(',');
        //
        // //スペースを出力したいから、Joinを使う
        //
        // Console.WriteLine(string.Join(" ", s));


        //Replaceで置き換える
        Console.WriteLine(Console.ReadLine().Replace(",", " "));
    }
}