using System;

namespace FindCharacterPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            // 文字列sと文字cを入力
            string s = Console.ReadLine();
            string c = Console.ReadLine();

            // 文字cが文字列sに存在するかどうかチェック
            int position = s.IndexOf(c);

            // positionが-1なら文字cはsに含まれていない
            if (position == -1)
            {
                Console.WriteLine("Character not found.");
            }
            else
            {
                // IndexOfは0から始まるインデックスを返すので、1を加算して1から始まるインデックスに変換
                Console.WriteLine(position + 1);
            }
        }
    }
}