using System;

namespace MicrosoftLearn;
public static class IFtidak {
    public static void Jalankan() {
        Random dice = new ();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;
        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) { // || (or logic)
            if ((roll1 == roll2) && (roll2 == roll3)) {
                Console.Write("You rolled triples! +6 bonus total ");
                total += 6;
                Console.WriteLine(total);
            } else {
                Console.Write("You rolled doubles! +2 bonus total ");
                total += 2;
                Console.WriteLine(total);
                
            }
        }

        // Console.WriteLine((total > 18) ?"You Win" : "You Lose");

        if (total >= 18) {
            Console.WriteLine("You Win a new car");
        } else if (total >= 15) {
            Console.WriteLine("You Win a new laptop");
        } else if (total >= 10) {
            Console.WriteLine("You Win a pizza");
        } else {
            Console.WriteLine("You Lose");
        }

       
        // string message = "The quick brown fox jumps over the lazy dog.";
        // bool result = message.Contains("lazy");
        // Console.WriteLine(result);

        // if (message.Contains("fox")) {
            // Console.WriteLine("what adiowa");
        // } else {
            // Console.WriteLine("aew fwa");
        // }


    }
}