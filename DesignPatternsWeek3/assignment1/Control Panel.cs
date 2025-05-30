namespace assignment1
{
    public partial class ControlPanel : Form
    {
        TrainJourney Journey;
        TrainController TrainController;
        public ControlPanel()
        {

            InitializeComponent();
            Journey = new TrainJourney();
            TrainController = new TrainController(Journey);
        }

        private void btnNextStation_Click(object sender, EventArgs e)
        {
            TrainController.NextStation();
        }

        private void btnNewDisplay_Click(object sender, EventArgs e)
        {
            TrainDisplay trainDisplay = new TrainDisplay(Journey.numberObservers + 1);
            Journey.AddObserver(trainDisplay);
            trainDisplay.Show();
        }
    }
}
