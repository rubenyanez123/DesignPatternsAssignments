using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class HighBudgetComputerFactory : IComputerFactory
    {
        public IProcessor CreateProcessor() => new ExpensiveProcessor();
        public IHardDisk CreateHardDisk() => new ExpensiveHardDisk();
        public IMonitor CreateMonitor() => new ExpensiveMonitor();
    }
}
