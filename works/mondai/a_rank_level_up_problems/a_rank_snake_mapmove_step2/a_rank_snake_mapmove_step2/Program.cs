using System;

class Program
{
    private static int _moveX = 0, _moveY = 0; // 初期位置 (0, 0)

    private static readonly char[] Directions = { 'N', 'E', 'S', 'W' }; // 方向を表す配列

    //0: 北 (N)、1: 東 (E)、2: 南 (S)、3: 西 (W)
    private static int _currentDirectionIndex = 0;

    static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        int h = int.Parse(input[0]);
        int w = int.Parse(input[1]);
        int sy = int.Parse(input[2]); //Playerのy座標
        int sx = int.Parse(input[3]); //Playerのx座標
        char d = char.Parse(input[4]); // 現在向いている方角の1文字目を取得
        char m = char.Parse(input[5]); // L, R のいずれかであり、それぞれ 左・右 を意味します.

        string[] map = new string[h];

        for (int i = 0; i < h; i++)
        {
            map[i] = Console.ReadLine();
        }

        _moveX = sx;
        _moveY = sy;

        MoveCharacter(d, m);

        Console.WriteLine(IsMovePossible(h, w, sy, sx, d, m, map) ? "Yes" : "No");
    }

    private static void MoveCharacter(char startDirection, char moveDirection)
    {
        _currentDirectionIndex = Array.IndexOf(Directions, startDirection);

        _currentDirectionIndex =
            moveDirection == 'L' ? (_currentDirectionIndex + 3) % 4 : (_currentDirectionIndex + 1) % 4;


        int[] dx = { 0, 1, 0, -1 };
        int[] dy = { -1, 0, 1, 0 };

        _moveX += dx[_currentDirectionIndex];
        _moveY += dy[_currentDirectionIndex];
    }

    private static bool IsMovePossible(int h, int w, int sy, int sx, char d, char m, string[] map)
    {
        // 移動先が障害物でない かつ 移動先がマップの範囲内である場合に "Yes" を返す
        return !(_moveX < 0 || _moveX >= w || _moveY < 0 || _moveY >= h || map[_moveY][_moveX] == '#');
    }
}