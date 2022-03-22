using System;

class Assignment1
{
    public static void Main()
    {
        int number = 64;
        int loop = 5;
        int a, b;

        for (int x = 0; x < loop; x++)
        {

            for (a = (loop - x); a > 0; a--)
            {
                Console.Write(" ");
            }

            for (a = 1; a <= x; a++)
            {
                Console.Write((char)(number + a));
            }

            for (b = a; b > 0; b--)
            {
                Console.Write((char)(number + b));
            }
            Console.WriteLine("");
        }

        for (int i = 0; i < loop; i++)
        {

            for (a = (loop - i); a > 0; a--)
            {
                Console.Write(" ");
            }

            for (a = 1; a <= i; a++)
            {
                Console.Write(a);
            }

            for (b = a; b > 0; b--)
            {
                Console.Write(b);
            }
            Console.WriteLine("");
        }

        int inputNum, result = 1;

        Console.Write("Enter any number: ");
        inputNum = int.Parse(Console.ReadLine());

        for (a = 1; a <= inputNum; a++)
        {
            result = a * result;
        }
        Console.WriteLine("Factorial of " + inputNum + ": " + result);

        int inputReverse;
        string reverse;
        Console.Write("Enter the number to reverse: ");
        inputReverse = int.Parse(Console.ReadLine());
        reverse = inputReverse.ToString();

        Console.Write("Reversed Number: ");
        for (a = reverse.Length - 1; a >= 0; a--)
        {
            Console.Write(reverse[a]);
        }

        int inputConvert;
        string[] numberText = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        Console.Write("Enter the number to text: ");
        inputConvert = int.Parse(Console.ReadLine());
        string temp = inputConvert.ToString();

        for (a = 0; a < inputConvert.ToString().Length; a++)
        {

            Console.Write(" " + numberText[(int.Parse(temp[a].ToString()) - 1)]);
        }


    }
}

//BUAT MENU PILIHAN