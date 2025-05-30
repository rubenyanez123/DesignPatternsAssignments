using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class LowBudgetComputerFactory : IComputerFactory
    {
        public IProcessor CreateProcessor() => new CheapProcessor();
        public IHardDisk CreateHardDisk() => new CheapHardDisk();
        public IMonitor CreateMonitor() => new CheapMonitor();
    }
}
