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
        public List<string> stickSensors = new List<string>();


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
                        Console.WriteLine("try catch the agent \nPRESS 1 = audio \nPRESS 2 = hacking " +
                            "\nPRESS 3 = espionage \nPRESS 4 = infiltration ");
                        insert_sensors = Convert.ToInt32(Console.ReadLine());

                        if (insert_sensors <= 0 || insert_sensors > Sensor.Sensors.Length)
                        {
                            Console.WriteLine("Invalid input, please try again.");
                            continue;
                        }
                        stickSensors.Add(Sensor.Sensors[insert_sensors-1]);
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
