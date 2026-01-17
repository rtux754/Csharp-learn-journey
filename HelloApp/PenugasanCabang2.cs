// Penugasan Cabang 2
// File ke 4

using System;

namespace MicrosoftLearn{
	public static class OPsecond{
		public static void Jalankan(){
			Console.WriteLine("\n=================================");
			Console.WriteLine("Ini adalah operator penugasan file ke 4\n");

			int value = 3;
			value++;
			Console.WriteLine($"Fist: {value}");
			Console.WriteLine($"Second: {value++}");
			Console.WriteLine($"Third: {++value}");
			Console.WriteLine($"Fourth: {++value}");
		}
	}
}