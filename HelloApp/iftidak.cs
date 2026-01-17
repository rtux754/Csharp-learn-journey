using System;

namespace MicrosoftLearn;
public static class IFtidak {
    public static void Jalankan() {
        //Random dice = new ();

        //int roll1 = dice.Next(1, 7);
        //int roll2 = dice.Next(1, 7);
        //int roll3 = dice.Next(1, 7);

        //int total = roll1 + roll2 + roll3;
        //Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        //if (total > 14) {
        //    Console.WriteLine("You Win");
        //} else {
        //    Console.WriteLine("You Lose");
        //}

        string message = "The quick brown fox jumps over the lazy dog.";
        bool result = message.Contains("lazy");
        Console.WriteLine(result);

        if (message.Contains("fox")) {
            Console.WriteLine("what adiowa");
        } else {
            Console.WriteLine("aew fwa");
        }
    }
}