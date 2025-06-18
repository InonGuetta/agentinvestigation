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

        //-----------------------------------------------------------------------------------
        public List<string> insertSensors(string checkRank)
        {
            int num = Agent.checkRankNum(checkRank);
            int insert_sensors;
            for (int i = 0; i < num; i++)
            {
                bool isValid = false;
                while (!isValid)
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
                        stickSensors.Add(Sensor.Sensors[insert_sensors - 1]);
                        isValid = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input, error ");
                    }
                }
            }
            return stickSensors;
        }
        //-----------------------------------------------------------------------------------

        public bool check(string to_check)
        {
            string check_word = "";
            for (int i = 0;i<to_check.Length ;i++)
            {
                if (to_check[i] != ' ')
                {
                    check_word += to_check[i];
                }
                else
                {
                    if (check_word == "greate")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
