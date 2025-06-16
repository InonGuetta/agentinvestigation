using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agentinvestigation.classes
{
    internal class Agent
    {
        public string Name_Agent { get; private set; }
        public string Rank { get; private set; }

        public string[] Sensors = { "audio", "hacking", "espionage", "infiltration" };
        public List<string> choice_weaknesses { get; set; } = new List<string>();
        
       //----------------------------------------------------------------------------------------

        public Agent(string name, string rank)
        {
            this.Name_Agent = name;
            this.Rank = rank;
        }


    }
}
