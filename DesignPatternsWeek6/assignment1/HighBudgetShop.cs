using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class HighBudgetShop : ComputerShop
    {
        public override Computer AssembleComputer()
        {
            return new Computer(new ExpensiveProcessor(), new ExpensiveHardDisk(), new ExpensiveMonitor());
        }
    }
}
