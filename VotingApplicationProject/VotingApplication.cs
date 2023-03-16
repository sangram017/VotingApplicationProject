using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using Console = Colorful.Console;

namespace VotingApplicationProject
{
    class VotingApplication
    {

        public static SortedDictionary<string, CandidateRegistration> data = new SortedDictionary<string, CandidateRegistration>();
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Date : " + currentDate.ToString("MM/dd/yyyy HH:mm tt"), Color.Red);
            Console.WriteLine(("------------------------------------ \n Welcome To Our Voting Application : \n------------------------------------"), Color.LightSalmon);
            
            VotingInterfaceUI.VotingUserInterface();
        }
    }
}
