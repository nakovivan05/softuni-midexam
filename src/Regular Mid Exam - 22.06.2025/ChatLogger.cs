using System;
using System.Linq;
using System.Collections.Generic;


namespace SoftUniCSharpRegularMidExam
{
    class Program
    {
        static void Main()
        {
            List<string> chat = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                if (command[0] == "Chat")
                {
                    string message = command[1];
                    chat.Add(message);
                }
                else if (command[0] == "Delete")
                {
                    string message = command[1];
                    if (chat.Contains(message))
                    {
                        chat.Remove(message);
                    }
                }
                else if (command[0] == "Edit")
                {
                    string message = command[1];
                    string editedMessage = command[2];
                    if (chat.Contains(message))
                    {
                        for (int i = 0; i < chat.Count; i++)
                        {
                            if (chat[i] == message)
                            {
                                chat[i] = editedMessage;
                                break;
                            }
                        }
                    }
                }
                else if(command[0] == "Pin")
                {
                    string message = command[1];
                    for (int i = 0; i < chat.Count; i++)
                    {
                        if (chat[i] == message)
                        {
                            chat.Add(chat[i]);
                            chat.RemoveAt(i);
                            break;
                        }
                    }
                }
                else if(command[0] == "Spam")
                {
                    for(int i = 1; i < command.Length; i++)
                    {
                        chat.Add(command[i]);
                    }
                }
            }
            foreach(string message in chat)
            {
                Console.WriteLine(message);
            }
        }
    }
}