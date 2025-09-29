using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Phumla.Forms
{
    public partial class OccupancyReportsForm : Form
    {
        public class OccupancyData
        {
            public string Date { get; set; }
            public int RoomsAvailable { get; set; }
            public int RoomsOccupied { get; set; }
            public int OccupancyPercentage { get; set; }
            public int Revenue { get; set; }
        }

        private List<OccupancyData> reportData = new List<OccupancyData>();

        public OccupancyReportsForm()
        {
            InitializeComponent();
            btnGenerate.Click += BtnGenerate_Click;
            btnExport.Click += BtnExport_Click;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            dgvReport.DataSource = null;
            lblSummary.Text = "";
            btnExport.Enabled = false;
            reportData.Clear();

            // Validation
            if (cmbHotel.SelectedIndex == -1)
            {
                lblError.Text = "Please select a hotel.";
                return;
            }
            if (dtFrom.Value.Date > dtTo.Value.Date)
            {
                lblError.Text = "To date must be after from date.";
                return;
            }
            var daysDiff = (dtTo.Value.Date - dtFrom.Value.Date).Days;
            if (daysDiff > 90)
            {
                lblError.Text = "Date range cannot exceed 90 days.";
                return;
            }

            // Generate mock data
            var totalRooms = 50;
            var start = dtFrom.Value.Date;
            var end = dtTo.Value.Date;
            var rand = new Random();

            for (var d = start; d <= end; d = d.AddDays(1))
            {
                var occupied = rand.Next(10, totalRooms + 1);
                var occupancyPercentage = (int)Math.Round((double)occupied / totalRooms * 100);
                var revenue = occupied * rand.Next(800, 1301);

                reportData.Add(new OccupancyData
                {
                    Date = d.ToString("yyyy-MM-dd"),
                    RoomsAvailable = totalRooms,
                    RoomsOccupied = occupied,
                    OccupancyPercentage = occupancyPercentage,
                    Revenue = revenue
                });
            }

            // Bind to DataGridView
            dgvReport.DataSource = reportData;

            // Show summary
            int totalRoomNights = reportData.Count * totalRooms;
            int totalOccupied = 0, totalRevenue = 0;
            foreach (var day in reportData)
            {
                totalOccupied += day.RoomsOccupied;
                totalRevenue += day.Revenue;
            }
            int avgOccupancy = totalRoomNights > 0 ? (int)Math.Round((double)totalOccupied / totalRoomNights * 100) : 0;

            lblSummary.Text = $"Total Room Nights: {totalRoomNights}    " +
                              $"Rooms Occupied: {totalOccupied}    " +
                              $"Average Occupancy: {avgOccupancy}%    " +
                              $"Total Revenue: R{totalRevenue:N0}";

            btnExport.Enabled = true;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report export functionality would be implemented here.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}