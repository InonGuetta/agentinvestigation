using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using agentinvestigation.classes;
using agentinvestigation.SERVICES;
using Microsoft.SqlServer.Server;


namespace agentinvestigation.UI
{
    internal class MenuClass
    {  public static void Menu()
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
                        Console.WriteLine("=======================================");
                        Console.WriteLine("     Choose the Type of Agent to Play");
                        Console.WriteLine("=======================================\n");

                        Console.WriteLine("  [1] Agent Type: zotar");
                        Console.WriteLine("  [2] Agent Type: mem_em");
                        Console.WriteLine("  [3] Agent Type: mem_pe");
                        Console.WriteLine("  [4] Agent Type: bachir\n");

                        Console.Write("Enter your choice (1-4): ");
                        GeneralManagement generalManagement = new GeneralManagement();
                        Sensor sensor = new Sensor();

                        int choice_agent = Convert.ToInt32(Console.ReadLine());
                        switch (choice_agent)
                        {
                            case 1:
                                Console.WriteLine("Please give the name to be given to the agent you are investigating.");
                                string nameZotar = Console.ReadLine();
                                Agent agentZotar = new Agent(nameZotar, "zotar");
                                //===
                                List<string> save_weaknesses_zotar = agentZotar.creatWeaknesses("zotar");
                                // מה הבעיה בקוד כאן למטה 
                                generalManagement.runInsertAndCheck("zotar", save_weaknesses_zotar);
                                break;
                            case 2:
                                Console.WriteLine("Please give the name to be given to the agent you are investigating.");
                                string nameMem_em = Console.ReadLine();
                                //===
                                Agent agentMem_em = new Agent(nameMem_em, "mem_em");
                                List<string> save_weaknesses_mem_em = agentMem_em.creatWeaknesses("mem_em");
                                generalManagement.runInsertAndCheck("mem_em", save_weaknesses_mem_em);
                                break;
                            case 3:
                                Console.WriteLine("Please give the name to be given to the agent you are investigating.");
                                string nameMem_pe = Console.ReadLine();
                                //===
                                Agent agentMem_pe = new Agent(nameMem_pe, "mem_pe");
                                List<string> save_weaknesses_mem_pe = agentMem_pe.creatWeaknesses("mem_em");
                                generalManagement.runInsertAndCheck("mem_pe", save_weaknesses_mem_pe);
                                break;
                            case 4:
                                Console.WriteLine("Please give the name to be given to the agent you are investigating.");
                                string nameBachir = Console.ReadLine();
                                //===
                                Agent agentBachir = new Agent(nameBachir, "bachir");
                                List<string> save_weaknesses_bachir = agentBachir.creatWeaknesses("bachir");
                                generalManagement.runInsertAndCheck("bachir", save_weaknesses_bachir);
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
