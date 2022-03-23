using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            class_pesawat pesawat = new class_pesawat();
            pesawat.nama = "GARUDAKU";
            pesawat.Ketinggian = "3500k kaki";

            pesawat.Terbang();
            pesawat.SudahTerbang();
            Console.Read();
        }
    }
}
