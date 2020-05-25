using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using MRIC_Peer_Review.Processes;

namespace MRIC_Peer_Review { 

    public partial class LoginForm : Form
    {
        Thread thread;
        public static int authorId;
        int userId;

        public LoginForm()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //txtUsername.Text = "";
            txtPassword.Text = "12345";
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
                btnLogin.PerformClick();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //username input is not case sensitive
            string username = txtUsername.Text.Trim().ToLower();
            string password = txtPassword.Text;

            LogIn logIn = new LogIn(username, password);
            if (logIn.Authenticate())
            {
                userId = logIn.GetUserId();
                authorId = userId;
                //Login Correct
                this.Close();
                thread = new Thread(openDashboard);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                //Login Incorrect
                MessageBox.Show
                    (
                    " Wrong Username or Password.\r" +
                    "If you are not a Registered User please Register.", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation
                    );
            }
        }

        private void openDashboard()
        {
            Application.Run(new Dashboard(userId));
        }

        private void openRegistrationForm()
        {
            Application.Run(new RegistrationForm());
        }

        private void linkRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            thread = new Thread(openRegistrationForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}