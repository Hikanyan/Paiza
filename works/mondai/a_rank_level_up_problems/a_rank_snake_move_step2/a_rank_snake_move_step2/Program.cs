using System;

namespace FindHashPosition
{
    class Program
    {
        static void Main()
        {
            // 入力を受け取る
            string[] inputs = Console.ReadLine().Split(' ');
            int y = int.Parse(inputs[0]);
            int x = int.Parse(inputs[1]);
            int n = int.Parse(inputs[2]);

            //各移動方向に従って、移動後の座標を出力する
            for (int i = 0; i < n; i++)
            {
                char direction = Console.ReadLine()[0];

                // 移動後の座標を出力
                switch (direction)
                {
                    case 'N':
                        y -= 1;
                        break;
                    case 'S':
                        y += 1;
                        break;
                    case 'E':
                        x += 1;
                        break;
                    case 'W':
                        x -= 1;
                        break;
                }

                Console.WriteLine($"{y} {x}");
            }
        }
    }
}