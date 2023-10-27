using System;

public class Program
{
    //方角の配列
    static char[] directions = { 'N', 'E', 'S', 'W' };
    static int moveX = 0, moveY = 0;

    //キャラクターの移動
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
        //変数の宣言・初期化
        int startX, startY, totalSteps, stepsInCurrentDirection = 1, currentDirectionIndex = 1, currentStepSize = 1;
        bool isFirstStepInDirection = true;

        //入力
        var input = Console.ReadLine().Split(' ');
        startX = int.Parse(input[0]);
        startY = int.Parse(input[1]);
        totalSteps = int.Parse(input[2]);

        //totalSteps回数分キャラクターを移動させる
        for (int i = 0; i < totalSteps; i++)
        {
            MoveCharacter(directions[currentDirectionIndex % 4]);//方角の配列のインデックスを4で割った余りを使う
            stepsInCurrentDirection--;

            //方角を変える
            if (!isFirstStepInDirection && stepsInCurrentDirection == 0)
            {
                //方角を変えるときはステップ数を増やす
                isFirstStepInDirection = true;
                currentStepSize++;
                stepsInCurrentDirection = currentStepSize;
                currentDirectionIndex++;
            }
            //方角を変えない
            else if (stepsInCurrentDirection == 0)
            {
                //方角を変えないときはステップ数を減らす
                stepsInCurrentDirection = currentStepSize;
                isFirstStepInDirection = false;
                currentDirectionIndex++;
            }
        }

        Console.WriteLine($"{startX + moveX} {startY + moveY}");
    }
}

