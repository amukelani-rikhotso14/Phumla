using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla.Forms
{
    public partial class BookingPaymentForm : Form
    {
        private bool isProcessing = false;

        public BookingPaymentForm()
        {
            InitializeComponent();



            // Example booking details
            lblHotel.Text = "Hotel: Cape Town";
            lblRoomType.Text = "Room Type: Deluxe Ocean View";
            lblCheckIn.Text = "Check-in: Wed, 15 Jan 2025";
            lblCheckOut.Text = "Check-out: Fri, 17 Jan 2025";
            lblGuests.Text = "Guests: 2 Adults, 1 Child";
            lblNights.Text = "Nights: 2";
            lblTotalPrice.Text = "Total Price: R2,800";
            lblDeposit.Text = "Deposit Required: R560";

            cmbPaymentMethod.SelectedIndexChanged += CmbPaymentMethod_SelectedIndexChanged;
            btnConfirm.Click += BtnConfirm_Click;
            btnBack.Click += (s, e) => this.Close();

            txtCardNumber.TextChanged += (s, e) => { txtCardNumber.Text = FormatCardNumber(txtCardNumber.Text); txtCardNumber.SelectionStart = txtCardNumber.Text.Length; };
            txtExpiry.TextChanged += (s, e) => { txtExpiry.Text = FormatExpiry(txtExpiry.Text); txtExpiry.SelectionStart = txtExpiry.Text.Length; };
            txtCVV.TextChanged += (s, e) => { txtCVV.Text = Regex.Replace(txtCVV.Text, @"\D", ""); txtCVV.SelectionStart = txtCVV.Text.Length; };

            
            SetPlaceholder(txtCardNumber, "Card Number (16 digits)");
            SetPlaceholder(txtExpiry, "MM/YY");
            SetPlaceholder(txtCVV, "CVV");
        }

        // Add this method to your BookingPaymentForm class
        public void SetPlaceholder(TextBox txt, string placeholder)
        {
            txt.ForeColor = System.Drawing.Color.Gray;
            txt.Text = placeholder;

            txt.GotFocus += (s, e) =>
            {
                if (txt.Text == placeholder)
                {
                    txt.Text = "";
                    txt.ForeColor = System.Drawing.Color.Black;
                }
            };

            txt.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholder;
                    txt.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private void CmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlCreditCard.Visible = cmbPaymentMethod.SelectedIndex == 0;
            pnlCash.Visible = cmbPaymentMethod.SelectedIndex == 1;
            pnlAgentInvoice.Visible = cmbPaymentMethod.SelectedIndex == 2;
            lblPaymentMethodError.Text = "";
        }

        private async void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (isProcessing) return;
            lblConfirmation.Visible = false;
            lblPaymentMethodError.Text = "";
            lblCardNumberError.Text = "";
            lblExpiryError.Text = "";
            lblCVVError.Text = "";

            if (cmbPaymentMethod.SelectedIndex == -1)
            {
                lblPaymentMethodError.Text = "Please select a payment method.";
                return;
            }

            if (cmbPaymentMethod.SelectedIndex == 0) // Credit Card
            {
                bool valid = true;
                string cardNumber = txtCardNumber.Text.Replace(" ", "");
                if (string.IsNullOrWhiteSpace(cardNumber))
                {
                    lblCardNumberError.Text = "Card number is required.";
                    valid = false;
                }
                else if (!Regex.IsMatch(cardNumber, @"^\d{16}$"))
                {
                    lblCardNumberError.Text = "Please enter a valid 16-digit card number.";
                    valid = false;
                }
                else if (!ValidateLuhn(cardNumber))
                {
                    lblCardNumberError.Text = "Invalid card number (Luhn validation failed).";
                    valid = false;
                }

                if (string.IsNullOrWhiteSpace(txtExpiry.Text))
                {
                    lblExpiryError.Text = "Expiry date is required.";
                    valid = false;
                }
                else if (!Regex.IsMatch(txtExpiry.Text, @"^(0[1-9]|1[0-2])\/\d{2}$"))
                {
                    lblExpiryError.Text = "Please enter date in MM/YY format.";
                    valid = false;
                }

                if (string.IsNullOrWhiteSpace(txtCVV.Text))
                {
                    lblCVVError.Text = "CVV is required.";
                    valid = false;
                }
                else if (!Regex.IsMatch(txtCVV.Text, @"^\d{3}$"))
                {
                    lblCVVError.Text = "Please enter a valid 3-digit CVV.";
                    valid = false;
                }

                if (!valid) return;
            }

            isProcessing = true;
            btnConfirm.Enabled = false;
            btnConfirm.Text = "Processing...";

            await Task.Delay(2000); // Simulate payment processing

            lblConfirmation.Text = "Reservation complete. Reference: PK-20251001-0001";
            lblConfirmation.Visible = true;
            btnConfirm.Text = "Booking Confirmed";
            btnConfirm.Enabled = false;
            isProcessing = false;
        }

        private string FormatCardNumber(string value)
        {
            var v = Regex.Replace(value, @"\D", "");
            var result = "";
            for (int i = 0; i < v.Length && i < 16; i += 4)
            {
                if (i > 0) result += " ";
                result += v.Substring(i, Math.Min(4, v.Length - i));
            }
            return result;
        }

        private string FormatExpiry(string value)
        {
            var v = Regex.Replace(value, @"\D", "");
            if (v.Length > 2)
                return v.Substring(0, 2) + "/" + v.Substring(2, Math.Min(2, v.Length - 2));
            return v;
        }

        private bool ValidateLuhn(string cardNumber)
        {
            int sum = 0;
            bool isEven = false;
            for (int i = cardNumber.Length - 1; i >= 0; i--)
            {
                int digit = cardNumber[i] - '0';
                if (isEven)
                {
                    digit *= 2;
                    if (digit > 9) digit -= 9;
                }
                sum += digit;
                isEven = !isEven;
            }
            return sum % 10 == 0;
        }
    }
}