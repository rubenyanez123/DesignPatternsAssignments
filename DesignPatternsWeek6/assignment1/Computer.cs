using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class Computer
    {
        public IProcessor Processor {  get; set; }
        public IHardDisk HardDisk { get; set; }
        public IMonitor Monitor { get; set; }

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
