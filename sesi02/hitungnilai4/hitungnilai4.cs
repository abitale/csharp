using System;

class HitungNilai4
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Password: ");
        string pass = Console.ReadLine();

        bool isAdult = age > 18;
        bool isPasswordValid = pass == "OCBC";

        if (isAdult && isPasswordValid)
        {
            Console.WriteLine("Welcome to the Club!");
        }
        else
            Console.WriteLine("Sorry, try again!");
    }
}