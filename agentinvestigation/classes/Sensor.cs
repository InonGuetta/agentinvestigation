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
        public string[] Sensors = { "audio","hacking","espionage","infiltration"};




        public void CheckOne(List<string> to_cetch)
        {
            for (int i =0; i<to_cetch.Count;i++)
            {
                for (int i = 0; ;i++)
                {

                }
            }
            
        }

        public string Activate(List<string> to_cetch)
        {
            int to_num_catchs = to_cetch.Count();
            int count = 0;
            for (int i =0;i< to_num_catchs; i++)
            {
                bool check_one = CheckOne(to_cetch);   
                //  הכיתוב המקוצר של הביטוי האיף הזה  if הזה
                if (check_one) count += 1;
            }
            string answer = (count == to_num_catchs) ? $"greate you sucssed catch all {count}/{to_num_catchs}"
                : $"we are sorry buy you sucssed catch only {count}/{to_num_catchs}";


            return answer;
        }
    }
}
