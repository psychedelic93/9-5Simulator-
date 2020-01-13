using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Davyd = new Player("Davyd", 100, 0, 100);
            Work job = new Work(0, "", false);
            if(job.JobTitle == "")
            {
                job.unemployed(Davyd);
            }
        }
    }
}
