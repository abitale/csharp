using System;

class class_pesawat
{
    public string nama;
    private string ketinggian;
    public string Ketinggian
    {
        get { return ketinggian; }
        set { ketinggian = value; }
    }
    public void Terbang()
    {
        Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this.nama);
    }
    public void SudahTerbang()
    {
        Console.WriteLine("Pesawat sekarang berada pada ketinggian {0}", this.ketinggian);
    }
}
