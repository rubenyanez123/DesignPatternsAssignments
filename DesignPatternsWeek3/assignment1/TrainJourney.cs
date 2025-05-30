using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TrainJourney : ITrainJourney
    {
        private TrainStation currentStation;
        private List<TrainStation> stations;
        private int index = 0;
        private List<ITrainDisplay> observers;
        public int numberObservers = 0;

        public void AddObserver(ITrainDisplay display)
        {
            display.Update(currentStation);
            observers.Add(display);
            numberObservers++;
        }

        public void RemoveObserver(ITrainDisplay display)
        {
            observers.Remove(display);
            numberObservers--;
        }

        public void NextStation()
        {
            index++;
            if (index == stations.Count)
            {
                index = 0;
            }
            currentStation = stations[index];
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(currentStation);
            }
        }

        public TrainJourney()
        {
            observers = new List<ITrainDisplay>();
            stations = new List<TrainStation>
        {
            new TrainStation(new DateTime(2024, 5, 6), new DateTime(2024, 5, 6), "Den Helder", 1),
            new TrainStation(new DateTime(2024, 5, 6), new DateTime(2024, 5, 6), "Anna Paulowna", 1),
            new TrainStation(new DateTime(2024, 5, 6), new DateTime(2024, 5, 6), "Schagen", 1),
            new TrainStation(new DateTime(2024, 5, 6), new DateTime(2024, 5, 6), "Heerhugowaard", 1),
            new TrainStation(new DateTime(2024, 5, 6), new DateTime(2024, 5, 6), "Alkmaar", 1),
            new TrainStation(new DateTime(2024, 5, 6), new DateTime(2024, 5, 6), "Heiloo", 1),
            new TrainStation(new DateTime(2024, 5, 6), new DateTime(2024, 5, 6), "Castricum", 1),
            new TrainStation(new DateTime(2024, 5, 6), new DateTime(2024, 5, 6), "Zaandam", 1),
            new TrainStation(new DateTime(2024, 5, 6), new DateTime(2024, 5, 6), "Amsterdam", 1),
            new TrainStation(new DateTime(2024, 5, 6), new DateTime(2024, 5, 6), "Nijmegen", 1)
        };

            currentStation = stations[0];
        }
    }
}
