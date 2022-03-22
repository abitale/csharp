using System;

class Data
{
    int a, b;
    string[] biodata = {
        "Nama: Nathaniel Alexander",
        "Jenis Kelamin: Laki-Laki",
        "Alamat: Puri Anjasmoro K2/21 Kota Semarang",
        "Hobi: Membaca",
        "Umur: 22 tahun",
        "Pekerjaan: IT Intern",
        "Jurusan: Teknik Informatika S1",
        "Nama Kampus: Dian Nuswantoro Semarang"
        };
    public void Segitiga(int opt, int loop)
    {
        int number = 64;
        if (opt == 0)
        {
            for (int x = 0; x < loop; x++)
            {
                for (a = (loop - x); a > 0; a--)
                    Console.Write(" ");

                for (a = 1; a <= x; a++)
                    Console.Write((char)(number + a));

                for (b = a; b > 0; b--)
                    Console.Write((char)(number + b));

                Console.WriteLine("");
            }
        }
        else
        {
            for (int i = 0; i < loop; i++)
            {

                for (a = (loop - i); a > 0; a--)
                    Console.Write(" ");

                for (a = 1; a <= i; a++)
                    Console.Write(a);

                for (b = a; b > 0; b--)
                    Console.Write(b);

                Console.WriteLine("");
            }
        }

    }

    public void Factorial(int number)
    {
        int result = 1;

        for (a = 1; a <= number; a++)
            result = a * result;

        Console.WriteLine("Factorial of " + number + ": " + result + "\n");
    }

    public void Reverse(int opt)
    {
        if (opt == 1)
        {
            Console.Write("\nInput Alphabets: ");
            string text = Console.ReadLine();
            if (!Int32.TryParse(text, out int n))
            {
                Console.Write("Reversed Alphabets: ");
                for (a = text.Length - 1; a >= 0; a--)
                    Console.Write(text[a]);
            }
            else
            {
                Console.WriteLine("\nInputan yang diberikan mengandung angka. Kembali ke menu.");
            }

        }
        else
        {
            Console.Write("\nInput Numbers: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Reversed Numbers: ");
            for (a = number.ToString().Length - 1; a >= 0; a--)
                Console.Write(number.ToString()[a]);
        }

    }

    public void Convert(int number)
    {
        string[] numberText = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string temp = number.ToString();

        for (a = 0; a < number.ToString().Length; a++)
            Console.Write(" " + numberText[(int.Parse(temp[a].ToString()) - 1)]);
    }

    public string[] getBiodata()
    {
        return biodata;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int menu = 0, input1;
        Data data = new Data();

        while (menu != 8)
        {
            Console.WriteLine("\n======= MENU =======");
            Console.WriteLine("1. Segitiga Alphabet");
            Console.WriteLine("2. Segitiga Angka");
            Console.WriteLine("3. Faktorial");
            Console.WriteLine("4. Balik Angka");
            Console.WriteLine("5. Balik Huruf");
            Console.WriteLine("6. Convert Angka");
            Console.WriteLine("7. Tentang Saya");
            Console.WriteLine("8. Keluar");
            Console.Write("Pilih Menu: ");
            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    {
                        Console.Write("\nMasukan Range Angka: ");
                        input1 = int.Parse(Console.ReadLine());
                        data.Segitiga(0, input1);
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        Console.Write("\nMasukan Range Angka: ");
                        input1 = int.Parse(Console.ReadLine());
                        data.Segitiga(1, input1);
                        Console.ReadLine();
                        break;
                    }
                case 3:
                    {
                        Console.Write("\nMasukan Angka: ");
                        input1 = int.Parse(Console.ReadLine());
                        data.Factorial(input1);
                        Console.ReadLine();
                        break;
                    }
                case 4:
                    {
                        data.Reverse(0);
                        Console.ReadLine();
                        break;
                    }
                case 5:
                    {
                        data.Reverse(1);
                        Console.ReadLine();
                        break;
                    }
                case 6:
                    {
                        Console.Write("\nMasukan Angka: ");
                        input1 = int.Parse(Console.ReadLine());
                        data.Convert(input1);
                        Console.ReadLine();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine();
                        foreach (string bio in data.getBiodata())
                            Console.WriteLine(bio);
                        Console.ReadLine();
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("\nTerimakasih telah menggunakan program ini!\n");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("\nAngka yang anda inputkan salah, silahkan coba lagi.");
                        Console.ReadLine();
                        break;
                    }
            }
        }

    }
}
