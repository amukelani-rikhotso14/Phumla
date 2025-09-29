namespace Phumla.Forms
{
    partial class GuestLookupForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchInfo;
        private System.Windows.Forms.GroupBox grpGuestDetails;
        private System.Windows.Forms.Label lblGuestDetails;
        private System.Windows.Forms.Button btnUseGuest;
        private System.Windows.Forms.GroupBox grpAddGuest;
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.TextBox txtLoyaltyCard;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSaveGuest;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Label lblAddGuestError;
        private System.Windows.Forms.Label lblNoGuestFound;
        private System.Windows.Forms.Button btnShowAddGuest;


        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchInfo = new System.Windows.Forms.Label();
            this.grpGuestDetails = new System.Windows.Forms.GroupBox();
            this.lblGuestDetails = new System.Windows.Forms.Label();
            this.btnUseGuest = new System.Windows.Forms.Button();
            this.grpAddGuest = new System.Windows.Forms.GroupBox();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.txtLoyaltyCard = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSaveGuest = new System.Windows.Forms.Button();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.lblAddGuestError = new System.Windows.Forms.Label();
            this.lblNoGuestFound = new System.Windows.Forms.Label();
            this.btnShowAddGuest = new System.Windows.Forms.Button();
            this.grpGuestDetails.SuspendLayout();
            this.grpAddGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(30, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(350, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(400, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            // 
            // lblSearchInfo
            // 
            this.lblSearchInfo.Location = new System.Drawing.Point(30, 20);
            this.lblSearchInfo.Name = "lblSearchInfo";
            this.lblSearchInfo.Size = new System.Drawing.Size(400, 20);
            this.lblSearchInfo.TabIndex = 0;
            this.lblSearchInfo.Text = "Search for an existing guest by phone, email, or ID:";
            // 
            // grpGuestDetails
            // 
            this.grpGuestDetails.Controls.Add(this.lblGuestDetails);
            this.grpGuestDetails.Controls.Add(this.btnUseGuest);
            this.grpGuestDetails.Location = new System.Drawing.Point(30, 130);
            this.grpGuestDetails.Name = "grpGuestDetails";
            this.grpGuestDetails.Size = new System.Drawing.Size(630, 140);
            this.grpGuestDetails.TabIndex = 5;
            this.grpGuestDetails.TabStop = false;
            this.grpGuestDetails.Text = "Guest Details";
            this.grpGuestDetails.Visible = false;
            // 
            // lblGuestDetails
            // 
            this.lblGuestDetails.Location = new System.Drawing.Point(10, 25);
            this.lblGuestDetails.Name = "lblGuestDetails";
            this.lblGuestDetails.Size = new System.Drawing.Size(600, 70);
            this.lblGuestDetails.TabIndex = 0;
            // 
            // btnUseGuest
            // 
            this.btnUseGuest.Location = new System.Drawing.Point(10, 100);
            this.btnUseGuest.Name = "btnUseGuest";
            this.btnUseGuest.Size = new System.Drawing.Size(120, 28);
            this.btnUseGuest.TabIndex = 1;
            this.btnUseGuest.Text = "Use Guest";
            // 
            // grpAddGuest
            // 
            this.grpAddGuest.Controls.Add(this.cmbTitle);
            this.grpAddGuest.Controls.Add(this.txtFirstName);
            this.grpAddGuest.Controls.Add(this.txtLastName);
            this.grpAddGuest.Controls.Add(this.txtPhone);
            this.grpAddGuest.Controls.Add(this.txtEmail);
            this.grpAddGuest.Controls.Add(this.txtIdNumber);
            this.grpAddGuest.Controls.Add(this.txtLoyaltyCard);
            this.grpAddGuest.Controls.Add(this.txtAddress);
            this.grpAddGuest.Controls.Add(this.btnSaveGuest);
            this.grpAddGuest.Controls.Add(this.btnCancelAdd);
            this.grpAddGuest.Controls.Add(this.lblAddGuestError);
            this.grpAddGuest.Location = new System.Drawing.Point(30, 290);
            this.grpAddGuest.Name = "grpAddGuest";
            this.grpAddGuest.Size = new System.Drawing.Size(630, 237);
            this.grpAddGuest.TabIndex = 6;
            this.grpAddGuest.TabStop = false;
            this.grpAddGuest.Text = "Add New Guest";
            this.grpAddGuest.Visible = false;
            // 
            // cmbTitle
            // 
            this.cmbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitle.Items.AddRange(new object[] {
            "Mr",
            "Ms",
            "Mrs",
            "Dr"});
            this.cmbTitle.Location = new System.Drawing.Point(20, 30);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(80, 24);
            this.cmbTitle.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 30);
            this.txtFirstName.Name = "txtFirstName";
            SetPlaceholder(txtFirstName, "First Name");
            this.txtFirstName.Size = new System.Drawing.Size(150, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(290, 30);
            this.txtLastName.Name = "txtLastName";
            SetPlaceholder(txtLastName, "Last Name");
            this.txtLastName.Size = new System.Drawing.Size(150, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(20, 70);
            this.txtPhone.Name = "txtPhone";
            SetPlaceholder(txtPhone, "Phone (+27 xxx xxx xxxx)");
            this.txtPhone.Size = new System.Drawing.Size(150, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(190, 70);
            this.txtEmail.Name = "txtEmail";
            SetPlaceholder(txtEmail, "Email (optional)");
            this.txtEmail.Size = new System.Drawing.Size(150, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(360, 70);
            this.txtIdNumber.Name = "txtIdNumber";
            SetPlaceholder(txtIdNumber, "ID/Passport (optional)");
            this.txtIdNumber.Size = new System.Drawing.Size(120, 22);
            this.txtIdNumber.TabIndex = 5;
            // 
            // txtLoyaltyCard
            // 
            this.txtLoyaltyCard.Location = new System.Drawing.Point(20, 110);
            this.txtLoyaltyCard.Name = "txtLoyaltyCard";
            SetPlaceholder(txtLoyaltyCard, "Loyalty Card (optional)");
            this.txtLoyaltyCard.Size = new System.Drawing.Size(150, 22);
            this.txtLoyaltyCard.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(190, 110);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            SetPlaceholder(txtAddress, "Address (optional)");
            this.txtAddress.Size = new System.Drawing.Size(290, 50);
            this.txtAddress.TabIndex = 7;
            // 
            // btnSaveGuest
            // 
            this.btnSaveGuest.Location = new System.Drawing.Point(20, 180);
            this.btnSaveGuest.Name = "btnSaveGuest";
            this.btnSaveGuest.Size = new System.Drawing.Size(120, 28);
            this.btnSaveGuest.TabIndex = 8;
            this.btnSaveGuest.Text = "Save Guest";
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(160, 180);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(120, 28);
            this.btnCancelAdd.TabIndex = 9;
            this.btnCancelAdd.Text = "Cancel";
            // 
            // lblAddGuestError
            // 
            this.lblAddGuestError.ForeColor = System.Drawing.Color.Red;
            this.lblAddGuestError.Location = new System.Drawing.Point(20, 220);
            this.lblAddGuestError.Name = "lblAddGuestError";
            this.lblAddGuestError.Size = new System.Drawing.Size(400, 24);
            this.lblAddGuestError.TabIndex = 10;
            // 
            // lblNoGuestFound
            // 
            this.lblNoGuestFound.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblNoGuestFound.Location = new System.Drawing.Point(30, 90);
            this.lblNoGuestFound.Name = "lblNoGuestFound";
            this.lblNoGuestFound.Size = new System.Drawing.Size(400, 24);
            this.lblNoGuestFound.TabIndex = 3;
            this.lblNoGuestFound.Visible = false;
            // 
            // btnShowAddGuest
            // 
            this.btnShowAddGuest.Location = new System.Drawing.Point(440, 90);
            this.btnShowAddGuest.Name = "btnShowAddGuest";
            this.btnShowAddGuest.Size = new System.Drawing.Size(120, 28);
            this.btnShowAddGuest.TabIndex = 4;
            this.btnShowAddGuest.Text = "Add New Guest";
            this.btnShowAddGuest.Visible = false;
            // 
            // GuestLookupForm
            // 
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.lblSearchInfo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblNoGuestFound);
            this.Controls.Add(this.btnShowAddGuest);
            this.Controls.Add(this.grpGuestDetails);
            this.Controls.Add(this.grpAddGuest);
            this.Name = "GuestLookupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest Lookup / Add Guest - Phumla Kamnandi Hotels";
            this.grpGuestDetails.ResumeLayout(false);
            this.grpAddGuest.ResumeLayout(false);
            this.grpAddGuest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}