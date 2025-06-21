using System;
using System.Linq;
using System.Collections.Generic;


namespace SoftUniCSharpMidExamPreparation
{
    class MemoryGame
    {
        static void Main()
        {
            List<string> ints = Console.ReadLine().Split(' ').ToList();
            int numberOfMoves = 0;
            bool isSucceed = false;
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                numberOfMoves++;
                string[] twoIntegers = input.Split();
                int firstIndex = int.Parse(twoIntegers[0]);
                int secondIndex = int.Parse(twoIntegers[1]);
                if (firstIndex == secondIndex || (firstIndex < 0 || firstIndex >= ints.Count) || (secondIndex < 0 || secondIndex >= ints.Count))
                {
                    string add = $"-{numberOfMoves}a";
                    ints.Insert(ints.Count / 2, add);
                    ints.Insert(ints.Count / 2, add);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else
                {
                    if (ints[firstIndex] == ints[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {ints[firstIndex]}!");
                        if (firstIndex > secondIndex)
                        {
                            ints.RemoveAt(firstIndex);
                            ints.RemoveAt(secondIndex);
                        }
                        else
                        {
                            ints.RemoveAt(secondIndex);
                            ints.RemoveAt(firstIndex);
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                if(ints.Count == 0)
                {
                    Console.WriteLine($"You have won in {numberOfMoves} turns!");
                    isSucceed = true;
                    break;
                }
                
            }
            if(!isSucceed)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ",ints));
            }
        }
    }
}
