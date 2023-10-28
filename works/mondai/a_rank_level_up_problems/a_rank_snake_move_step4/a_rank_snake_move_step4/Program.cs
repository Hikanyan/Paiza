using System;

public class Program
{
    static char[] directions = { 'N', 'E', 'S', 'W' };
    static int moveX = 0, moveY = 0;

    public static void MoveCharacter(char direction)
    {
        switch (direction)
        {
            case 'N':
                moveY--;
                break;
            case 'S':
                moveY++;
                break;
            case 'E':
                moveX++;
                break;
            case 'W':
                moveX--;
                break;
        }
    }

    public static void Main(string[] args)
    {
        // 開始座標と向きを取得
        int startX, startY, totalSteps, stepsInCurrentDirection = 1, currentDirectionIndex = 1, currentStepSize = 1;
        bool isFirstStepInDirection = true;

        var input = Console.ReadLine().Split(' ');
        startX = int.Parse(input[0]);
        startY = int.Parse(input[1]);
        totalSteps = int.Parse(input[2]);

        for (int i = 0; i < totalSteps; i++)
        {
            MoveCharacter(directions[currentDirectionIndex % 4]);
            stepsInCurrentDirection--;

            if (!isFirstStepInDirection && stepsInCurrentDirection == 0)
            {
                isFirstStepInDirection = true;
                currentStepSize++;
                stepsInCurrentDirection = currentStepSize;
                currentDirectionIndex++;
            }
            else if (stepsInCurrentDirection == 0)
            {
                stepsInCurrentDirection = currentStepSize;
                isFirstStepInDirection = false;
                currentDirectionIndex++;
            }
        }

        Console.WriteLine($"{startX + moveX} {startY + moveY}");
    }
}