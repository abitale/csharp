using System;

public class Logika4
{
    public static void Main()
    {
        double nilai;
        Console.Write("Nilai: ");
        nilai = Convert.ToDouble(Console.ReadLine());

        if (nilai >= 85)
        {
            Console.WriteLine("Kamu mendapatkan grade A");
        }
        else if (nilai >= 65)
        {
            Console.WriteLine("Kamu mendapatkan grade B");
        }
        else if (nilai >= 45)
        {
            Console.WriteLine("Kamu mendapatkan grade C");
        }
        else if (nilai >= 25)
        {
            Console.WriteLine("Kamu mendapatkan grade D");
        }
    }
}