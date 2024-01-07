using System;

class Program {
    static void Main(string[] args) {
        string[] tokens = Console.ReadLine().Split();
        int firstNumber = int.Parse(tokens[0]);
        int secondNumber = int.Parse(tokens[1]);

        // CalculateGcd関数を呼び出し、最大公約数を計算し、結果を出力
        Console.WriteLine(Gcd(firstNumber, secondNumber));
    }

    // 最大公約数を計算するメソッド
    static int Gcd(int number1, int number2) {
        // どちらかの数が0になるまでループ
        while (number1 != 0 && number2 != 0) {
            if (number1 > number2) {
                // number1がnumber2より大きい場合、number1をnumber1をnumber2で割った余りで更新
                number1 %= number2;
            } else {
                // number2がnumber1以上の場合、number2をnumber2をnumber1で割った余りで更新
                number2 %= number1;
            }
        }
        // number1かnumber2のどちらかが0になった場合、0でない方の数を返す
        return number1 == 0 ? number2 : number1;
    }
    
    //再起呼び出しで最大公約数を計算するメソッド
    static int GcdRecursive(int number1, int number2) {
        // number2が0になった場合、number1を返す
        if (number2 == 0) {
            return number1;
        }
        // number2が0でない場合、number2とnumber1をnumber2で割った余りを引数にして再起呼び出し
        return GcdRecursive(number2, number1 % number2);
    }
}