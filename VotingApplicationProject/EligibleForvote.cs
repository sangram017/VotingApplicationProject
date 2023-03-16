using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

using Console = Colorful.Console;

namespace VotingApplicationProject
{
    class EligibleForvote
    {
       
        public static void EligibleForVoting()
        {
        Eligible:

            SortedDictionary<string, CandidateRegistration> Userdata = VotingApplication.data;

            Console.Write("Enter Your Email First: ");
            string EmailId = Console.ReadLine();
            bool candidateExists = CheckCandidate.checkUserExists(EmailId);


        
            if (candidateExists)
            {
                    Console.WriteLine();

                    string[] dobData = VotingApplication.data[EmailId].AddDob.Split("/"); //splits the year and stores it in the array

                /*string[] dobData = user.Value.AddDob.Split("/");*/

                if (Convert.ToInt32(dobData[2]) < (DateTime.Now.Year - 18)) //checking for eligibility
                {
                        System.Console.WriteLine("You are Eligible for voting \u221A , Please choose Option 3 for voting ", Color.LightGreen);

                }
                 else
                 {
                        System.Console.WriteLine("Not eligible for voting and will be eligible after {0}{1}",18 - ( DateTime.Now.Year - Convert.ToInt32(dobData[2]))," years",Color.Red);
                 }
                
                
            }
            else
            {
                Console.WriteLine("Enter a valid email",Color.Red);
                goto Eligible;
            }



        }
    }
    public class CheckCandidate
    {

        public static bool checkUserExists(string fieldname)
        {
            bool result = VotingApplication.data.ContainsKey(fieldname);
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
