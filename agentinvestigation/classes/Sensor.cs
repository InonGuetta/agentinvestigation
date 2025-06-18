using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace agentinvestigation.classes
{
    internal class Sensor
    {
        public static readonly string[] Sensors = { "audio","hacking","espionage","infiltration"};


        // יצירת מתודה שהסנסור הוא יכול לפעול רק 3 פעמים 

        // weaknesses = מערך החולשות של הסוכן 
        // string_check_weaknesses = מערך הניחושים שהמשתמש הזין 

        // List<string> weaknesses, string string_check_weaknesses



        //----------------------------------------------------------------------------------------
        // בדיקה ההצמדה של מכשירי הריגול לסוכן
        // הבדיקה של ההצמדה צריכה להיות עם מילון
        //----------------------------------------------------------------------------------------

        // לכאן 001 
        public string Activate(List<string> weaknesses, List<string> sennsors )
        {
            

            for (int i = 0; i < weaknesses.Count; i++)
            {
                for (int j = 0; j < sennsors.Count; j++)
                {
                    if (sennsors[j] == weaknesses[i])
                    {
                        sennsors[j] = "-";
                    }
                }
            }

            int length = sennsors.Count();
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (sennsors[i] == "-") count += 1;
            }

            // למה הערכים כאן עולים בכל הרצה עוד ועוד ועוד 
            string answer = (count == length) ? $"greate you sucssed catch all {count}/{length}"
            : $"we are sorry buy you sucssed catch only {count}/{length}";

            return answer;
        }

        //----------------------------------------------------------------------------------------

        //public string Activate(List<string> weaknesses, List<string> sennsors)
        //{
        //int check_weaknesses = Convert.ToInt32(Console.ReadLine());
        //string string_check_weaknesses = Sensors[check_weaknesses];


        //int to_num_catchs = weaknesses.Count();
        //int count = 0;
        //for (int i = 0; i < to_num_catchs; i++)
        //    {
        //        bool check_one = CheckOne(weaknesses, sennsors);
        //        //הכיתוב המקוצר של הביטוי האיף הזה  if הזה
        //              if (check_one) count += 1;
        //    }

        //string answer = (count == to_num_catchs) ? $"greate you sucssed catch all {count}/{to_num_catchs}"
        //    : $"we are sorry buy you sucssed catch only {count}/{to_num_catchs}";
        //    return answer;
        //}
    }
}
