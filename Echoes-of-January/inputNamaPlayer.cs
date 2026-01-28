using System;
namespace inputNamaPlayer;

public static class Pendukung {
    public static string AmbilNamaPlayer() {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("--Selamat Datang--\n");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write(">> NAMA KARAKTER:");
        Console.ResetColor();

        // meminta input nama dari player
        string inputNamaPlayer = Console.ReadLine()?.Trim()?? "";
        // Validasi input menggunakan return
        return string.IsNullOrWhiteSpace(inputNamaPlayer) ? "Pengembara" : inputNamaPlayer;
    }
}

