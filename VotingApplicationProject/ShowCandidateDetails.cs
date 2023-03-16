using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using Console = Colorful.Console;

namespace VotingApplicationProject
{
    class ShowCandidateDetails
    {
        public static void ShowCandidateData()
        {
            SortedDictionary<string, CandidateRegistration> Userdata = VotingApplication.data;
            JsonData.ShowDeserialData();
            int Count = VotingApplication.data.Count; // Counting total no. of records
            Console.WriteLine();
            if (Count < 1)
            {
                TableData.PrintSeparator();
                TableData.PrintRow("First Name", "Last Name", "Gender", "Email", "Contact", "Voted Party", "Voted Date", "Voted Time");
                TableData.PrintSeparator();
                Console.WriteLine("-------------------------------------------------- No Records Found ---------------------------------------",Color.Red);
            }
            else
            {
              
                TableData.PrintSeparator();
                TableData.PrintRow("First Name", "Last Name", "Gender", "Email", "Contact", "Voted Party", "Voted Date", "Voted Time");
                TableData.PrintSeparator();
                foreach (KeyValuePair<string, CandidateRegistration> user in Userdata)
                {
                    if (user.Value.SelcetedParty != "" && user.Value.SelcetedParty != null && user.Value.isDeleted !="deleted")
                    {
                        TableData.PrintRow(user.Value.AddFirstName, user.Value.AddLastName, user.Value.AddGender, user.Value.AddEmail, user.Value.AddContact, user.Value.SelcetedParty, user.Value.createdDate,user.Value.createdTime);
                        TableData.PrintSeparator();
                    }
                }


            }
        }
    }
}
