using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoShipFreight
{
    public partial class form1 : Form
    {
        Ship ship = new Ship();
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            progressBar2.Style = ProgressBarStyle.Continuous;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ship = new Ship();
            updateUI();
        }

        private void updateUI()
        {
            // set all the controls to match the ship property
            progressBar2.Maximum = ship.Capacity;

            if (ship.getShipLoad() <= ship.Capacity)
                progressBar2.Value = ship.getShipLoad();

            label_shipLabel.Text = ship.ToString();

            // Motorcycles, cars, trucks and traincars labels
            label_cycleCount.Text = ship.CycleCount.ToString();
            label_carCount.Text = ship.CarCount.ToString();
            label_truckCount.Text = ship.TruckCount.ToString();
            label_trainCarCount.Text = ship.TrainCarCount.ToString();

            if (ship.overUnder() == 0)
            {
                progressBar2.ForeColor = Color.Green;
            }
            if (ship.overUnder() > 0)
            {
                progressBar2.ForeColor = Color.Yellow;
            }
            if (ship.overUnder() < 0)
            {
                progressBar2.ForeColor = Color.Red;
            }
        }

        private void track_motorCycles_Scroll(object sender, EventArgs e)
        {
            ship.CycleCount = track_motorCycles.Value;
            updateUI();
        }

        private void track_cars_Scroll(object sender, EventArgs e)
        {
            ship.CarCount = track_cars.Value;
            updateUI();
        }

        private void track_trucks_Scroll(object sender, EventArgs e)
        {
            ship.TruckCount = track_trucks.Value;
            updateUI();
        }

        private void track_cargoTrains_Scroll(object sender, EventArgs e)
        {
            ship.TrainCarCount = track_trainCars.Value;
            updateUI();
        }
    }
}
