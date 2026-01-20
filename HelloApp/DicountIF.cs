using System;

namespace MicrosoftLearn;

public static class Discount {
    public static void Jalankan() {
        // declaration new random object
        Random disc = new();
        int daysUntilDiscountExpiration = disc.Next(12);
        int discountPresentage = 0;
        Console.WriteLine(daysUntilDiscountExpiration);

        if (daysUntilDiscountExpiration == 0) {
            Console.WriteLine("Your subscription has expired");
        } else if (daysUntilDiscountExpiration == 1) {
            Console.WriteLine("Your subscription expires within a day!");
            discountPresentage = 20;
        } else if (daysUntilDiscountExpiration <= 5) {
            Console.WriteLine($"You subscription will expires in {daysUntilDiscountExpiration} days.");
            discountPresentage = 10;
        } else if(daysUntilDiscountExpiration <= 10) {
            Console.WriteLine("You subscription will expire so0. Renew now!");
        }

        if (discountPresentage > 0) {
            Console.WriteLine($"Renew now and save {discountPresentage}%!");
        }
    }
}