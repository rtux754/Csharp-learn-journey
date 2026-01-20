using System;

namespace MicrosoftLearn;

public static class ObjectMateri{
    public static void Jalankan(){
        //Random dice = new ();
        //int roll1 = dice.Next();
        //int roll2 = dice.Next(101);
        //int roll3 = dice.Next(50, 101);
        //
        //Console.WriteLine($"First roll: {roll1}"); 
        ///*the method will return values ranging from 0 to 2,147,483,647, which is the maximum value an int can store.*/
        //
        //Console.WriteLine($"Second roll: {roll2}");
        ///* specifies the maximum value as an upper boundary, so in this case, you can expect a random value between 0 and 100.*/        
        //
        //Console.WriteLine($"Third roll: {roll3}");
        ///*method specifies both the minimum and maximum values,*/
        
        // membandingkan dua variabel untuk mencari pemilik value terbesar
        int firstValue = 500;
        int secondValue = 600;
        int largerValue = Math.Max(firstValue, secondValue);
        Console.WriteLine(largerValue);
    }
}