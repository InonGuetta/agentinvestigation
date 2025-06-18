using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agentinvestigation.classes
{
    internal class Agent
    {
        public string Name_Agent { get; private set; }
        public string Rank { get; private set; }
      
        //public string[] Sensors = { "audio", "hacking", "espionage", "infiltration" };
        public static List<string> choice_weaknesses { get; set; } = new List<string>();
        
       //----------------------------------------------------------------------------------------

        public Agent(string name, string rank)
        {
            this.Name_Agent = name;
            this.Rank = rank;
        }


        //----------------------------------------------------------------------------------------
        // יצירה של החולשות של הסוכן 
        // לכאורה נראה כבר כי שניהם בשימוש 
        //----------------------------------------------------------------------------------------
        public static int checkRankNum(string checkRank)
        {
            int num = 0;
            // בכל המסמך כאן תתיחחס רק אל זה 001
            // למה זה לא עובד
            if (checkRank == "zotar")
            {
                num = 2;
            }
            else if (checkRank == "mem_em")
            {
                num = 3;
            }
            else if (checkRank == "mem_pe")
            {
                num = 4;
            }
            else if (checkRank == "bachir")
            {
                num = 4;
            }
            return num;
        }
        //----------------------------------------------------------------------------------------
        private static readonly Random rnd = new Random();
        public List<string> creatWeaknesses(string checkRank)
        {

            choice_weaknesses.Clear();
            int num = checkRankNum(checkRank);
            for (int i = 0; i < num; i++)
            {
                choice_weaknesses.Add(Sensor.Sensors[rnd.Next(Sensor.Sensors.Length)]);
            }
            return choice_weaknesses;

        }
        //----------------------------------------------------------------------------------------

    }
}
