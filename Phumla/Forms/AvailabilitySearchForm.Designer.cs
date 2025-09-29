namespace Phumla.Forms
{
    partial class AvailabilitySearchForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.ComboBox cmbRatePreference;
        private System.Windows.Forms.DateTimePicker dtArrival;
        private System.Windows.Forms.DateTimePicker dtDeparture;
        private System.Windows.Forms.NumericUpDown numAdults;
        private System.Windows.Forms.NumericUpDown numChildren;
        private System.Windows.Forms.Button btnCheckAvailability;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblError;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.cmbRatePreference = new System.Windows.Forms.ComboBox();
            this.dtArrival = new System.Windows.Forms.DateTimePicker();
            this.dtDeparture = new System.Windows.Forms.DateTimePicker();
            this.numAdults = new System.Windows.Forms.NumericUpDown();
            this.numChildren = new System.Windows.Forms.NumericUpDown();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();

            // Form
            this.Text = "Check Availability - Phumla Kamnandi Hotels";
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Hotel ComboBox
            this.cmbHotel.Location = new System.Drawing.Point(40, 40);
            this.cmbHotel.Size = new System.Drawing.Size(250, 24);
            this.cmbHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotel.Items.AddRange(new object[] { "Cape Town", "Johannesburg", "Durban", "Port Elizabeth" });

            // Rate Preference ComboBox
            this.cmbRatePreference.Location = new System.Drawing.Point(320, 40);
            this.cmbRatePreference.Size = new System.Drawing.Size(200, 24);
            this.cmbRatePreference.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRatePreference.Items.AddRange(new object[] { "Per Room", "Per Person" });

            // Arrival Date
            this.dtArrival.Location = new System.Drawing.Point(40, 90);
            this.dtArrival.Size = new System.Drawing.Size(200, 24);
            this.dtArrival.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtArrival.MinDate = System.DateTime.Today;

            // Departure Date
            this.dtDeparture.Location = new System.Drawing.Point(320, 90);
            this.dtDeparture.Size = new System.Drawing.Size(200, 24);
            this.dtDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDeparture.MinDate = System.DateTime.Today;

            // Adults NumericUpDown
            this.numAdults.Location = new System.Drawing.Point(40, 140);
            this.numAdults.Size = new System.Drawing.Size(80, 24);
            this.numAdults.Minimum = 1;
            this.numAdults.Maximum = 4;
            this.numAdults.Value = 1;

            // Children NumericUpDown
            this.numChildren.Location = new System.Drawing.Point(320, 140);
            this.numChildren.Size = new System.Drawing.Size(80, 24);
            this.numChildren.Minimum = 0;
            this.numChildren.Maximum = 3;
            this.numChildren.Value = 0;

            // Error Label
            this.lblError.Location = new System.Drawing.Point(40, 190);
            this.lblError.Size = new System.Drawing.Size(480, 24);
            this.lblError.ForeColor = System.Drawing.Color.Red;

            // Cancel Button
            this.btnCancel.Location = new System.Drawing.Point(200, 240);
            this.btnCancel.Size = new System.Drawing.Size(120, 32);
            this.btnCancel.Text = "Cancel";

            // Check Availability Button
            this.btnCheckAvailability.Location = new System.Drawing.Point(340, 240);
            this.btnCheckAvailability.Size = new System.Drawing.Size(180, 32);
            this.btnCheckAvailability.Text = "📅 Check Availability";

            // Add controls
            this.Controls.Add(this.cmbHotel);
            this.Controls.Add(this.cmbRatePreference);
            this.Controls.Add(this.dtArrival);
            this.Controls.Add(this.dtDeparture);
            this.Controls.Add(this.numAdults);
            this.Controls.Add(this.numChildren);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckAvailability);
        }
    }
}