using System;

class Tugas1
{
    public static void Main(string[] args)
    {
        string username, password, jenkel;
        bool statusNikah;
        int age, nilaiPertama, nilaiKedua, nilaiKetiga;

        Console.WriteLine("=== BIODATA ===");
        Console.Write("Input Username = ");
        username = Console.ReadLine();
        Console.Write("Input Password = ");
        password = Console.ReadLine();
        Console.Write("Input Umur = ");
        age = int.Parse(Console.ReadLine());
        Console.Write("Input Jenis Kelamin (L/P) = ");
        char jenkelTemp = Console.ReadLine()[0];
        while (jenkelTemp != 'L' && jenkelTemp != 'P')
        {
            Console.WriteLine("Inputan Salah. Coba lagi!\n");
            jenkelTemp = Console.ReadLine()[0];
        }
        if (jenkelTemp == 'L')
        {
            jenkel = "Laki-Laki";
        }
        else
        {
            jenkel = "Perempuan";
        }
        Console.Write("Status Menikah (Y/N) = ");
        char statusTemp = Console.ReadLine()[0];
        while (statusTemp != 'Y' && statusTemp != 'N')
        {
            Console.WriteLine("Inputan Salah. Coba lagi!");
            statusTemp = Console.ReadLine()[0];
        }
        if (statusTemp == 'Y')
        {
            statusNikah = true;
        }
        else
        {
            statusNikah = false;
        }

        Console.WriteLine("=== PERHITUNGAN ===");
        Console.Write("Input Nilai Pertama = ");
        nilaiPertama = int.Parse(Console.ReadLine());
        Console.Write("Input Nilai Kedua = ");
        nilaiKedua = int.Parse(Console.ReadLine());
        Console.Write("Input Nilai Ketiga = ");
        nilaiKetiga = int.Parse(Console.ReadLine());


        Console.WriteLine("=== HASIL INPUT BIODATA ===");
        Console.WriteLine("Umur = " + age);
        Console.WriteLine("Username = " + username);
        Console.WriteLine("Password = " + password);
        Console.WriteLine("Jenis Kelamin = " + jenkel);
        Console.WriteLine("Status Menikah = " + statusNikah);


        Console.WriteLine("=== HASIL INPUT PERHITUNGAN ===");
        Console.WriteLine("Total Nilai = " + (nilaiPertama + nilaiKedua + nilaiKetiga));
        Console.WriteLine("Rata Nilai = " + (nilaiPertama + nilaiKedua + nilaiKetiga) / 3);


    }
}