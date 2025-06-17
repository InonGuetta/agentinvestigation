using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using agentinvestigation.classes;

namespace agentinvestigation.SERVICES
{
    internal class GeneralManagement
    {

        Sensor Sensor = new Sensor();
        List<string> choice_weaknesses = new List<string>();
        // כאן תתבצע ההצמדה של הערכים של הסוכן עם הערכים שהתקבלו מהמשתמש 


        //----------------------------------------------------------------------------------------
        // יצירה של החולשות של הסוכן 
        //----------------------------------------------------------------------------------------
        public int checkRankNum(string checkRank)
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
                choice_weaknesses.Add(Sensor.Sensors[rnd.Next(0, Sensor.Sensors.Length)]);
            }
            return choice_weaknesses;
        }
        //----------------------------------------------------------------------------------------




        //----------------------------------------------------------------------------------------
        // בדיקה ההצמדה של מכשירי הריגול לסוכן
        //----------------------------------------------------------------------------------------
        public bool CheckOne(List<string> to_cetch, string string_check_weaknesses)
        {
            for (int i = 0; i < to_cetch.Count; i++)
            {
                if (string_check_weaknesses == "// השלם כאן ")
                {
                    return true;
                }
 
            }
            return false;
        }
    
        public string Activate(List<string> to_cetch,int check_weaknesses)
        {
            string string_check_weaknesses = Sensor.Sensors[check_weaknesses];


            int to_num_catchs = to_cetch.Count();
            int count = 0;
            for (int i = 0; i < to_num_catchs; i++)
            {
                bool check_one = CheckOne(to_cetch, string_check_weaknesses);
                //  הכיתוב המקוצר של הביטוי האיף הזה  if הזה
                if (check_one) count += 1;
            }


            string answer = (count == to_num_catchs) ? $"greate you sucssed catch all {count}/{to_num_catchs}"
                : $"we are sorry buy you sucssed catch only {count}/{to_num_catchs}";
            return answer;
        }

    }
}
