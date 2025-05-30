using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace assignment1
{
    public interface ITrainDisplay
    {
        public void Update(TrainStation station);
    }
}
