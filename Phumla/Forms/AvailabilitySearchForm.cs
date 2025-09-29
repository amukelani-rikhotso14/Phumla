using System;
using System.Windows.Forms;

namespace Phumla.Forms
{
    public partial class AvailabilitySearchForm : Form
    {
        public AvailabilitySearchForm()
        {
            InitializeComponent();
            btnCancel.Click += (s, e) => this.Close();
            btnCheckAvailability.Click += BtnCheckAvailability_Click;
        }

        private void BtnCheckAvailability_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            if (cmbHotel.SelectedIndex == -1)
            {
                lblError.Text = "Please select a hotel.";
                return;
            }
            if (cmbRatePreference.SelectedIndex == -1)
            {
                lblError.Text = "Please select a rate preference.";
                return;
            }
            if (dtArrival.Value.Date < DateTime.Today)
            {
                lblError.Text = "Arrival date cannot be in the past.";
                return;
            }
            if (dtDeparture.Value <= dtArrival.Value)
            {
                lblError.Text = "Departure date must be after arrival date.";
                return;
            }
            if (numAdults.Value < 1 || numAdults.Value > 4)
            {
                lblError.Text = "Adults required, maximum 4 per room.";
                return;
            }

            // Simulate availability check
            Random rand = new Random();
            bool isAvailable = rand.NextDouble() > 0.2; // 80% chance

            if (!isAvailable)
            {
                lblError.Text = "No rooms available for selected dates.";
                return;
            }

            MessageBox.Show("Rooms are available! Redirecting to results page...", "Success");
            // TODO: Redirect to results form with search parameters
        }
    }
}