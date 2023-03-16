using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using Console = Colorful.Console;

namespace VotingApplicationProject
{
    class EditCandidateData
    {
        public static void UserFetch()
        {
        Fetch:
            SortedDictionary<string, CandidateRegistration> Userdata = VotingApplication.data;     //fetching data from records

            Console.Write("Enter Your Email First: ");
            string EmailId = Console.ReadLine();
            bool candidateExists = CheckCandidate.checkUserExists(EmailId);


            if (candidateExists)
            {
                Console.WriteLine();
                Console.WriteLine("Candidate fetched \u221A ", Color.LightGreen);
                string firstName = VotingApplication.data[EmailId].AddFirstName;
                string lastName = VotingApplication.data[EmailId].AddLastName;
                string gender = VotingApplication.data[EmailId].AddGender;
                string dob = VotingApplication.data[EmailId].AddDob;
                string contact = VotingApplication.data[EmailId].AddContact;
                string address = VotingApplication.data[EmailId].AddAddress;

                UpdatedData(EmailId, firstName, lastName, gender, dob, contact, address);

            }
            else
            {
                Console.WriteLine("User does not exists :(", Color.Red);
                goto Fetch;
            }



        }

        public static void UpdatedData(string EmailId, string oldFname, string oldLname, string oldGender, string OldDob, string oldContact, string oldAddress)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Update Candidate Data");
            Console.WriteLine("---------------------");
            Console.Write("Previous First Name is: {0}, Enter New First Name: ", oldFname, Color.Yellow);
            string newFname = Console.ReadLine();
            newFname = newFname.Trim();
            string newFnameInp = ValidationAll.ValidateFirstName(newFname);

            if (string.IsNullOrEmpty(newFname) || string.IsNullOrWhiteSpace(newFname))
            {
                newFname = oldFname;
                Console.WriteLine();

            }


            Console.Write("Previous Last Name is: {0}, Enter New Last Name: ", oldLname, Color.Yellow);
            string newLname = Console.ReadLine();
            newLname = newLname.Trim();
            string newLnameInp = ValidationAll.ValidateLastName(newLname);
            if (string.IsNullOrEmpty(newLname) || string.IsNullOrWhiteSpace(newLname))
            {
                newLname = oldLname;
                Console.WriteLine();

            }

            Console.Write("Previous Gender is: {0}, Enter New Gender: ", oldGender, Color.Yellow);
            string newGender = Console.ReadLine();
            newGender = newGender.Trim();
            string newGenderInp = ValidationAll.ValidateGender(newGender);
            if (string.IsNullOrEmpty(newGender) || string.IsNullOrWhiteSpace(newGender))
            {
                newGender = oldGender;
                Console.WriteLine();

            }

            Console.Write("Previous Date of birth is: {0}, Enter New Date of birth: ", OldDob, Color.Yellow);
            string newDob = Console.ReadLine();
            newDob = newDob.Trim();
            string newDobInp = ValidationAll.ValidateDob(newDob);
            if (string.IsNullOrEmpty(newDob) || string.IsNullOrWhiteSpace(newDob))
            {
                newDob = OldDob;
                Console.WriteLine();

            }

            Console.Write("Previous Contact is: {0}, Enter New Contact no.: ", oldContact, Color.Yellow);
            string newContact = Console.ReadLine();
            newContact = newContact.Trim();
            string newContactInp = ValidationAll.ValidateContact(newContact);
            if (string.IsNullOrEmpty(newContact) || string.IsNullOrWhiteSpace(newContact))
            {
                newContact = oldContact;
                Console.WriteLine();

            }

            Console.Write("Previous Address is: {0}, Enter New Address: ", oldAddress, Color.Yellow);
            string newAddress = Console.ReadLine();
            newAddress = newAddress.Trim();
            string newAddressInp = ValidationAll.ValidateAddress(newAddress);
            if (string.IsNullOrEmpty(newAddress) || string.IsNullOrWhiteSpace(newAddress))
            {
                newAddress = oldAddress;
                Console.WriteLine();

            }


        confirmUpdateLabel:
            Console.WriteLine();
            Console.Write("Are you sure want to update details (y/n): ",Color.LightGreen);
            string confirmUpdate = Console.ReadLine();
            ValidationAll.validateRecord(confirmUpdate);
            if (confirmUpdate == "y" || confirmUpdate == "yes")
            {
                
                EditCandidateData.updateUserObj(EmailId, newFname, newLname, newGender, newDob, newContact, newAddress);
                JsonData.ShowVotedData(VotingApplication.data);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("User details has been updated successfully \u221A", Color.LightGreen);
                Console.WriteLine("-----------------------------------------");

            }
            else if (confirmUpdate == "n" || confirmUpdate == "no")
            {
                Console.WriteLine("----------------------",Color.Red);
                Console.WriteLine("Cancelled Updation", Color.Red);
                Console.WriteLine("----------------------", Color.Red);
            }
            else
            {
                Console.WriteLine("Invalid Selection: Please enter a valid option", Color.Red);
                goto confirmUpdateLabel;
            }
        }

        public static void updateUserObj(string EmailId, string newFname, string newLname, string newGender, string newDob, string newContact, string newAddress)
        {
            VotingApplication.data[EmailId].AddFirstName = newFname;
            VotingApplication.data[EmailId].AddLastName = newLname;
            VotingApplication.data[EmailId].AddGender = newGender;
            VotingApplication.data[EmailId].AddDob = newDob;                            //This method is for updating 
            VotingApplication.data[EmailId].AddContact = newContact;
            VotingApplication.data[EmailId].AddAddress = newAddress;
            
        }
    }
}


