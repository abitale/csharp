using System;

namespace overriding
{
    class Overide
    {
        public int bilangan1, bilangan2;
        public void Bilangan(int angka1, int angka2)
        {
            bilangan1 = angka1;
            bilangan2 = angka2;
        }
        public virtual void PenjumlahanPerkalianDll()
        {
            Console.WriteLine("Overiding 1......------>>>>>>>");
            Console.WriteLine("Hasil penjumlahan angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 + bilangan2);
            Console.WriteLine("Hasil perkalian angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 * bilangan2);
        }
    }

    class Program : Overide
    {
        public override void PenjumlahanPerkalianDll()
        {
            Console.WriteLine("Overiding 2......------>>>>>>>");
            Console.WriteLine("Hasil pembagian angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 / bilangan2);
            Console.WriteLine("Hasil pengurangan angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 - bilangan2);
        }

        static void Main(string[] args)
        {
            Overide data = new Overide();
            data.Bilangan(10, 5);
            data.PenjumlahanPerkalianDll();
            data = new Program();
            data.Bilangan(20, 5);
            data.PenjumlahanPerkalianDll();
            Console.Read();
        }
    }
}