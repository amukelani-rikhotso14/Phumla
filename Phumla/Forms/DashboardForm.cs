using PhumlaKamnandiHotelSystem;
using System;
using System.Windows.Forms;

namespace Phumla.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            // Mock data for arrivals
            lvArrivals.Items.Add(new ListViewItem(new[] { "John Doe", "101", "14:00", "+27 11 123 4567" }));
            lvArrivals.Items.Add(new ListViewItem(new[] { "Sarah Smith", "205", "15:30", "+27 21 987 6543" }));
            lvArrivals.Items.Add(new ListViewItem(new[] { "Mike Johnson", "312", "16:00", "+27 31 456 7890" }));

            // Mock data for departures
            lvDepartures.Items.Add(new ListViewItem(new[] { "Alice Brown", "108", "11:00", "+27 11 234 5678" }));
            lvDepartures.Items.Add(new ListViewItem(new[] { "David Wilson", "203", "12:00", "+27 21 876 5432" }));

            btnQuickSearch.Click += BtnQuickSearch_Click;
            btnMakeBooking.Click += BtnMakeBooking_Click;
            btnSearchBooking.Click += BtnSearchBooking_Click;
            btnReports.Click += BtnReports_Click;
            btnLogout.Click += BtnLogout_Click;
        }

        private void BtnQuickSearch_Click(object sender, EventArgs e)
        {
            string query = txtQuickSearch.Text.Trim();
            if (!string.IsNullOrEmpty(query))
            {
                MessageBox.Show($"Searching for: {query}", "Quick Search");
                // TODO: Open search results form
            }
        }

        private void BtnMakeBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new BookingPaymentForm();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void BtnSearchBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new AvailabilitySearchForm();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new OccupancyReportsForm();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new LoginForm();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }
    }
}