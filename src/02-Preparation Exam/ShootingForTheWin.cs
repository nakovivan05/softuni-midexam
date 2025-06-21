using System;
using System.Linq;


namespace SoftUniCSharpMidExamPreparation
{
    class ShootingForTheWin
    {
        static void Main()
        {
            int[] targets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int countOfShotTargets = 0;
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);
                if (index >= 0 && index < targets.Length)
                {
                    if (targets[index] != -1)
                    {
                        int shotValue = targets[index];
                        targets[index] = -1;
                        countOfShotTargets++;
                        for (int i = 0; i < targets.Length; i++)
                        {
                            if (targets[i] != -1)
                            {
                                if (targets[i] > shotValue)
                                {
                                    targets[i] -= shotValue;
                                }
                                else
                                {
                                    targets[i] += shotValue;
                                }
                            }


                        }
                        
                    }
                }
            }
            Console.Write($"Shot targets: {countOfShotTargets} -> ");
            Console.WriteLine(string.Join(" ", targets));
        }
    }
}
