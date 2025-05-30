using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class ComputerShop
    {
        public Computer AssembleComputer(IComputerFactory factory)
        {
            IProcessor processor = factory.CreateProcessor();
            IHardDisk hardDisk = factory.CreateHardDisk();
            IMonitor monitor = factory.CreateMonitor();
            return new Computer(processor, hardDisk, monitor);
        }
    }
}
