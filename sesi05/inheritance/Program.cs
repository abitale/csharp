using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            pesawat_tempur pswttempur = new pesawat_tempur();

            pesawat.nama = "Helly";
            pesawat.jumlahRoda = 3;
            pesawat.Ketinggian = "1000 kaki";
            pesawat.jumlahPenumpang = 3;
            pswttempur.nama = "AZ500TPU";
            pswttempur.jumlahPenumpang = 2;
            pswttempur.Ketinggian = "200 kaki";
            pswttempur.jumlahRoda = 5;

            pesawat.Terbang();
            pswttempur.terbang();
            Console.Read();
        }
    }
}
