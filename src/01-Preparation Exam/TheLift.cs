using System;
using System.Linq;


namespace SoftuniCSharpMidExamPreparation
{
    class TheLift
    {
        static void Main()
        {
            int peopleWaitingForLift = int.Parse(Console.ReadLine());
            int[] peopleInEveryWagon = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isThereEmptySeat = false;
            for(int i = 0; i < peopleInEveryWagon.Length; i++)
            {
                while (peopleInEveryWagon[i] < 4 && peopleWaitingForLift > 0)
                {
                    peopleInEveryWagon[i]++;
                    peopleWaitingForLift--;
                }
            }
            for(int i = 0; i<peopleInEveryWagon.Length;i++)
            {
                if (peopleInEveryWagon[i]!=4)
                {
                    isThereEmptySeat=true;
                    break;
                }
            }
            if(peopleWaitingForLift == 0 && isThereEmptySeat)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            else if(peopleWaitingForLift > 0 &&  !isThereEmptySeat)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaitingForLift} people in a queue!");
            }
            Console.WriteLine(string.Join(" ",peopleInEveryWagon));
        }
    }
}
