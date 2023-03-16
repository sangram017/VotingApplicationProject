using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using Console = Colorful.Console;

namespace VotingApplicationProject
{
    class ExitApp
    {
        public static void ExitApplication()
        {
        Confirmexit: // creating label if user enter wrong input.
            Console.WriteLine();
            Console.Write("Are you sure want to exit? (y/n): ",Color.Red);
            string ConfirmExit = Console.ReadLine();
            ConfirmExit = ValidationAll.validateRecord(ConfirmExit); // returning  validated user input

            if (ConfirmExit == "y" || ConfirmExit == "yes")
            {
                Console.WriteLine();
                Console.WriteLine("Thank you user , Visit again :) ");
                Environment.Exit(1); // closing Application
            }
            else if (ConfirmExit == "n" || ConfirmExit == "no")
            {
                VotingInterfaceUI.VotingUserInterface(); // Redirecting again to UI
            }
            else
            {
                Console.WriteLine("Invalid input: Please enter a valid option.",Color.Red);
                goto Confirmexit; // using goto statment as loop alternative to get correct user input.
            }
        }
    }
}
