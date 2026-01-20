using System;

namespace MicrosoftLearn;

public static class Ary {
    public static void Jalankan() {
        // string[] fraudulentOrderIDs = new string[4];
        // fraudulentOrderIDs[0] = "I can hear your voice";
        // fraudulentOrderIDs[1] = "But i can't comes";
        // fraudulentOrderIDs[2] = "Cause i afraid.";
        // fraudulentOrderIDs[3] = "I love Genshin Impact Forever";

        // Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        // Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        // Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
        // Console.WriteLine($"Fourth: {fraudulentOrderIDs[3]}");

        // fraudulentOrderIDs[2] = "Cause you actually can do it";
        // Console.WriteLine($"First timpa: {fraudulentOrderIDs[2]}");

        // string[] fraudulentOrderIDs = ["Abs", "GSEDdsa", "aArw", "Asauer"]; // [] this is modern syntax
        // string[] OrderIDSSSASW = {"ASwe", "awfe", "sISAhueis"}; // {} older syntax but both can use

        // Console.WriteLine($"First {fraudulentOrderIDs[0]}");
        // Console.WriteLine($"Second {fraudulentOrderIDs[1]}");
        // Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        // Console.WriteLine($"First: {OrderIDSSSASW[0]}");
        // Console.WriteLine($"Second: {OrderIDSSSASW[1]}");
        // Console.WriteLine($"Third: {OrderIDSSSASW[2]}");

        // Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
        // Console.WriteLine($"There are {OrderIDSSSASW.Length} fraudulent orders to process.");

        // string[] names = ["Kur", "Sukur", "Karnia"];
        // foreach (string name in names) {
        //     Console.WriteLine(name);
        // }

        int[] Inventory = [200, 300, 700, 330, 875];
        int sum = 0; // untuk menyimpan jumlah item yang dimiliki
        int bin = 0; // untuk menunjukkan jumlah item kategori yang siap dikemas
        // perulangan foreach dikhususkan untuk Array
        foreach (int items in Inventory) {
            sum += items; // items sebagai wadah array sementara
            bin++; // menunjukkan 
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        }
        Console.WriteLine($"We have {sum} in inventroy");
    }
}