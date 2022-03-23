using System;

class Overloading
{
    public string nama;
    public double nomorTelepon;
    public void print(string nama)
    {
        this.nama = nama;
        Console.WriteLine("Namanya adalah: {0}", this.nama);
    }
    public void print(double nomorTelepon)
    {
        this.nomor_telepon = nomorTelepon;
        Console.WriteLine("Nomor HP: {0}", this.nomorTelepon);
    }
}