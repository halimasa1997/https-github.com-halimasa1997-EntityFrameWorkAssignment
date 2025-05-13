using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Model
{
    internal class Terminal
    {
        public int TerminalID { get; set; }
        public string TerminalName { get; set; }
        public double Capacity { get; set; }
        public string Location { get; set; }


        public Terminal(int terminalID, string terminalName, double capacity, string location)
        {
            TerminalID = terminalID;
            TerminalName = terminalName;
            Capacity = capacity;
            Location = location;
        }
    }
}
