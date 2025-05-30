using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public interface ITrainJourney
    {
        public void AddObserver(ITrainDisplay observer);
        public void RemoveObserver(ITrainDisplay observer);
        public void NextStation();
    }
}
