using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class LowBudgetShop : ComputerShop
    {
        public override Computer AssembleComputer()
        {
            return new Computer(new CheapProcessor(), new CheapHardDisk(), new CheapMonitor());
        }
    }
}
