using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Phumla.Forms
{
    public partial class GuestLookupForm : Form
    {
        private class Guest
        {
            public string Id { get; set; }
            public string Title { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string IdNumber { get; set; }
            public string Address { get; set; }
            public string LoyaltyCard { get; set; }
        }

        private List<Guest> mockGuests;
        private Guest foundGuest;

        public GuestLookupForm()
        {
            InitializeComponent();

            mockGuests = new List<Guest>
            {
                new Guest { Id = "1", Title = "Mr", FirstName = "John", LastName = "Doe", Phone = "+27 11 123 4567", Email = "john.doe@email.com", IdNumber = "8001015009087", Address = "123 Main Street, Johannesburg, 2000, Gauteng, South Africa", LoyaltyCard = "PK001234" },
                new Guest { Id = "2", Title = "Ms", FirstName = "Sarah", LastName = "Smith", Phone = "+27 21 987 6543", Email = "sarah.smith@email.com", IdNumber = "8505123456789", Address = "456 Oak Avenue, Cape Town, 8001, Western Cape, South Africa", LoyaltyCard = "" },
                new Guest { Id = "3", Title = "Dr", FirstName = "Michael", LastName = "Johnson", Phone = "+27 31 456 7890", Email = "m.johnson@email.com", IdNumber = "7712084567890", Address = "789 Beach Road, Durban, 4001, KwaZulu-Natal, South Africa", LoyaltyCard = "PK005678" }
            };

            btnSearch.Click += BtnSearch_Click;
            btnShowAddGuest.Click += (s, e) => ShowAddGuestForm();
            btnSaveGuest.Click += BtnSaveGuest_Click;
            btnCancelAdd.Click += (s, e) => HideAddGuestForm();
            btnUseGuest.Click += BtnUseGuest_Click;

            HideGuestDetails();
            HideAddGuestForm();
            lblNoGuestFound.Visible = false;
            btnShowAddGuest.Visible = false;

            //SetPlaceholder(txtFirstName, "First Name");
            //SetPlaceholder(txtLastName, "Last Name");
            //SetPlaceholder(txtPhone, "Phone (+27 xxx xxx xxxx)");
            //SetPlaceholder(txtEmail, "Email (optional)");
            //SetPlaceholder(txtIdNumber, "ID/Passport (optional)");
            //SetPlaceholder(txtLoyaltyCard, "Loyalty Card (optional)");
            //SetPlaceholder(txtAddress, "Address (optional)");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim();
            foundGuest = null;
            HideGuestDetails();
            HideAddGuestForm();
            lblNoGuestFound.Visible = false;
            btnShowAddGuest.Visible = false;

            if (string.IsNullOrEmpty(query))
                return;

            foreach (var guest in mockGuests)
            {
                if (guest.Phone.Contains(query) ||
                    guest.Email.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    guest.IdNumber.Contains(query) ||
                    $"{guest.FirstName} {guest.LastName}".IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    foundGuest = guest;
                    break;
                }
            }

            if (foundGuest != null)
            {
                ShowGuestDetails(foundGuest);
            }
            else
            {
                lblNoGuestFound.Text = "No guest found matching your search.";
                lblNoGuestFound.Visible = true;
                btnShowAddGuest.Visible = true;
            }
        }

        private void ShowGuestDetails(Guest guest)
        {
            lblGuestDetails.Text =
                $"Name: {guest.Title} {guest.FirstName} {guest.LastName}\r\n" +
                $"Phone: {guest.Phone}\r\n" +
                $"Email: {guest.Email}\r\n" +
                $"ID/Passport: {guest.IdNumber}\r\n" +
                (!string.IsNullOrEmpty(guest.LoyaltyCard) ? $"Loyalty Card: {guest.LoyaltyCard}\r\n" : "") +
                (!string.IsNullOrEmpty(guest.Address) ? $"Address: {guest.Address}\r\n" : "");
            grpGuestDetails.Visible = true;
        }

        private void HideGuestDetails()
        {
            grpGuestDetails.Visible = false;
        }

        private void ShowAddGuestForm()
        {
            grpAddGuest.Visible = true;
            lblAddGuestError.Text = "";
            cmbTitle.SelectedIndex = -1;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtIdNumber.Text = "";
            txtLoyaltyCard.Text = "";
            txtAddress.Text = "";
        }

        private void HideAddGuestForm()
        {
            grpAddGuest.Visible = false;
            lblAddGuestError.Text = "";
        }

        private void BtnSaveGuest_Click(object sender, EventArgs e)
        {
            lblAddGuestError.Text = "";
            // Validation
            if (cmbTitle.SelectedIndex == -1)
            {
                lblAddGuestError.Text = "Title is required.";
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                lblAddGuestError.Text = "First name is required.";
                return;
            }
            if (txtFirstName.Text.Length > 50)
            {
                lblAddGuestError.Text = "First name must be 50 characters or less.";
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                lblAddGuestError.Text = "Last name is required.";
                return;
            }
            if (txtLastName.Text.Length > 50)
            {
                lblAddGuestError.Text = "Last name must be 50 characters or less.";
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                lblAddGuestError.Text = "Phone number is required.";
                return;
            }
            if (!Regex.IsMatch(txtPhone.Text, @"^\+27\s\d{2,3}\s\d{3}\s\d{4}$"))
            {
                lblAddGuestError.Text = "Phone must be in format +27 xxx xxx xxxx.";
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !Regex.IsMatch(txtEmail.Text, @"^[^\s@]+@[^\s@]+\.[^\s@]+$"))
            {
                lblAddGuestError.Text = "Please enter a valid email address.";
                return;
            }

            // Save guest
            foundGuest = new Guest
            {
                Id = DateTime.Now.Ticks.ToString(),
                Title = cmbTitle.SelectedItem.ToString(),
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                IdNumber = txtIdNumber.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                LoyaltyCard = txtLoyaltyCard.Text.Trim()
            };
            mockGuests.Add(foundGuest);
            HideAddGuestForm();
            ShowGuestDetails(foundGuest);
            lblNoGuestFound.Visible = false;
            btnShowAddGuest.Visible = false;
        }

        private void BtnUseGuest_Click(object sender, EventArgs e)
        {
            if (foundGuest == null) return;
            MessageBox.Show($"Guest selected: {foundGuest.Title} {foundGuest.FirstName} {foundGuest.LastName}", "Guest Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // TODO: Pass guest info to next booking/payment step
        }

        //private void SetPlaceholder(TextBox txt, string placeholder)
        //{
        //    txt.ForeColor = System.Drawing.Color.Gray;
        //    txt.Text = placeholder;

        //    txt.GotFocus += (s, e) =>
        //    {
        //        if (txt.Text == placeholder)
        //        {
        //            txt.Text = "";
        //            txt.ForeColor = System.Drawing.Color.Black;
        //        }
        //    };

        //    txt.LostFocus += (s, e) =>
        //    {
        //        if (string.IsNullOrWhiteSpace(txt.Text))
        //        {
        //            txt.Text = placeholder;
        //            txt.ForeColor = System.Drawing.Color.Gray;
        //        }
        //    };
        //}
    }
}