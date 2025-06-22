using System;
using System.Linq;


namespace SoftUniCSharpRegularMidExam
{
    class Program
    {
        static void Main()
        {
            string[]friendList = Console.ReadLine().Split(", ").ToArray();
            int countOfBlacklistedNames = 0;
            int countOfLostNames = 0;
            string input;
            while ((input = Console.ReadLine()) != "Report")
            {
                string [] command = input.Split();
                if (command[0] == "Blacklist")
                {
                    string name = command[1];
                    bool isBlacklisted = false;
                    for (int i = 0; i < friendList.Length; i++)
                    {
                        if (friendList[i] == name)
                        {
                            Console.WriteLine($"{name} was blacklisted.");
                            friendList[i] = "Blacklisted";
                            countOfBlacklistedNames++;
                            isBlacklisted = true;
                            break;
                        }
                    }
                    if (!isBlacklisted)
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if (command[0] == "Error")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < friendList.Length)
                    {
                        if (friendList[index] != "Blacklisted" && friendList[index] != "Lost")
                        {
                            Console.WriteLine($"{friendList[index]} was lost due to an error.");
                            friendList[index] = "Lost";
                            countOfLostNames++;
                            
                        }
                    }
                }
                else if (command[0] == "Change")
                {
                    int index = int.Parse(command[1]);
                    string newName = command[2];
                    if(index >= 0 && index < friendList.Length)
                    {
                        Console.WriteLine($"{friendList[index]} changed his username to {newName}.");
                        friendList[index] = newName;
                        
                    }
                }
            }
            Console.WriteLine($"Blacklisted names: {countOfBlacklistedNames}");
            Console.WriteLine($"Lost names: {countOfLostNames}");
            Console.WriteLine(string.Join(" ", friendList));

        }
    }
}