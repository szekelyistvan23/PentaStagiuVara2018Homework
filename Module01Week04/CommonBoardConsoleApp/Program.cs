﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonBoardLibrary;


namespace CommonBoardConsoleApp
{
    class Program

    {
        static Board localBoard;
        static Account george;
        static void Main(string[] args)
        {
            localBoard = new Board();
            // Right now you can't register as a user from the console, because data isn't saved to disk
            george = new Account("George", "Breaza07", "george@gmail.com", DateTime.Now, "George", "Bularca", new DateTime(1985,3,14));
            
            while (true)
            {
                DisplayChoices();

                Console.Write("Your option is: ");
                int option = 0;
                int.TryParse(Console.ReadLine(), out option);

                Console.WriteLine();

                switch (option)
                {
                    case 1:
                        localBoard.ListMessages();
                        break;
                    case 2:
                        AddMessage();
                        break;
                    case 3:
                        DeleteMessage();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again!");
                        break;
                }

                Console.WriteLine();
            }
        }

        private static void DisplayChoices()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Display all messages");
            Console.WriteLine("2 - Add a message");
            Console.WriteLine("3 - Delete message by id");
            Console.WriteLine("4 - Exit");
        }

        private static void AddMessage()
        {
            Console.WriteLine("Enter your message:");
            string message = Console.ReadLine();
            localBoard.AddMessage(message, george);
            Console.WriteLine("");
        }

        private static void DeleteMessage()
        {
            Console.WriteLine("Enter message id: ");
            string text = Console.ReadLine();
            int id = int.Parse(text);

            if (localBoard.DeleteMessage(id) == true)
            {
                Console.WriteLine("Message removed from the board.");
            } else
            {
                Console.WriteLine("Invalid message id!");
            }
        }
    }
}
