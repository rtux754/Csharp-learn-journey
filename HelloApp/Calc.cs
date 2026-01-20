// Calculate

using System;

namespace MicrosoftLearn{
	public static class Calc{
		public static void Jalankan(){
			// deklarasi nama siswa
			string studentName = "Sophia Johnson";
			string course1Name = "English 101";
			string course2Name = "Algebra 101";
			string course3Name = "Biology 101";
			string course4Name = "Computer Science I";
			string course5Name = "Psychology 101";
			

			int course1Credit = 3;
			int course2Credit = 3;
			int course3Credit = 4;
			int course4Credit = 4;
			int course5Credit = 3;

			// mendekalarasikan ranking A dan B
			int gradeA = 4;
			int gradeB = 3;

			int course1Grade = gradeA;
			int course2Grade = gradeB;
			int course3Grade = gradeB;
			int course4Grade = gradeB;
			int course5Grade = gradeA;

			int totalCreditHours = 0;
			totalCreditHours += course1Credit;
			totalCreditHours += course2Credit;
			totalCreditHours += course3Credit;
			totalCreditHours += course4Credit;
			totalCreditHours += course5Credit;

			int totalGradePoint = 0;
			totalGradePoint += course1Credit * course1Grade;
			totalGradePoint += course2Credit * course2Grade;
			totalGradePoint += course3Credit * course3Grade;
			totalGradePoint += course4Credit * course4Grade;
			totalGradePoint += course5Credit * course5Grade;

			decimal gradePointAverage = (decimal)totalGradePoint / (decimal)totalCreditHours;

			int leadingDigit = (int) gradePointAverage;
			int firstDigit = (int) (gradePointAverage * 10) % 10;
			int secondDigit = (int) (gradePointAverage * 100) % 10;

			Console.WriteLine($"\nStudent: {studentName}\n");
			Console.WriteLine("Course\t\t\t\tGrade\t\tCredit Hours");

			Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t\t{course1Credit}");
			Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t\t{course2Credit}");
			Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t\t{course3Credit}");
			Console.WriteLine($"{course4Name}\t{course4Grade}\t\t\t{course4Credit}");
			Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t\t{course5Credit}");

			Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{firstDigit}{secondDigit}");
		}
	}
}