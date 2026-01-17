// Tantangan Konversi Suhu
// File ke 5

using System;

namespace MicrosoftLearn{
	public static class Konvers{
		public static void Jalankan(){
			int fahrenheit = 94;
			decimal celciuss = (fahrenheit - 32m) * (5m/9m);
			Console.WriteLine($"\nTemperature is {celciuss} Celcius.");
			// Or
			/* Console.WriteLine("Temperature is " + celciuss + " Celcius."); */
		}
	}
}