using System;
using System.Windows.Forms;

namespace Phumla.Forms
{
    public partial class BookingConfirmationForm : Form
    {
        private readonly BookingDetails bookingDetails;

        public class BookingDetails
        {
            public string BookingReference { get; set; }
            public string GuestName { get; set; }
            public string GuestEmail { get; set; }
            public string GuestPhone { get; set; }
            public string Hotel { get; set; }
            public string RoomName { get; set; }
            public string ArrivalDate { get; set; }
            public string DepartureDate { get; set; }
            public string Nights { get; set; }
            public string Adults { get; set; }
            public string Children { get; set; }
            public int TotalAmount { get; set; }
            public int Deposit { get; set; }
            public string PaymentMethod { get; set; }
        }

        public BookingConfirmationForm()
        {
            InitializeComponent();

            // Example booking details
            bookingDetails = new BookingDetails
            {
                BookingReference = "PK-20251001-0001",
                GuestName = "Mr. John Smith",
                GuestEmail = "john.smith@email.com",
                GuestPhone = "+27 82 123 4567",
                Hotel = "Cape Town",
                RoomName = "Deluxe Ocean View",
                ArrivalDate = "2025-01-15",
                DepartureDate = "2025-01-17",
                Nights = "2",
                Adults = "2",
                Children = "1",
                TotalAmount = 2800,
                Deposit = 560,
                PaymentMethod = "Credit Card"
            };

            PopulateFields();

            btnClose.Click += (s, e) => this.Close();
            btnCopyReference.Click += BtnCopyReference_Click;
            btnEmail.Click += BtnEmail_Click;
        }

        private void PopulateFields()
        {
            lblReference.Text = $"Reference: {bookingDetails.BookingReference}";
            lblGuestName.Text = $"Name: {bookingDetails.GuestName}";
            lblGuestEmail.Text = $"Email: {bookingDetails.GuestEmail}";
            lblGuestPhone.Text = $"Phone: {bookingDetails.GuestPhone}";
            lblHotel.Text = $"Hotel: {bookingDetails.Hotel}";
            lblRoom.Text = $"Room: {bookingDetails.RoomName}";
            lblDates.Text = $"Check-in: {DateTime.Parse(bookingDetails.ArrivalDate):ddd, dd MMM yyyy}   Check-out: {DateTime.Parse(bookingDetails.DepartureDate):ddd, dd MMM yyyy}";
            lblNights.Text = $"Duration: {bookingDetails.Nights} nights";
            lblGuests.Text = $"Guests: {bookingDetails.Adults} Adults, {bookingDetails.Children} Child";
            lblTotal.Text = $"Total Amount: R{bookingDetails.TotalAmount:N0}";
            lblDeposit.Text = $"Deposit Paid: R{bookingDetails.Deposit:N0}";
            lblPayment.Text = $"Payment Method: {bookingDetails.PaymentMethod}";

            txtConfirmationLetter.Text =
$@"Dear {bookingDetails.GuestName},

Thank you for choosing Phumla Kamnandi Hotels. We are pleased to confirm your reservation.

BOOKING CONFIRMATION
Reservation Reference: {bookingDetails.BookingReference}
Guest Name: {bookingDetails.GuestName}
Hotel: Phumla Kamnandi Hotel - {bookingDetails.Hotel}
Room Type: {bookingDetails.RoomName}

CHECK-IN DETAILS
Date: Wednesday, 15 January 2025
Time: 14:00 (2:00 PM)

CHECK-OUT DETAILS  
Date: Friday, 17 January 2025
Time: 11:00 (11:00 AM)

Duration: {bookingDetails.Nights} nights
Guests: {bookingDetails.Adults} Adults, {bookingDetails.Children} Child

PAYMENT INFORMATION
Total Amount: R{bookingDetails.TotalAmount:N0}
Deposit Paid: R{bookingDetails.Deposit:N0}
Payment Method: {bookingDetails.PaymentMethod}

Please present this confirmation and a valid ID upon check-in. 

For any changes or inquiries, please contact us at:
Phone: +27 11 123 4567
Email: reservations@phumlakamnandi.co.za

We look forward to welcoming you to Phumla Kamnandi Hotels.

Best regards,
Phumla Kamnandi Hotels Reservations Team";
        }

        private void BtnCopyReference_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(bookingDetails.BookingReference);
                lblCopySuccess.Text = "Copied!";
                var timer = new Timer { Interval = 2000 };
                timer.Tick += (s, args) =>
                {
                    lblCopySuccess.Text = "";
                    timer.Stop();
                    timer.Dispose();
                };
                timer.Start();
            }
            catch
            {
                MessageBox.Show("Failed to copy reference.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Confirmation email sent to {bookingDetails.GuestEmail}", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}