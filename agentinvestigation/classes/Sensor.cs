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
                


        //----------------------------------------------------------------------------------------
        // בדיקה ההצמדה של מכשירי הריגול לסוכן
        //----------------------------------------------------------------------------------------

        // לכאן 001 
        public static string Activate(List<string> weaknesses, List<string> sennsors )
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

    }
}
