using System;

public class Program
{
    public static void Main(string[] args)
    {
        // 開始座標と向きを取得
        string[] initialInputs = Console.ReadLine().Split(' ');
        int startY = int.Parse(initialInputs[0]);
        int startX = int.Parse(initialInputs[1]);
        string initialDirection = initialInputs[2];

        // 移動指示を取得
        string moveDirection = Console.ReadLine();

        // 現在の座標を初期座標に設定
        int currentY = startY;
        int currentX = startX;

        if (initialDirection == "N")
        {
            if (moveDirection == "L")
                currentX -= 1;
            else
                currentX += 1;
        }
        else if (initialDirection == "S")
        {
            if (moveDirection == "L")
                currentX += 1;
            else
                currentX -= 1;
        }
        else if (initialDirection == "E")
        {
            if (moveDirection == "L")
                currentY -= 1;
            else
                currentY += 1;
        }
        else if (initialDirection == "W")
        {
            if (moveDirection == "L")
                currentY += 1;
            else
                currentY -= 1;
        }

        Console.WriteLine($"{currentY} {currentX}");
    }
}