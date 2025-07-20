using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_opp
{
    internal class Manager : Employee
    {
        public override void status()
        {
            base.status();
            Console.WriteLine("Manager is managing");
        }
    }
}
