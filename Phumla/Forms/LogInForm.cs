using Phumla.Forms;
using System;
using System.Windows.Forms;

namespace PhumlaKamnandiHotelSystem
{
    public partial class LoginForm : Form
    {
        // Form controls
        private Label lblTitle, lblSubtitle, lblUsername, lblPassword, lblError;
        private TextBox txtUsername, txtPassword;
        private Button btnLogin, btnForgotPassword;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // ==== FORM SETTINGS ====
            this.Text = "Phumla Kamnandi Hotels - Sign In";
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.StartPosition = FormStartPosition.CenterScreen;

            // ==== TITLE ====
            lblTitle = new Label();
            lblTitle.Text = "🏨 Phumla Kamnandi Hotels";
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(70, 20);

            lblSubtitle = new Label();
            lblSubtitle.Text = "Receptionist Management System";
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new System.Drawing.Point(90, 55);

            // ==== USERNAME ====
            lblUsername = new Label();
            lblUsername.Text = "Username *";
            lblUsername.Location = new System.Drawing.Point(50, 100);
            lblUsername.AutoSize = true;

            txtUsername = new TextBox();
            txtUsername.Location = new System.Drawing.Point(150, 100);
            txtUsername.Width = 180;
            txtUsername.MaxLength = 50;

            // ==== PASSWORD ====
            lblPassword = new Label();
            lblPassword.Text = "Password *";
            lblPassword.Location = new System.Drawing.Point(50, 150);
            lblPassword.AutoSize = true;

            txtPassword = new TextBox();
            txtPassword.Location = new System.Drawing.Point(150, 150);
            txtPassword.Width = 180;
            txtPassword.PasswordChar = '*';

            // ==== ERROR LABEL ====
            lblError = new Label();
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Location = new System.Drawing.Point(50, 190);
            lblError.Width = 300;
            lblError.AutoSize = false;

            // ==== LOGIN BUTTON ====
            btnLogin = new Button();
            btnLogin.Text = "Sign In";
            btnLogin.Location = new System.Drawing.Point(150, 230);
            btnLogin.Width = 120;
            btnLogin.Click += BtnLogin_Click;

            // ==== FORGOT PASSWORD ====
            btnForgotPassword = new Button();
            btnForgotPassword.Text = "Forgot Password?";
            btnForgotPassword.FlatStyle = FlatStyle.Flat;
            btnForgotPassword.ForeColor = System.Drawing.Color.Blue;
            btnForgotPassword.Location = new System.Drawing.Point(150, 270);
            btnForgotPassword.Width = 120;
            btnForgotPassword.Click += BtnForgotPassword_Click;

            // ==== ADD CONTROLS ====
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblSubtitle);
            this.Controls.Add(lblUsername);
            this.Controls.Add(txtUsername);
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtPassword);
            this.Controls.Add(lblError);
            this.Controls.Add(btnLogin);
            this.Controls.Add(btnForgotPassword);
        }

        // ==== LOGIN LOGIC ====
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = ""; // reset error

            // Validation
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                lblError.Text = "Username is required";
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblError.Text = "Password is required";
                return;
            }
            if (txtUsername.Text.Length > 50)
            {
                lblError.Text = "Username must be 50 characters or less";
                return;
            }

            // Demo credentials
            if (txtUsername.Text == "receptionist" && txtPassword.Text == "password123")
            {
                MessageBox.Show("Login successful! Redirecting to Dashboard...");
                // Show dashboard
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Invalid username or password";
            }
        }

        private void BtnForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact your system administrator for password reset.");
        }
    }
}
