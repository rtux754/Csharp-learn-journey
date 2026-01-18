using System;

namespace MicrosoftLearn;
public static class Japanes {
    public static void Jalankan() {
        // Kon'nichiwa World
        Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
        //
        // To generate Japanese invoices
        // Nihon no seikyū-sho o seisei suru ni wa:
        Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
        // User command to run an application
        Console.WriteLine(@"~/fenrir/invoices/app.exe -j");
    }
}