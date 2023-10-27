using System;

public class Program
{
    static int moveX, moveY;
    static int currentDirectionIndex = 0; // 北を向いて開始
    static char[] directions = { 'N', 'E', 'S', 'W' };

    public static void MoveCharacter(char moveDirection)
    {
        if (moveDirection == 'L')
        {
            currentDirectionIndex = (currentDirectionIndex + 3) % 4; // 左に90度回転
        }
        else
        {
            currentDirectionIndex = (currentDirectionIndex + 1) % 4; // 右に90度回転
        }

        switch (directions[currentDirectionIndex])
        {
            case 'N': moveY--; break;
            case 'S': moveY++; break;
            case 'E': moveX++; break;
            case 'W': moveX--; break;
        }
    }

    public static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        moveX = int.Parse(input[0]);
        moveY = int.Parse(input[1]);
        int totalSteps = int.Parse(input[2]);

        for (int i = 0; i < totalSteps; i++)
        {
            char moveDirection = Console.ReadLine()[0];
            MoveCharacter(moveDirection);
            Console.WriteLine($"{moveX} {moveY}");
        }
    }
}