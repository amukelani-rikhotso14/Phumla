namespace Phumla.Forms
{
    partial class OccupancyReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.GroupBox grpSummary;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.lblSummary = new System.Windows.Forms.Label();
            this.grpSummary = new System.Windows.Forms.GroupBox();

            // Form
            this.Text = "Occupancy Reports - Phumla Kamnandi Hotels";
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Hotel ComboBox
            this.cmbHotel.Location = new System.Drawing.Point(30, 30);
            this.cmbHotel.Size = new System.Drawing.Size(200, 24);
            this.cmbHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotel.Items.AddRange(new object[] { "Cape Town", "Johannesburg", "Durban", "Port Elizabeth" });

            // From Date
            this.dtFrom.Location = new System.Drawing.Point(250, 30);
            this.dtFrom.Size = new System.Drawing.Size(150, 24);
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.MaxDate = System.DateTime.Today;

            // To Date
            this.dtTo.Location = new System.Drawing.Point(420, 30);
            this.dtTo.Size = new System.Drawing.Size(150, 24);
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.MaxDate = System.DateTime.Today;

            // Generate Button
            this.btnGenerate.Location = new System.Drawing.Point(590, 28);
            this.btnGenerate.Size = new System.Drawing.Size(120, 28);
            this.btnGenerate.Text = "Generate Report";

            // Export Button
            this.btnExport.Location = new System.Drawing.Point(730, 28);
            this.btnExport.Size = new System.Drawing.Size(120, 28);
            this.btnExport.Text = "Export Report";
            this.btnExport.Enabled = false;

            // Error Label
            this.lblError.Location = new System.Drawing.Point(30, 65);
            this.lblError.Size = new System.Drawing.Size(820, 24);
            this.lblError.ForeColor = System.Drawing.Color.Red;

            // Summary GroupBox
            this.grpSummary.Location = new System.Drawing.Point(30, 95);
            this.grpSummary.Size = new System.Drawing.Size(820, 60);
            this.grpSummary.Text = "Summary";
            this.grpSummary.Controls.Add(this.lblSummary);

            // Summary Label
            this.lblSummary.Location = new System.Drawing.Point(10, 25);
            this.lblSummary.Size = new System.Drawing.Size(800, 24);
            this.lblSummary.Text = "";

            // DataGridView
            this.dgvReport.Location = new System.Drawing.Point(30, 170);
            this.dgvReport.Size = new System.Drawing.Size(820, 370);
            this.dgvReport.ReadOnly = true;
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Add controls
            this.Controls.Add(this.cmbHotel);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.dgvReport);
        }
    }
}