using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using Console = Colorful.Console;

namespace VotingApplicationProject
{
    class CandidateRegistration
    {

        public static void NewUserRegistration()  //for adding new candidates
        {
            Console.WriteLine();
            //Console.WriteLine("****************************",Color.DarkBlue);
            Console.WriteLine("New Candidate Registeration: ",Color.LightSkyBlue);
            Console.WriteLine("****************************", Color.DarkBlue);

            Console.Write("Enter Your First Name: ");
            string FirstNameInp = Console.ReadLine();
            string FirstName = ValidationAll.ValidateFirstName(FirstNameInp);

            Console.Write("Enter Your Last Name: ");
            string LastNameInp = Console.ReadLine();
            string LastName = ValidationAll.ValidateLastName(LastNameInp);

            Console.Write("Enter Your Gender: ");
            string GenderInp = Console.ReadLine();
            string Gender = ValidationAll.ValidateGender(GenderInp);

            Console.Write("Enter your Email: ");
            string EmailInp = Console.ReadLine();
            string Email = ValidationAll.ValidateEmail(EmailInp);

            Console.Write("Enter Your Date of Birth ( DD/MM/YY ): ");
            string DobInp = Console.ReadLine();
            string Dob = ValidationAll.ValidateDob(DobInp);

            Console.Write("Enter Your Contact No: ");
            string ContactInp = Console.ReadLine();
            string Contact = ValidationAll.ValidateContact(ContactInp);

            Console.Write("Enter Your Address: ");
            string AddressInp = Console.ReadLine();
            string Address = ValidationAll.ValidateAddress(AddressInp);
            Console.WriteLine();
            Console.WriteLine("Candidate Registration Completed Successfully \u221A"); //Completed registration
            Console.WriteLine();

            confirmUserInput:
            Console.Write("Do you want to add the record to our File ? (y/n): ");
            
            string confirmRecord = Console.ReadLine();
            ValidationAll.validateRecord(confirmRecord);

            if (confirmRecord == "y" || confirmRecord == "yes")
            {
                Console.WriteLine();
                Console.WriteLine("Record Added Successfully \u221A ",Color.LightGreen);
                string createdOnDate = DateTime.Now.ToString("dd-MM-yyyy");                 //Audit fields
                string createdOnTime = DateTime.Now.ToString("hh:mm tt");

                CandidateData(FirstName, LastName, Gender, Email, Dob, Contact, Address, createdOnDate, createdOnTime);
               
            }
            else if (confirmRecord == "n" || confirmRecord == "no")
            {
                Console.WriteLine();
                Console.WriteLine("Registeration Cancelled :( ");
                VotingInterfaceUI.VotingUserInterface();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Input: Please enter a valid input ;) ");
                goto confirmUserInput;
            }

            //bool IsActive = true;
        }

        //public class AddCandidate
        //{


        //}


        public string AddFirstName { get; set; }
        public string AddLastName { get; set; } 
        public string AddGender { get; set; }

        public string AddEmail { get; set; }
        public string AddDob { get; set; }
        public string AddContact { get; set; }
        public string AddAddress { get; set; }
        public string createdDate { get; set; }
        public string createdTime { get; set; }

        public string SelcetedParty { get; set; }
        public string isDeleted { get; set; }

        public static void CandidateData(string UserFirstName , string UserLastName , string UserGender, string UserEmail, string UserDob ,string UserContact, string UserAddress, string UsercreatedDate, string UsercreatedTime)
        {
            CandidateRegistration CandidateObj = new CandidateRegistration();  //Creation of Object of AddCandidate class

            CandidateObj.AddFirstName = UserFirstName;
            CandidateObj.AddLastName = UserLastName;
            CandidateObj.AddGender = UserGender;
            CandidateObj.AddEmail = UserEmail;
            CandidateObj.AddDob = UserDob;
            CandidateObj.AddContact = UserContact;
            CandidateObj.AddAddress = UserAddress;
            CandidateObj.createdDate = UsercreatedDate;
            CandidateObj.createdTime = UsercreatedTime;
            //CandidateObj.SelcetedParty = selctedparty;

            InsertCandidateRecord.userData(CandidateObj, out string status);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(status);
            Console.WriteLine("----------------------------------------");
        }

        
    }
}
