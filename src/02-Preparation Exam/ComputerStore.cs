using System;


namespace SoftUniCSharpMidExamPreparation
{
    class ComputerStore
    {
        static void Main()
        {
            
            double totalPrice = 0.0;
            bool isSpecial = false;
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if(input == "special")
                {
                    isSpecial = true;
                    break;
                }
                else if(input == "regular")
                {
                    break;
                }
                double priceOfNewPart = double.Parse(input);
                if (priceOfNewPart > 0)
                {
                    totalPrice += priceOfNewPart;
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                    
                }

            }
            
            if(totalPrice != 0)
            {
                double taxPrice = 0.2 * totalPrice;
                double finalPrice = totalPrice + taxPrice;
                if (isSpecial)
                {
                    finalPrice = (totalPrice + taxPrice) * 0.9;
                }
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:F2}$");
                Console.WriteLine($"Taxes: {taxPrice:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {finalPrice:F2}$");

            }
            else
            {
                Console.WriteLine("Invalid order!");
            }
        }
    }

}

