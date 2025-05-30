using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class TrainDisplay : Form, ITrainDisplay
    {
        public TrainDisplay(int number)
        {
            InitializeComponent();
            this.Text = $"Train Display #{number}";
        }

        public void Update(TrainStation station)
        {
            lblCurrentStationName.Text = station.Name;
            lblRailwayTrackNumber.Text = station.ArrivalTrack.ToString();
        }
    }
}
