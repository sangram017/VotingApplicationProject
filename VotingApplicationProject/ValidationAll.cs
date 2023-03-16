using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Console = Colorful.Console;

namespace VotingApplicationProject
{
    class ValidationAll
    {
         static Regex regexFName = new Regex("^[a-zA-Z]*$");
         

        public static string ValidateFirstName(string Fname)          //method for firstname validation
        {
            Fname = Fname.Trim();
            if (string.IsNullOrEmpty(Fname) || string.IsNullOrWhiteSpace(Fname))
            {
                Console.WriteLine("First Name can't be null or empty ",Color.Red);
                Console.Write("Enter again: ");
                string _Fname = Console.ReadLine();
                return ValidateFirstName(_Fname);

            }
            else if (!regexFName.IsMatch(Fname))
            {
                Console.WriteLine("Invalid Name: Please enter a valid name", Color.Red);
                Console.Write("Enter again: ");
                string _Fname = Console.ReadLine();
                return ValidateFirstName(_Fname);
            }
            else if (Fname.Length < 3)
            {
                Console.WriteLine("First Name should be grater than 3 characters: ", Color.Red);
                Console.Write("Enter again: ");
                string _Fname = Console.ReadLine();
                return ValidateFirstName (_Fname);
            }
            return Fname;

        }

        static Regex regexLName = new Regex("^[a-zA-Z]*$");
        public static string ValidateLastName(string Lname)               //method for lastname validation
        {
            Lname = Lname.Trim();
            if(string.IsNullOrEmpty(Lname) || string.IsNullOrWhiteSpace(Lname))
            {
                Console.WriteLine("Last Name can't be null or empty ", Color.Red);
                Console.Write("Enter again: ");
                string _Lname = Console.ReadLine();
                return ValidateLastName(_Lname);
            }
            else if (!regexLName.IsMatch(Lname))
            {
                Console.WriteLine("Invalid Name: Please enter a valid name", Color.Red);
                Console.Write("Enter again: ");
                string _Lname = Console.ReadLine();
                return ValidateLastName(_Lname);
            }
            return Lname;
        }

        static Regex regexGender = new Regex(@"^([M|m]ale|[F|f]emale)$");
        public static string ValidateGender(string gender)            //method for gender validation
        {
            gender = gender.Trim();
            if (string.IsNullOrEmpty(gender) || string.IsNullOrWhiteSpace(gender))
            {
                Console.WriteLine("Gender can't be null or empty", Color.Red);
                Console.Write("Enter again: ");
                string _Gender = Console.ReadLine();
                return ValidateGender(_Gender);
            }
            else if (!regexGender.IsMatch(gender))
            {
                Console.WriteLine("Invalid Gender - Please enter Male or Female", Color.Red);
                Console.Write("Enter again: ");
                string _Gender = Console.ReadLine();
                return ValidateGender(_Gender);
            }
            return gender;
                
        }

        
        static Regex regexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        public static string ValidateEmail(string email)              //method for email validation
        {
            
            email = email.Trim();
            bool candidateExists = CheckCandidate.checkUserExists(email);

            if (string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Email can't be null or empty", Color.Red);
                Console.Write("Enter again: ");
                string _Email = Console.ReadLine();
                return ValidateEmail(_Email);
            }
            else if (!regexEmail.IsMatch(email))
            {
                Console.WriteLine("Invalid Email - Please enter a valid Email", Color.Red);
                Console.Write("Enter again: ");
                string _Email = Console.ReadLine();
                return ValidateEmail(_Email);
            }
            else if (candidateExists)
            {
                Console.WriteLine();
                Console.WriteLine("This email already exists",Color.Yellow);
                Console.Write("Enter again: ");
                string _Email = Console.ReadLine();
                return ValidateEmail(_Email);
            }
           
            return email;
        }

        static Regex regexDob = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
        public static string ValidateDob(string dob)              //method for date of birth validation
        {

            dob = dob.Trim();
            if(string.IsNullOrEmpty(dob) || string.IsNullOrWhiteSpace(dob))
            {
                Console.WriteLine("Date of birth can't be null or empty", Color.Red);
                Console.Write("Enter again: ");
                string _Dob = Console.ReadLine();
                return ValidateDob(_Dob);
            }
            else if (!regexDob.IsMatch(dob))
            {
                Console.WriteLine("Invalid Format - Please enter a valid Format", Color.Red);
                Console.Write("Enter again: ");
                string _Dob = Console.ReadLine();
                return ValidateDob(_Dob);
            }

            return dob;
            
        }

        static Regex regexCno = new Regex("^?[0-9]{7,14}$");
        public static string ValidateContact(string contact)              //method for contact validation
        {
            contact = contact.Trim();
            if (string.IsNullOrEmpty(contact) || string.IsNullOrWhiteSpace(contact))
            {
                Console.WriteLine("Contact no. can't be null or empty", Color.Red);
                Console.Write("Enter again: ");
                string _Contact = Console.ReadLine();
                return ValidateContact(_Contact);
            }
            else if (!regexCno.IsMatch(contact))
            {
                Console.WriteLine("Invalid Number - Contact no. should be grater than 7 numbers and less than 14 numbers:", Color.Red);
                Console.Write("Enter again: ");
                string _Contact = Console.ReadLine();
                return ValidateContact(_Contact);
            }
            return contact;
            
        }

        static Regex regexAddress = new Regex(@"^[A-Za-z0-9]+[_\-' ]+$");

        public static string ValidateAddress(string address)      //method for address validation
        {
            address = address.Trim();
            if (string.IsNullOrEmpty(address) || string.IsNullOrWhiteSpace(address))
            {
                Console.WriteLine("Address can't be null or empty ", Color.Red);
                Console.Write("Enter again: ");
                string _Address = Console.ReadLine();
                return ValidateAddress(_Address);
            }
            else if (!regexFName.IsMatch(address))
            {
                Console.WriteLine("Invalid Format: Please enter a valid Address format", Color.Red);
                Console.Write("Enter again: ");
                string _Address = Console.ReadLine();
                return ValidateAddress (_Address);
            }
            return address;
        }

        public static string validateRecord(string record) // validating user confirmation input
        {
            record = record.Trim().ToLower();
            return record;
        }
    }
}
