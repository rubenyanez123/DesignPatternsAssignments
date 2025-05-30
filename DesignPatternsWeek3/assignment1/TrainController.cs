using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class TrainController : ITrainController
    {
        public TrainJourney journey;

        public TrainController(TrainJourney journey)
        {
            this.journey = journey;
        }

        public void NextStation()
        {
            journey.NextStation();
        }
    }
}
