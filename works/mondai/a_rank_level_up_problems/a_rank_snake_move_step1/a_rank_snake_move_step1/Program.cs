using System;

namespace FindHashPosition
{
    class Program
    {
        static void Main()
        {
            // 入力を受け取る
            string[] inputs = Console.ReadLine().Split(' ');
            int h = int.Parse(inputs[0]);
            int w = int.Parse(inputs[1]);

            // '#' の位置を見つけて出力
            for (int y = 0; y < h; y++)
            {
                string line = Console.ReadLine();
                for (int x = 0; x < w; x++)
                {
                    if (line[x] == '#')
                    {
                        Console.WriteLine($"{y} {x}");
                        return;  // '#' は1つだけなので、見つけたら終了
                    }
                }
            }
        }
    }
}