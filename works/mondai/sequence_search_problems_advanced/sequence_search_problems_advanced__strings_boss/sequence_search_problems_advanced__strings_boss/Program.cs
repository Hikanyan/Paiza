// 数値 n, m, k, x と n 行 m 列からなる CSV 形式の文字列 s_1, s_2, ..., s_n が与えられます。この CSV 形式の文字列の k 列目の値が x 以上の行をすべて出力してください。
//
// CSV 形式とは、テキストデータを表形式で配置し、区切り文字であるカンマ , で区切ったデータ形式です。たとえば、以下のような文字列がCSV形式です。
//
//
// 1,2,3,4,5
// 11,22,33,44,55
// 12,23,34,45,56
// 100,200,300,400,500

using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var n = int.Parse(input[0]); //行数
        var m = int.Parse(input[1]); //列数は使われてない理由は、CSV形式の文字列の列数はすべて同じであるため
        var k = int.Parse(input[2]); //k列目
        var x = int.Parse(input[3]); //x以上
        for (var i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split(',');
            if (int.Parse(line[k - 1]) >= x)
            {
                Console.WriteLine(string.Join(",", line));
            }
        }
    }
}