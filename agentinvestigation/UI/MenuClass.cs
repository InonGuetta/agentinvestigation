using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using agentinvestigation.classes;


namespace agentinvestigation.UI
{
    internal class MenuClass
    {
       public static void Menu()
        {
            bool pause = false;
            while (!pause)
            {
                Console.WriteLine("welcome to GAME catch agent \n");
                Console.WriteLine("PRESS 1 TO SIMPLE GAME");
                Console.WriteLine("PRESS 2 TO COMPLEX GAME");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        string message= "try catch the agent '\n' PRESS 1 = audio |'\n' PRESS 2 = hacking " +
                                    "\n PRESS 3 = espionage |'\n PRESS 4 = infiltration'";
                        Console.WriteLine("=======================================");
                        Console.WriteLine("     Choose the Type of Agent to Play");
                        Console.WriteLine("=======================================\n");

                        Console.WriteLine("  [1] Agent Type: zotar");
                        Console.WriteLine("  [2] Agent Type: mem_em");
                        Console.WriteLine("  [3] Agent Type: mem_pe");
                        Console.WriteLine("  [4] Agent Type: bachir\n");

                        Console.Write("Enter your choice (1-4): ");

                        int choice_agent = Convert.ToInt32(Console.ReadLine());
                        // למה אני לא יכול להפעיל כאן את הקלאסס AGENT 
                        switch (choice_agent)
                        {
                            case 1:
                                Console.WriteLine("Please give the name to be given to the agent you are investigating.");
                                string nameZotar = Console.ReadLine();
                                Agent agentZotar = new Agent(nameZotar, "zotar");
                                Console.WriteLine(message);
                                //כאן צריכה להיות מופעלת מתודה של GameFlow
                                break;
                            case 2:
                                Console.WriteLine("Please give the name to be given to the agent you are investigating.");
                                string nameMem_em = Console.ReadLine();
                                Agent agentMem_em = new Agent(nameMem_em, "mem_em");
                                Console.WriteLine(message);
                                //כאן צריכה להיות מופעלת מתודה של GameFlow
                                break;
                            case 3:
                                Console.WriteLine("Please give the name to be given to the agent you are investigating.");
                                string nameMem_pe = Console.ReadLine();
                                Agent agentMem_pe = new Agent(nameMem_pe, "mem_pe");
                                Console.WriteLine(message);
                                //כאן צריכה להיות מופעלת מתודה של GameFlow
                                break;
                            case 4:
                                Console.WriteLine("Please give the name to be given to the agent you are investigating.");
                                string nameBachir = Console.ReadLine();
                                Agent agentBachir = new Agent(nameBachir, "bachir");
                                Console.WriteLine(message);
                                //כאן צריכה להיות מופעלת מתודה של GameFlow
                                break;

                        }
                        break;
                    case 2:
                        break;
                    case 9:
                        pause = true;
                        break;
                }
            }

        }
    }
}
