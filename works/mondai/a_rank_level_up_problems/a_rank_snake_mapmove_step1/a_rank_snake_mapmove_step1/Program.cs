using System;

class Program
{
    private static readonly char[] Directions = { 'N', 'E', 'S', 'W' }; // 移動方向
    private static int _moveX, _moveY; // 移動量

    //Playerの移動方向
    private static void MoveCharacter(char moveDirection)
    {
        switch (moveDirection)
        {
            case 'N':
                _moveY--;
                break;
            case 'S':
                _moveY++;
                break;
            case 'E':
                _moveX++;
                break;
            case 'W':
                _moveX--;
                break;
        }
    }

    static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        int h = int.Parse(input[0]);
        int w = int.Parse(input[1]);
        int sy = int.Parse(input[2]); //Playerのy座標
        int sx = int.Parse(input[3]); //Playerのx座標
        char moveDirection = char.Parse(input[4]);

        string[] map = new string[h];

        for (int i = 0; i < h; i++)
        {
            map[i] = Console.ReadLine();
        }


        Console.WriteLine(IsMovePossible(h, w, sy, sx, map, moveDirection) ? "Yes" : "No");
    }


    private static bool IsMovePossible(int h, int w, int sy, int sx, string[] map, char moveDirection)
    {
        MoveCharacter(moveDirection);
        _moveY += sy;
        _moveX += sx;

        if (_moveX < 0 || _moveX >= w || _moveY < 0 || _moveY >= h || map[_moveY][_moveX] == '#') return false;
        return true;
    }
}