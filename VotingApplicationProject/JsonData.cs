using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace VotingApplicationProject
{
    class JsonData
    {
        public static string path = @"C:\Users\sangr\Documents\Projects\VotingUsers.txt";

        public static void ShowVotedData(SortedDictionary<string, CandidateRegistration> tdata)
        {
            if (!File.Exists(path))        //checks file exists or not
            {
                File.Create(path);
            }
            StreamWriter sw = new StreamWriter(path);
            string jsonFile = JsonConvert.SerializeObject(tdata, (Newtonsoft.Json.Formatting)System.Xml.Formatting.Indented);

            sw.WriteLine(jsonFile);
            sw.Close();
        }

        public static void ShowDeserialData()
        {
            if (File.Exists(path))
            {
                StreamReader sw = new StreamReader(path);
                SortedDictionary<string, CandidateRegistration> jsonSave = JsonConvert.DeserializeObject<SortedDictionary<string, CandidateRegistration>>(File.ReadAllText(path));
                if (jsonSave == null)
                {
                    VotingApplication.data.Clear();
                }
                else
                {
                    VotingApplication.data = jsonSave;

                }
                sw.Close();
            }
        }
    }
}
