using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using Console = Colorful.Console;

namespace VotingApplicationProject
{
    class ApplyVote
    {
        public static void VotingApply()
        {
        Email:
            SortedDictionary<string, CandidateRegistration> Userdata = VotingApplication.data;

            Console.Write("Enter Your Email First: ");
            string EmailId = Console.ReadLine();
            bool candidateExists = CheckCandidate.checkUserExists(EmailId);


                if (candidateExists)
                {


                    if (VotingApplication.data[EmailId].SelcetedParty == null)
                    {
                        Console.WriteLine();
                        string[] dobData = VotingApplication.data[EmailId].AddDob.Split("/");   //splits the year and stores it in the array

                         if (Convert.ToInt32(dobData[2]) < (DateTime.Now.Year - 18)) //checking for eligibility
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter choice of One of these parties to Vote : ");
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("BJP", Color.Aqua);

                            Console.WriteLine("AAP", Color.Aqua);

                            Console.WriteLine("CONGRESS", Color.Aqua);

                            Console.WriteLine("ORION", Color.Aqua);

                            Console.WriteLine("AZAD", Color.Aqua);


                            Select:
                            Console.Write("Select an option: ");
                            string SelectedChoiceparty = Console.ReadLine();

                            if (SelectedChoiceparty == "BJP" || SelectedChoiceparty == "bjp" || SelectedChoiceparty == "AAP" || SelectedChoiceparty == "aap" || SelectedChoiceparty == "CONGRESS" || SelectedChoiceparty == "congress" || SelectedChoiceparty == "ORION" || SelectedChoiceparty == "orion" || SelectedChoiceparty == "AZAD" || SelectedChoiceparty == "azad")
                            {
                                VotingApplication.data[EmailId].SelcetedParty = SelectedChoiceparty;
                                Console.WriteLine("Your vote added Successfully , Thank you for voting :)", Color.LightGreen);
                                JsonData.ShowVotedData(VotingApplication.data);
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid choice: ", Color.Red);
                                goto Select;
                            }



                         }
                         else
                         {
                            System.Console.WriteLine("Not eligible for voting and will be eligible after {0}{1}", 18 - (DateTime.Now.Year - Convert.ToInt32(dobData[2])), " years", Color.Red);
                         }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Candidate already voted , to vote enter a new email", Color.Yellow);
                        VotingInterfaceUI.VotingUserInterface();
                    }

                }
                else
                {
                    Console.WriteLine("Email not found ", Color.Red);
                    goto Email;
                }
            

            

        
        

        }
    
    }
}
