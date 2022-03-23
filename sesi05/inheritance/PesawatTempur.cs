using System;


class pesawat_tempur : Pesawat
{
    public void terbang()
    {
        Console.WriteLine("Pesawat tempur dengan nama {0}, yang mempunyai {1}, sedang berada pada ketinggian {2} dengan membawa jumlah penumpang sebanyak {3} akan meledakan senjata", this.nama, this.jumlahRoda, this.Ketinggian, this.jumlahPenumpang);
    }
}
