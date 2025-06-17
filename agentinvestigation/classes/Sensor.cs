using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
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
        public bool CheckOne(List<string> weaknesses, string string_check_weaknesses)
        {

            for (int i = 0; i < weaknesses.Count; i++)
            {
                // הוא לא מזהה את המערך של החולשות  
                if (weaknesses.Contains(string_check_weaknesses))
                {

                    return true;
                }
            }
            return false;
        }

        //----------------------------------------------------------------------------------------

        public string Activate(List<string> weaknesses, List<string> sennsors)
        {
            int check_weaknesses = Convert.ToInt32(Console.ReadLine());
            string string_check_weaknesses = Sensors[check_weaknesses];


            int to_num_catchs = weaknesses.Count();
            int count = 0;
            for (int i = 0; i < to_num_catchs; i++)
            {
                bool check_one = CheckOne(weaknesses, string_check_weaknesses);
                //הכיתוב המקוצר של הביטוי האיף הזה  if הזה
                      if (check_one) count += 1;
            }


            string answer = (count == to_num_catchs) ? $"greate you sucssed catch all {count}/{to_num_catchs}"
                : $"we are sorry buy you sucssed catch only {count}/{to_num_catchs}";
            return answer;
        }
    }
}
