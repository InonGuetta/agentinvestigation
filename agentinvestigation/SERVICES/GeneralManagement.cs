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
        // כאן תתבצע ההצמדה של הערכים של הסוכן עם הערכים שהתקבלו מהמשתמש 


        //----------------------------------------------------------------------------------------
        public int checkRank()
        {
            int num = 0;
            // בכל המסמך כאן תתיחחס רק אל זה 001
            // למה זה לא עובד
            if (agentZotar.Rank == "zotar")
            {
                num = 2;
            }
            else if (this.Rank == "mem_em")
            {
                num = 3;
            }
            else if (this.Rank == "mem_pe")
            {
                num = 4;
            }
            else if (this.Rank == "bachir")
            {
                num = 4;
            }
            return num;
        }
        //----------------------------------------------------------------------------------------
        private static readonly Random rnd = new Random();
        public List<string> creatWeaknesses()
        {
            choice_weaknesses.Clear();
            int num = checkRank();
            for (int i = 0; i < num; i++)
            {
                choice_weaknesses.Add(Sensors[rnd.Next(0, Sensors.Length)]);
            }
            return choice_weaknesses;
        }

    }
}
