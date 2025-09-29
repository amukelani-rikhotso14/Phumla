using System.Windows.Forms;

namespace Phumla.Forms
{
    partial class BookingPaymentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethodError;
        private System.Windows.Forms.Panel pnlCreditCard;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtExpiry;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label lblCardNumberError;
        private System.Windows.Forms.Label lblExpiryError;
        private System.Windows.Forms.Label lblCVVError;
        private System.Windows.Forms.Panel pnlCash;
        private System.Windows.Forms.Panel pnlAgentInvoice;
        private System.Windows.Forms.Label lblCashInfo;
        private System.Windows.Forms.Label lblAgentInfo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblConfirmation;

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblHotel = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblGuests = new System.Windows.Forms.Label();
            this.lblNights = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethodError = new System.Windows.Forms.Label();
            this.pnlCreditCard = new System.Windows.Forms.Panel();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtExpiry = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblCardNumberError = new System.Windows.Forms.Label();
            this.lblExpiryError = new System.Windows.Forms.Label();
            this.lblCVVError = new System.Windows.Forms.Label();
            this.pnlCash = new System.Windows.Forms.Panel();
            this.lblCashInfo = new System.Windows.Forms.Label();
            this.pnlAgentInvoice = new System.Windows.Forms.Panel();
            this.lblAgentInfo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.grpSummary.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.pnlCreditCard.SuspendLayout();
            this.pnlCash.SuspendLayout();
            this.pnlAgentInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(30, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(400, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Booking Summary & Payment";
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblHotel);
            this.grpSummary.Controls.Add(this.lblRoomType);
            this.grpSummary.Controls.Add(this.lblCheckIn);
            this.grpSummary.Controls.Add(this.lblCheckOut);
            this.grpSummary.Controls.Add(this.lblGuests);
            this.grpSummary.Controls.Add(this.lblNights);
            this.grpSummary.Controls.Add(this.lblTotalPrice);
            this.grpSummary.Controls.Add(this.lblDeposit);
            this.grpSummary.Location = new System.Drawing.Point(30, 60);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(630, 120);
            this.grpSummary.TabIndex = 1;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Booking Details Summary";
            // 
            // lblHotel
            // 
            this.lblHotel.Location = new System.Drawing.Point(10, 25);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(300, 20);
            this.lblHotel.TabIndex = 0;
            // 
            // lblRoomType
            // 
            this.lblRoomType.Location = new System.Drawing.Point(320, 25);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(300, 20);
            this.lblRoomType.TabIndex = 1;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.Location = new System.Drawing.Point(10, 45);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(300, 20);
            this.lblCheckIn.TabIndex = 2;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.Location = new System.Drawing.Point(320, 45);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(300, 20);
            this.lblCheckOut.TabIndex = 3;
            // 
            // lblGuests
            // 
            this.lblGuests.Location = new System.Drawing.Point(10, 65);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(300, 20);
            this.lblGuests.TabIndex = 4;
            // 
            // lblNights
            // 
            this.lblNights.Location = new System.Drawing.Point(320, 65);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(300, 20);
            this.lblNights.TabIndex = 5;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Location = new System.Drawing.Point(10, 85);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(300, 20);
            this.lblTotalPrice.TabIndex = 6;
            // 
            // lblDeposit
            // 
            this.lblDeposit.Location = new System.Drawing.Point(320, 85);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(300, 20);
            this.lblDeposit.TabIndex = 7;
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.cmbPaymentMethod);
            this.grpPayment.Controls.Add(this.lblPaymentMethodError);
            this.grpPayment.Controls.Add(this.pnlCreditCard);
            this.grpPayment.Controls.Add(this.pnlCash);
            this.grpPayment.Controls.Add(this.pnlAgentInvoice);
            this.grpPayment.Location = new System.Drawing.Point(30, 200);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(630, 200);
            this.grpPayment.TabIndex = 2;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment Method";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Credit Card",
            "Cash",
            "Agent Invoice"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(20, 30);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(200, 24);
            this.cmbPaymentMethod.TabIndex = 0;
            // 
            // lblPaymentMethodError
            // 
            this.lblPaymentMethodError.ForeColor = System.Drawing.Color.Red;
            this.lblPaymentMethodError.Location = new System.Drawing.Point(240, 30);
            this.lblPaymentMethodError.Name = "lblPaymentMethodError";
            this.lblPaymentMethodError.Size = new System.Drawing.Size(300, 20);
            this.lblPaymentMethodError.TabIndex = 1;
            // 
            // pnlCreditCard
            // 
            this.pnlCreditCard.Controls.Add(this.txtCardNumber);
            this.pnlCreditCard.Controls.Add(this.txtExpiry);
            this.pnlCreditCard.Controls.Add(this.txtCVV);
            this.pnlCreditCard.Controls.Add(this.lblCardNumberError);
            this.pnlCreditCard.Controls.Add(this.lblExpiryError);
            this.pnlCreditCard.Controls.Add(this.lblCVVError);
            this.pnlCreditCard.Location = new System.Drawing.Point(20, 60);
            this.pnlCreditCard.Name = "pnlCreditCard";
            this.pnlCreditCard.Size = new System.Drawing.Size(580, 100);
            this.pnlCreditCard.TabIndex = 2;
            this.pnlCreditCard.Visible = false;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(3, 0);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(180, 22);
            this.txtCardNumber.TabIndex = 0;
            // 
            // txtExpiry
            // 
            this.txtExpiry.Location = new System.Drawing.Point(200, 0);
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.Size = new System.Drawing.Size(80, 22);
            this.txtExpiry.TabIndex = 1;
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(300, 0);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(60, 22);
            this.txtCVV.TabIndex = 2;
            // 
            // lblCardNumberError
            // 
            this.lblCardNumberError.ForeColor = System.Drawing.Color.Red;
            this.lblCardNumberError.Location = new System.Drawing.Point(0, 24);
            this.lblCardNumberError.Name = "lblCardNumberError";
            this.lblCardNumberError.Size = new System.Drawing.Size(180, 16);
            this.lblCardNumberError.TabIndex = 3;
            // 
            // lblExpiryError
            // 
            this.lblExpiryError.ForeColor = System.Drawing.Color.Red;
            this.lblExpiryError.Location = new System.Drawing.Point(200, 24);
            this.lblExpiryError.Name = "lblExpiryError";
            this.lblExpiryError.Size = new System.Drawing.Size(80, 16);
            this.lblExpiryError.TabIndex = 4;
            // 
            // lblCVVError
            // 
            this.lblCVVError.ForeColor = System.Drawing.Color.Red;
            this.lblCVVError.Location = new System.Drawing.Point(300, 24);
            this.lblCVVError.Name = "lblCVVError";
            this.lblCVVError.Size = new System.Drawing.Size(60, 16);
            this.lblCVVError.TabIndex = 5;
            // 
            // pnlCash
            // 
            this.pnlCash.Controls.Add(this.lblCashInfo);
            this.pnlCash.Location = new System.Drawing.Point(20, 60);
            this.pnlCash.Name = "pnlCash";
            this.pnlCash.Size = new System.Drawing.Size(580, 40);
            this.pnlCash.TabIndex = 3;
            this.pnlCash.Visible = false;
            // 
            // lblCashInfo
            // 
            this.lblCashInfo.Location = new System.Drawing.Point(0, 0);
            this.lblCashInfo.Name = "lblCashInfo";
            this.lblCashInfo.Size = new System.Drawing.Size(580, 40);
            this.lblCashInfo.TabIndex = 0;
            this.lblCashInfo.Text = "Cash payment will be collected at check-in. A deposit is required to confirm this" +
    " booking.";
            // 
            // pnlAgentInvoice
            // 
            this.pnlAgentInvoice.Controls.Add(this.lblAgentInfo);
            this.pnlAgentInvoice.Location = new System.Drawing.Point(20, 60);
            this.pnlAgentInvoice.Name = "pnlAgentInvoice";
            this.pnlAgentInvoice.Size = new System.Drawing.Size(580, 40);
            this.pnlAgentInvoice.TabIndex = 4;
            this.pnlAgentInvoice.Visible = false;
            // 
            // lblAgentInfo
            // 
            this.lblAgentInfo.Location = new System.Drawing.Point(0, 0);
            this.lblAgentInfo.Name = "lblAgentInfo";
            this.lblAgentInfo.Size = new System.Drawing.Size(580, 40);
            this.lblAgentInfo.TabIndex = 0;
            this.lblAgentInfo.Text = "An invoice will be sent to the travel agent for payment processing.";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(30, 470);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 32);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(540, 470);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(120, 32);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm Booking";
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblConfirmation.ForeColor = System.Drawing.Color.Green;
            this.lblConfirmation.Location = new System.Drawing.Point(30, 420);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(630, 32);
            this.lblConfirmation.TabIndex = 3;
            this.lblConfirmation.Visible = false;
            // 
            // BookingPaymentForm
            // 
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.lblConfirmation);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Name = "BookingPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Payment - Phumla Kamnandi Hotels";
            this.grpSummary.ResumeLayout(false);
            this.grpPayment.ResumeLayout(false);
            this.pnlCreditCard.ResumeLayout(false);
            this.pnlCreditCard.PerformLayout();
            this.pnlCash.ResumeLayout(false);
            this.pnlAgentInvoice.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}