using System;

public class Logika3
{
    public static void Main()
    {
        string user, pass;

        Console.Write("Username: ");
        user = Console.ReadLine();
        Console.Write("Password: ");
        pass = Console.ReadLine();

        if (user == "ocbc" && pass == "bootcamp")
        {
            Console.WriteLine("Anda berhasil login\nBelajar C#");

        }
        else if (user != "ocbc" && pass == "bootcamp")
        {
            Console.WriteLine("Username salah");
        }
        else if (user == "ocbc" && pass != "bootcamp")
        {
            Console.WriteLine("Password salah");
        }
        else
        {
            Console.WriteLine("Username dan Password salah");
        }
    }
}