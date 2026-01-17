// file ke tiga operator penugasan
using System;

namespace MicrosoftLearn{
	public static class OPenugasan{
		public static void Jalankan(){
			Console.WriteLine("===========================");
			Console.WriteLine("\tOperator Penugasan\n");

			int num = 1;

			num  = num + 1;
			Console.WriteLine("num = num + 1 : " + num);

			num+= 3;
			Console.WriteLine("num+= 3 : " + num);

			num++;
			Console.WriteLine("num++ : " + num);

			num--;
			Console.WriteLine("num-- : " + num);

			num -= 3;
			Console.WriteLine("num -= 3 : " + num);

			num *= 4;
			Console.WriteLine("num *= 4 : " + num);
		}
	}
}