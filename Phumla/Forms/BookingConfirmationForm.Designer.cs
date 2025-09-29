namespace Phumla.Forms
{
    partial class BookingConfirmationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblGuestEmail;
        private System.Windows.Forms.Label lblGuestPhone;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.TextBox txtConfirmationLetter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCopyReference;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Label lblCopySuccess;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblGuestEmail = new System.Windows.Forms.Label();
            this.lblGuestPhone = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblDates = new System.Windows.Forms.Label();
            this.lblNights = new System.Windows.Forms.Label();
            this.lblGuests = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.txtConfirmationLetter = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCopyReference = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.lblCopySuccess = new System.Windows.Forms.Label();

            // Form
            this.Text = "Booking Confirmation - Phumla Kamnandi Hotels";
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Header
            this.lblHeader.Location = new System.Drawing.Point(30, 20);
            this.lblHeader.Size = new System.Drawing.Size(600, 32);
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Text = "Booking Confirmed!";

            // Success
            this.lblSuccess.Location = new System.Drawing.Point(30, 60);
            this.lblSuccess.Size = new System.Drawing.Size(600, 24);
            this.lblSuccess.ForeColor = System.Drawing.Color.Green;
            this.lblSuccess.Text = "Your reservation has been successfully created";

            // Reference
            this.lblReference.Location = new System.Drawing.Point(30, 100);
            this.lblReference.Size = new System.Drawing.Size(400, 24);
            this.lblReference.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);

            // Guest Name
            this.lblGuestName.Location = new System.Drawing.Point(30, 130);
            this.lblGuestName.Size = new System.Drawing.Size(400, 20);

            // Guest Email
            this.lblGuestEmail.Location = new System.Drawing.Point(30, 150);
            this.lblGuestEmail.Size = new System.Drawing.Size(400, 20);

            // Guest Phone
            this.lblGuestPhone.Location = new System.Drawing.Point(30, 170);
            this.lblGuestPhone.Size = new System.Drawing.Size(400, 20);

            // Hotel
            this.lblHotel.Location = new System.Drawing.Point(30, 190);
            this.lblHotel.Size = new System.Drawing.Size(400, 20);

            // Room
            this.lblRoom.Location = new System.Drawing.Point(30, 210);
            this.lblRoom.Size = new System.Drawing.Size(400, 20);

            // Dates
            this.lblDates.Location = new System.Drawing.Point(30, 230);
            this.lblDates.Size = new System.Drawing.Size(400, 20);

            // Nights
            this.lblNights.Location = new System.Drawing.Point(30, 250);
            this.lblNights.Size = new System.Drawing.Size(400, 20);

            // Guests
            this.lblGuests.Location = new System.Drawing.Point(30, 270);
            this.lblGuests.Size = new System.Drawing.Size(400, 20);

            // Total
            this.lblTotal.Location = new System.Drawing.Point(30, 290);
            this.lblTotal.Size = new System.Drawing.Size(400, 20);

            // Deposit
            this.lblDeposit.Location = new System.Drawing.Point(30, 310);
            this.lblDeposit.Size = new System.Drawing.Size(400, 20);

            // Payment
            this.lblPayment.Location = new System.Drawing.Point(30, 330);
            this.lblPayment.Size = new System.Drawing.Size(400, 20);

            // Confirmation Letter
            this.txtConfirmationLetter.Location = new System.Drawing.Point(450, 100);
            this.txtConfirmationLetter.Size = new System.Drawing.Size(400, 300);
            this.txtConfirmationLetter.Multiline = true;
            this.txtConfirmationLetter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConfirmationLetter.Font = new System.Drawing.Font("Consolas", 10F);

            // Copy Success
            this.lblCopySuccess.Location = new System.Drawing.Point(30, 360);
            this.lblCopySuccess.Size = new System.Drawing.Size(200, 20);
            this.lblCopySuccess.ForeColor = System.Drawing.Color.Green;
            this.lblCopySuccess.Text = "";

            // Close Button
            this.btnClose.Location = new System.Drawing.Point(450, 420);
            this.btnClose.Size = new System.Drawing.Size(100, 32);
            this.btnClose.Text = "Close";

            // Copy Reference Button
            this.btnCopyReference.Location = new System.Drawing.Point(570, 420);
            this.btnCopyReference.Size = new System.Drawing.Size(120, 32);
            this.btnCopyReference.Text = "Copy Reference";

            // Email Button
            this.btnEmail.Location = new System.Drawing.Point(710, 420);
            this.btnEmail.Size = new System.Drawing.Size(140, 32);
            this.btnEmail.Text = "Email Confirmation";

            // Add controls
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.lblGuestEmail);
            this.Controls.Add(this.lblGuestPhone);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblDates);
            this.Controls.Add(this.lblNights);
            this.Controls.Add(this.lblGuests);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.txtConfirmationLetter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCopyReference);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.lblCopySuccess);
        }
    }
}