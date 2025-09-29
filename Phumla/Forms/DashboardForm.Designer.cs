namespace Phumla.Forms
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtQuickSearch;
        private System.Windows.Forms.Button btnQuickSearch;
        private System.Windows.Forms.Button btnMakeBooking;
        private System.Windows.Forms.Button btnSearchBooking;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.ListView lvArrivals;
        private System.Windows.Forms.ListView lvDepartures;
        private System.Windows.Forms.Label lblArrivals;
        private System.Windows.Forms.Label lblDepartures;

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtQuickSearch = new System.Windows.Forms.TextBox();
            this.btnQuickSearch = new System.Windows.Forms.Button();
            this.btnMakeBooking = new System.Windows.Forms.Button();
            this.btnSearchBooking = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.lvArrivals = new System.Windows.Forms.ListView();
            this.lvDepartures = new System.Windows.Forms.ListView();
            this.lblArrivals = new System.Windows.Forms.Label();
            this.lblDepartures = new System.Windows.Forms.Label();

            // Form
            this.Text = "Dashboard - Phumla Kamnandi Hotels";
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Header
            this.lblHeader.Location = new System.Drawing.Point(30, 20);
            this.lblHeader.Size = new System.Drawing.Size(400, 32);
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Text = "Phumla Kamnandi Hotels - Receptionist Home";

            // Logout Button
            this.btnLogout.Location = new System.Drawing.Point(750, 20);
            this.btnLogout.Size = new System.Drawing.Size(100, 32);
            this.btnLogout.Text = "Logout";

            // Quick Search
            this.txtQuickSearch.Location = new System.Drawing.Point(30, 70);
            this.txtQuickSearch.Size = new System.Drawing.Size(300, 24);
            this.btnQuickSearch.Location = new System.Drawing.Point(340, 68);
            this.btnQuickSearch.Size = new System.Drawing.Size(80, 28);
            this.btnQuickSearch.Text = "Search";

            // Main Action Buttons
            this.btnMakeBooking.Location = new System.Drawing.Point(30, 120);
            this.btnMakeBooking.Size = new System.Drawing.Size(180, 50);
            this.btnMakeBooking.Text = "Make Booking";
            this.btnSearchBooking.Location = new System.Drawing.Point(230, 120);
            this.btnSearchBooking.Size = new System.Drawing.Size(180, 50);
            this.btnSearchBooking.Text = "Search Booking";
            this.btnReports.Location = new System.Drawing.Point(430, 120);
            this.btnReports.Size = new System.Drawing.Size(180, 50);
            this.btnReports.Text = "Generate Reports";

            // Arrivals ListView
            this.lblArrivals.Location = new System.Drawing.Point(30, 200);
            this.lblArrivals.Size = new System.Drawing.Size(200, 20);
            this.lblArrivals.Text = "Today's Arrivals";
            this.lvArrivals.Location = new System.Drawing.Point(30, 230);
            this.lvArrivals.Size = new System.Drawing.Size(400, 150);
            this.lvArrivals.View = System.Windows.Forms.View.Details;
            this.lvArrivals.Columns.Add("Name", 120);
            this.lvArrivals.Columns.Add("Room", 60);
            this.lvArrivals.Columns.Add("Time", 60);
            this.lvArrivals.Columns.Add("Phone", 140);

            // Departures ListView
            this.lblDepartures.Location = new System.Drawing.Point(30, 400);
            this.lblDepartures.Size = new System.Drawing.Size(200, 20);
            this.lblDepartures.Text = "Today's Departures";
            this.lvDepartures.Location = new System.Drawing.Point(30, 430);
            this.lvDepartures.Size = new System.Drawing.Size(400, 120);
            this.lvDepartures.View = System.Windows.Forms.View.Details;
            this.lvDepartures.Columns.Add("Name", 120);
            this.lvDepartures.Columns.Add("Room", 60);
            this.lvDepartures.Columns.Add("Time", 60);
            this.lvDepartures.Columns.Add("Phone", 140);

            // Add controls
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtQuickSearch);
            this.Controls.Add(this.btnQuickSearch);
            this.Controls.Add(this.btnMakeBooking);
            this.Controls.Add(this.btnSearchBooking);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.lblArrivals);
            this.Controls.Add(this.lvArrivals);
            this.Controls.Add(this.lblDepartures);
            this.Controls.Add(this.lvDepartures);
        }
    }
}