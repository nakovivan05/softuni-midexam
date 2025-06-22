using System;


namespace SoftUniCSharpRegularMidExam
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceForPackageOfFlour = double.Parse(Console.ReadLine());
            double priceForSingleEgg = double.Parse(Console.ReadLine());
            double priceForSingleApron = double.Parse(Console.ReadLine());
            double finalPriceForFlourPackages = (countOfStudents - countOfStudents / 5) * priceForPackageOfFlour;
            double finalPriceForAprons = Math.Ceiling(countOfStudents * 1.2) * priceForSingleApron;
            double finalPriceForEggs = countOfStudents * 10 * priceForSingleEgg;
            double totalPrice = finalPriceForAprons + finalPriceForEggs + finalPriceForFlourPackages;
            if (totalPrice <= budget)
            {
                Console.WriteLine($"Items purchased for {totalPrice:F2}$.");
            }
            else
            {
                Console.WriteLine($"{(totalPrice - budget):F2}$ more needed.");
            }
        }
    }
}
