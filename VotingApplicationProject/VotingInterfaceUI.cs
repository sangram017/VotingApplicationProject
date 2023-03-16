using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console; //For colouring the console texts

namespace VotingApplicationProject
{
    class VotingInterfaceUI
    {

        public static void VotingUserInterface()
        {

            JsonData.ShowDeserialData();
            Console.WriteLine();
            Console.WriteLine("Hello User , Please select Among these: ",Color.MediumTurquoise);
            Console.WriteLine();
            Console.WriteLine("1.Register Candidate: ", Color.Aqua);
            Console.WriteLine("2.Eligible For Voting: ",  Color.Aqua);
            Console.WriteLine("3.Apply Vote: ",  Color.Aqua);
            Console.WriteLine("4.Show Voting Candidates: ",  Color.Aqua);
            Console.WriteLine("5.Edit Candidate Data: ",  Color.Aqua);
            Console.WriteLine("6.Delete Candidate Data: ", Color.Aqua);
            Console.WriteLine("7.Exit Application ",  Color.Aqua);
            Console.WriteLine();
            VotingUserChoice();

        }
        public static void VotingUserChoice() //method for selecting the choice
        {
            Phase:
            Console.Write("Select an option: ");
            bool error = int.TryParse(Console.ReadLine(), out int SelectedChoice);
            switch (SelectedChoice)
            {
                case 1:
                    CandidateRegistration.NewUserRegistration();
                    VotingUserInterface();
                    break;
                case 2:
                    EligibleForvote.EligibleForVoting();
                    VotingUserInterface();
                    break;
                case 3:
                    ApplyVote.VotingApply();
                    VotingUserInterface();
                    break;
                case 4:
                    ShowCandidateDetails.ShowCandidateData();
                    VotingUserInterface();
                    break;
                case 5:
                    EditCandidateData.UserFetch();
                    VotingUserInterface();
                    break;
                case 6:
                    DeleteCandidateData.DeleteData();
                    VotingUserInterface();
                    break;
                case 7:
                    ExitApp.ExitApplication();
                    VotingUserInterface();
                    break;
                default:
                    Console.WriteLine("Enter a valid option: ",Color.Red);
                    goto Phase;
            }
        }
    }
}
