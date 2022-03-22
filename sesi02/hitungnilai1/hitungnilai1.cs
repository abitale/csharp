using System;

class HitungNilai
{
    public static void Main(string[] args)
    {
        int pertama, kedua, ketiga, total;
        double rata;

        Console.WriteLine("=== Menghitung Nilai ===");
        Console.WriteLine("Masukan nilai Pertama: ");
        pertama = int.Parse(Console.ReadLine());
        Console.WriteLine("Masukan nilai Kedua: ");
        kedua = int.Parse(Console.ReadLine());
        Console.WriteLine("Masukan nilai Ketiga: ");
        ketiga = int.Parse(Console.ReadLine());

        total = pertama + kedua + ketiga;
        rata = total / 3.0;
        Console.WriteLine("Total Nilai adalah: " + total);
        Console.WriteLine("Rata-rata Nilai adalah: " + rata);
        Console.Read();
    }
}