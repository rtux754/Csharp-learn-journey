using System;
namespace MicrosoftLearn;

public static class ARR{
    public static void Jalankan() {
        // mencari index yang berawalkan huruf dan disimpan di index sementara
        string[] Cel = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
        foreach (string tempo in Cel) {
            if (tempo.StartsWith("B")) {
                Console.WriteLine(tempo);
            }
        }
    }
}