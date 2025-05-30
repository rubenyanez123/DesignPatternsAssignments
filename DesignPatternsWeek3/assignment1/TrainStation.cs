using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TrainStation
    {

        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public string Name { get; set; }
        public int ArrivalTrack { get; set; }

        public TrainStation(DateTime arrivalTime, DateTime departureTime, string name, int arrivalTrack)
        {
            ArrivalTime = arrivalTime;
            DepartureTime = departureTime;
            Name = name;
            ArrivalTrack = arrivalTrack;
        }
    }
}
