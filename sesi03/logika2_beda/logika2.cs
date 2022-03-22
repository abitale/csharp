using System;

public class Logika2Beda
{
    public static void Main()
    {
        string nama, jurusan;
        int nilai;

        Console.Write("Masukan nama= ");
        nama = Console.ReadLine();
        Console.Write("Masukan jurusan= ");
        jurusan = Console.ReadLine();
        Console.Write("Masukan nilai= ");
        nilai = int.Parse(Console.ReadLine());

        if (nilai == 0)
        {
            Console.WriteLine("Nama: " + nama);
            Console.WriteLine("Jurusan: " + jurusan);
            Console.WriteLine("Nilai kamu E");
        }
        else if (nilai < 50)
        {
            Console.WriteLine("Nama: " + nama);
            Console.WriteLine("Jurusan: " + jurusan);
            Console.WriteLine("Nilai kamu D");
        }
        else if (nilai < 67)
        {
            Console.WriteLine("Nama: " + nama);
            Console.WriteLine("Jurusan: " + jurusan);
            Console.WriteLine("Nilai kamu C");
        }
        else if (nilai < 84)
        {
            Console.WriteLine("Nama: " + nama);
            Console.WriteLine("Jurusan: " + jurusan);
            Console.WriteLine("Nilai kamu B");
        }
        else
        {
            Console.WriteLine("Nama: " + nama);
            Console.WriteLine("Jurusan: " + jurusan);
            Console.WriteLine("Nilai kamu A");
        }
    }
}

/// TAMBAHKAN NAMA, JURUSAN, DAN RANGE A SAMPAI E 0 SAMPAI 100