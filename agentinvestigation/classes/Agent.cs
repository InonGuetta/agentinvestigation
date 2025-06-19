using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace agentinvestigation.classes
{
    internal class Agent
    {
        public string Name_Agent { get; private set; }
        public string Rank { get; private set; }
      

        // בגלל שאני רוצה שלכל מופע יהיה את החולשות שלו
        // אז לא שייך שזה הוא 
        public List<string> choice_weaknesses { get; set; } = new List<string>();
        
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
        // למה הערכים הרנדומליים הם כמעת ולא באמת רנדומליים כלומר הם מאוד חוזריים על עצמם 
        private static readonly Random rnd = new Random();
        // לשנות את הפונקצייה ל void
        public List<string> improveRandon()
        {
            List<string> improveRandon = new List<string>();
            for (int i= 0; i < 15;i++)
            {
                improveRandon.AddRange(Sensor.Sensors);
            }
            return improveRandon;
        }

       // על מנת ליצור רנדומליות גבוהה יותר אנו נשתמש ב 
        public List<string> creatWeaknesses(string checkRank)
        {

            choice_weaknesses.Clear();
            int num = checkRankNum(checkRank);

            List<string> to_choice = improveRandon();
            for (int i = 0; i < num; i++)
            {
                
                choice_weaknesses.Add(to_choice[rnd.Next(Sensor.Sensors.Length)]);
            }
            return choice_weaknesses;

        }
        //----------------------------------------------------------------------------------------

    }
}
