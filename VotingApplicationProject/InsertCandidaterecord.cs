using System;
using System.Collections.Generic;
using System.Text;

namespace VotingApplicationProject
{
    class InsertCandidateRecord
    {
        public static bool userData(CandidateRegistration obj, out string status)
        {
            
            string userFormKey = obj.AddEmail; // fetching email from Candidate object.

            // checking if candidate already exists with the same email or not.
            if(VotingApplication.data == null)
            {
                obj.SelcetedParty = "";
                VotingApplication.data.Add(userFormKey, obj);
                JsonData.ShowVotedData(VotingApplication.data);
                status = "Candidate has been registered successfully";
                return true;
            }
            else if (!VotingApplication.data.ContainsKey(userFormKey))
            {
                VotingApplication.data.Add(userFormKey, obj);
                JsonData.ShowVotedData(VotingApplication.data);
                status = "Candidate has been registered successfully";
                return true;
            }
            else
            {
                status = "Email with same Email already exists.";
                Console.WriteLine("Registeration Cancelled");
                return false;
            }
        }
    }
}
