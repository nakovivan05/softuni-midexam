using System;
using System.Linq;
using System.Collections.Generic;


namespace SoftuniCSharpMidExamPreparation
{
    class MovingTarget
    {
        static void Main()
        {
            List <int> targets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = "";
            while((input = Console.ReadLine()) != "End")
            {
                string [] command = input.Split();
                if (command[0] == "Shoot")
                {
                    int index = int.Parse(command[1]);
                    int power = int.Parse(command[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (command[0] == "Add")
                {
                    int index = int.Parse (command[1]);
                    int value = int.Parse(command[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command[0] == "Strike")
                {
                    int index = int.Parse(command[1]);
                    int radius = int.Parse(command[2]);
                    int start = index - radius;
                    int end = index + radius;
                    if(start >= 0 && end <= targets.Count)
                    {
                        
                        for(int i = end; i >= start; i--)
                        {
                            targets.RemoveAt(i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }


                }

            }
            Console.WriteLine(string.Join('|',targets));
        }
    }
}

