using System;

namespace overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Overloading data = new Overloading();
            data.print("Foxy");
            data.print(1641231231);
            Console.Read();
        }
    }
}
