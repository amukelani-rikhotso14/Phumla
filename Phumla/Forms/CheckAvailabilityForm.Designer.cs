using System;
using System.Drawing;
using System.Windows.Forms;

namespace Phumla.Forms
{
    partial class CheckAvailabilityForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbHotel;
        private DateTimePicker dtArrival;
        private DateTimePicker dtDeparture;
        private NumericUpDown numAdults;
        private NumericUpDown numChildren;
        private ComboBox cmbRatePreference;
        private Button btnCheckAvailability;
        private Button btnCancel;
        private Label lblError;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SuspendLayout();

            // Hotel Label
            Label lblHotel = new Label();
            lblHotel.Text = "Hotel *";
            lblHotel.Location = new Point(40, 40);
            lblHotel.AutoSize = true;

            // Hotel ComboBox
            this.cmbHotel = new ComboBox();
            this.cmbHotel.Location = new Point(200, 40);
            this.cmbHotel.Width = 250;
            this.cmbHotel.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbHotel.Items.AddRange(new string[] { "Cape Town", "Johannesburg", "Durban", "Port Elizabeth" });

            // Arrival Label
            Label lblArrival = new Label();
            lblArrival.Text = "Arrival Date *";
            lblArrival.Location = new Point(40, 90);
            lblArrival.AutoSize = true;

            // Arrival DateTimePicker
            this.dtArrival = new DateTimePicker();
            this.dtArrival.Location = new Point(200, 90);
            this.dtArrival.Width = 250;
            this.dtArrival.Format = DateTimePickerFormat.Short;
            this.dtArrival.MinDate = DateTime.Today;

            // Departure Label
            Label lblDeparture = new Label();
            lblDeparture.Text = "Departure Date *";
            lblDeparture.Location = new Point(40, 140);
            lblDeparture.AutoSize = true;

            // Departure DateTimePicker
            this.dtDeparture = new DateTimePicker();
            this.dtDeparture.Location = new Point(200, 140);
            this.dtDeparture.Width = 250;
            this.dtDeparture.Format = DateTimePickerFormat.Short;
            this.dtDeparture.MinDate = DateTime.Today;

            // Adults Label
            Label lblAdults = new Label();
            lblAdults.Text = "Number of Adults *";
            lblAdults.Location = new Point(40, 190);
            lblAdults.AutoSize = true;

            // Adults NumericUpDown
            this.numAdults = new NumericUpDown();
            this.numAdults.Location = new Point(200, 190);
            this.numAdults.Width = 80;
            this.numAdults.Minimum = 1;
            this.numAdults.Maximum = 4;
            this.numAdults.Value = 1;

            // Children Label
            Label lblChildren = new Label();
            lblChildren.Text = "Number of Children";
            lblChildren.Location = new Point(40, 240);
            lblChildren.AutoSize = true;

            // Children NumericUpDown
            this.numChildren = new NumericUpDown();
            this.numChildren.Location = new Point(200, 240);
            this.numChildren.Width = 80;
            this.numChildren.Minimum = 0;
            this.numChildren.Maximum = 3;
            this.numChildren.Value = 0;

            // Rate Preference Label
            Label lblRatePref = new Label();
            lblRatePref.Text = "Rate Preference *";
            lblRatePref.Location = new Point(40, 290);
            lblRatePref.AutoSize = true;

            // Rate Preference ComboBox
            this.cmbRatePreference = new ComboBox();
            this.cmbRatePreference.Location = new Point(200, 290);
            this.cmbRatePreference.Width = 250;
            this.cmbRatePreference.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRatePreference.Items.AddRange(new string[] { "Per Room", "Per Person" });

            // Error Label
            this.lblError = new Label();
            this.lblError.ForeColor = Color.Red;
            this.lblError.Location = new Point(40, 330);
            this.lblError.AutoSize = true;

            // Cancel Button
            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new Point(200, 380);
            this.btnCancel.Width = 120;

            // Check Availability Button
            this.btnCheckAvailability = new Button();
            this.btnCheckAvailability.Text = "📅 Check Availability";
            this.btnCheckAvailability.Location = new Point(340, 380);
            this.btnCheckAvailability.Width = 150;

            // Form properties
            this.Text = "Check Availability - Phumla Kamnandi Hotels";
            this.ClientSize = new Size(600, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Add controls
            this.Controls.Add(lblHotel);
            this.Controls.Add(this.cmbHotel);
            this.Controls.Add(lblArrival);
            this.Controls.Add(this.dtArrival);
            this.Controls.Add(lblDeparture);
            this.Controls.Add(this.dtDeparture);
            this.Controls.Add(lblAdults);
            this.Controls.Add(this.numAdults);
            this.Controls.Add(lblChildren);
            this.Controls.Add(this.numChildren);
            this.Controls.Add(lblRatePref);
            this.Controls.Add(this.cmbRatePreference);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckAvailability);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}