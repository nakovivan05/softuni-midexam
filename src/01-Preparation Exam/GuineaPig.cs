using System;

namespace SoftuniCSharpMidExamPreparation
{
    class GuineaPig
    {
        static void Main()
        {
            double foodForMonth = double.Parse(Console.ReadLine());
            double hayForMonth = double.Parse(Console.ReadLine());
            double coverForMonth = double.Parse(Console.ReadLine());
            double guineaPigWeight = double.Parse(Console.ReadLine());
            bool isEmpty = false;
            for (int i = 1; i < 31; i++)
            {
                foodForMonth -= 0.3;
                if (foodForMonth <= 0)
                {
                    isEmpty = true;
                    Console.WriteLine("Merry must go to the pet store!");
                    break;
                }
                if (i % 2 == 0)
                {
                    hayForMonth = hayForMonth - 0.05 * foodForMonth;
                    if (hayForMonth <= 0)
                    {
                        isEmpty = true;
                        Console.WriteLine("Merry must go to the pet store!");
                        break;
                    }
                }
                if (i % 3 == 0)
                {
                    coverForMonth = coverForMonth - guineaPigWeight / 3;
                    if (coverForMonth <= 0)
                    {
                        isEmpty = true;
                        Console.WriteLine("Merry must go to the pet store!");
                        break;
                    }
                }
                
            }
            if (!isEmpty)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodForMonth:F2}, Hay: {hayForMonth:F2}, Cover: {coverForMonth:F2}.");
            }
        }
    }
}
