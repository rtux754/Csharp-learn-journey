using System;

namespace MicrosoftLearn;

public static class Mitid {
    public static void Jalankan() {
        string barang = "kopi hitam";
        int jumlah = 2;
        decimal hargaSatuan = 5000.50m;
        decimal total = jumlah * hargaSatuan;

        Console.WriteLine("=== STRUK BELANJA ===");

        // {0, -15} -> Parameter ke-0, rata kiri, lebar 15 karakter
        // {1, 10}  -> Parameter ke-1, rata kanan, lebar 10 karakter
        // {2, 12:C2} -> Parameter ke-2, rata kanan, lebar 12, format Currency (Mata Uang)

        //Console.WriteLine("{0, -15} {1, 10} {2, 12}", "Item, Qty, Harga");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("{0, -15} {1, 10} {2, 12:N0}", barang, jumlah, hargaSatuan);
        Console.WriteLine("{0, -15} {1, 10} {2, 12:N0}", "Total ", "", total);
    }
}