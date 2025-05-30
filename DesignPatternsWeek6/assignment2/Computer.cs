using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Computer
    {
        public IProcessor Processor;
        public IHardDisk HardDisk;
        public IMonitor Monitor;

        public Computer(IProcessor processor, IHardDisk hardDisk, IMonitor monitor)
        {
            Processor = processor;
            HardDisk = hardDisk;
            Monitor = monitor;
        }

        public void Test()
        {
            Processor.PerformOperation();
            HardDisk.StoreData();
            Monitor.Display();
        }
    }
}
