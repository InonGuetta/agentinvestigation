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
        // מערך של הצמדות שכל מה שאני קולט מהמשתמש הוא נכנס למערך חדש
        public List<string> stickSensors = new List<string>();



        // אני עושה מערך של הצמדות ורק אחר כך אני עושה את ההשוואות
        // כאן תתבצע ההזנה של הערכים של הסוכן מהמשתמש 
        public List<string> insertSensors(string checkRank)
        {
            int num = Agent.checkRankNum(checkRank); 
            int insert_sensors;
            for (int i = 0; i < num; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("try catch the agent '\n' PRESS 1 = audio '\n' PRESS 2 = hacking " +
                            "\n PRESS 3 = espionage '\n PRESS 4 = infiltration ");
                        insert_sensors = Convert.ToInt32(Console.ReadLine());
                        if (insert_sensors < 0 || insert_sensors >= Sensor.Sensors.Length)
                        {
                            Console.WriteLine("Invalid input, please try again.");
                            continue;
                        }
                        stickSensors.Add(Sensor.Sensors[insert_sensors]);
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input, error ");
                    }
                }
            }
            return stickSensors;  
        }
    }
}
