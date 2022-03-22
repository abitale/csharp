using System;

class Data1
{
    static void Main()
    {
        int[] aAngka = new int[5];
        string[] aNama = new string[] { "Joni", "Meri", "David" };
        object[] aObjek = { 20.33, "Lorem Ipsum", DateTime.Now, true, 'D' };

        for (int i = 0; i < 5; i++)
        {
            aAngka[i] = i + 1;
            Console.Write(aAngka[i] + " ");
        }

        Console.WriteLine();

        for (int i = 0; i < aNama.Length; i++)
        {
            Console.Write(aNama[i] + " ");
        }

        Console.WriteLine();

        for (int i = 0; i < aObjek.Length; i++)
        {
            Console.Write(aObjek[i] + " ");
        }

    }
}