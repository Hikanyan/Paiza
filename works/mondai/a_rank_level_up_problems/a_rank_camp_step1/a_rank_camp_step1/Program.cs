// 盤面の情報が与えられます。現在プレイヤーのいるマスは '*' になっており、そのマスはプレイヤーの陣地です。
//
// プレイヤーは現在の陣地から上下左右に 1 マス移動することで到達できるマスをプレイヤーの陣地にします。
//
// プレイヤーの陣地を '*' にした盤面を出力してください。
// 入力される値
// H W     
// S_0     
// ...     
// S_(H-1)
//
//
// ・ 1 行目では、盤面の行数 H , 列数 W が与えられます。
// ・ 続く H 行のうち i 行目 (0 ≦ i < H) には、盤面の i 行目の文字をまとめた文字列 S_i が与えられ、S_i の j 文字目は、盤面の i 行目の j 列目に書かれている文字を表します。(0 ≦ j < W)
//
// 入力値最終行の末尾に改行が１つ入ります。
// 期待する出力
// H 行の出力
//
// ・ 操作後の盤面を H 行で出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var line = Console.ReadLine().Split(' ');
        var h = int.Parse(line[0]);
        var w = int.Parse(line[1]);
        var map = new char[h, w];
        var player = new List<int>();

        for (int i = 0; i < h; i++)
        {
            var line2 = Console.ReadLine();
            for (int j = 0; j < w; j++)
            {
                map[i, j] = line2[j];
                if (line2[j] == '*')
                {
                    player.Add(i);
                    player.Add(j);
                }
            }
        }

        var playerX = player[0];
        var playerY = player[1];

        if (playerX - 1 >= 0)
        {
            map[playerX - 1, playerY] = '*';
        }

        if (playerX + 1 < h)
        {
            map[playerX + 1, playerY] = '*';
        }

        if (playerY - 1 >= 0)
        {
            map[playerX, playerY - 1] = '*';
        }

        if (playerY + 1 < w)
        {
            map[playerX, playerY + 1] = '*';
        }

        for (int i = 0; i < h; i++)
        {
            var line3 = "";
            for (int j = 0; j < w; j++)
            {
                line3 += map[i, j];
            }

            Console.WriteLine(line3);
        }
    }
}