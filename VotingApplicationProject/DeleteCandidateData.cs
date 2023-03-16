using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using Console = Colorful.Console;

namespace VotingApplicationProject
{
    class DeleteCandidateData
    {
        public static void DeleteData()
        {
            Delete:
            SortedDictionary<string, CandidateRegistration> Userdata = VotingApplication.data;

            Console.Write("Enter Your Email First: ");
            string EmailId = Console.ReadLine();
            bool candidateExists = CheckCandidate.checkUserExists(EmailId);

            if (candidateExists)
            {   
                Upp:
                Console.WriteLine();
                Console.Write("Are you sure want to remove user ? (y/n): ");
                string DeleteChoice = Console.ReadLine();
                if (DeleteChoice == "y" || DeleteChoice == "yes")
                {
                    VotingApplication.data[EmailId].isDeleted = "deleted";
                    //VotingApplication.data.Remove(EmailId);
                    JsonData.ShowVotedData(VotingApplication.data);
                    Console.WriteLine();
                    Console.WriteLine("Data Deleted Successfully \u221A",Color.LightGreen);
                }
                else if (DeleteChoice == "n" || DeleteChoice == "no")
                {
                    Console.WriteLine("You selected no",Color.Yellow);
                    Console.WriteLine();
                    VotingInterfaceUI.VotingUserInterface();
                }
                else
                {
                    goto Upp;
                }
            }
            else
            {
                Console.WriteLine("User does not exists ;)", Color.Red);
                goto Delete;
            }
        }

    }
}
