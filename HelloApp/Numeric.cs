// File materi kedua

using System;

namespace MicrosoftLearn{
	public static class MateriDasar{
		public static void Jalankan(){
			Console.WriteLine("\n\n=======================");
			Console.WriteLine("Ini adalah file berbeda\n\n");
			int firstNumber = 12;
			int secondNumber = 7;
			string firstName = "Yu";
			int widgetSold = 7;
			Console.WriteLine(firstNumber + secondNumber+"\n");
			Console.WriteLine(firstName + " sold " + (widgetSold + 7) + " widgets.");
			

			int sum = 7 + 5;
			int difference = 7 + 5;
			int product = 7 * 5;
			int quotient = 7 / 5;
			Console.WriteLine("Sum: " + sum);
			Console.WriteLine("Difference: " + difference);
			Console.WriteLine("Product: " + product);
			Console.WriteLine("Quotien: " + quotient);

			decimal DecimalQuotien = 7.0m / 5;
			Console.WriteLine($"DecimalQuotien: {DecimalQuotien}");

			// Casting Data
			int first = 7;
			int second = 5;
			decimal Quotien = (decimal)first / (decimal)second;
			Console.WriteLine(Quotien);

			// Modulus
			Console.WriteLine($"Modulus of 200 % 5: {200 % 5}");
			Console.WriteLine($"Modulus of 7 % 5: {7 % 5}");
		}
	}
}
