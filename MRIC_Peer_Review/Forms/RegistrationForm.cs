using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using MRIC_Peer_Review.Utilities;
using MRIC_Peer_Review.Processes;


namespace MRIC_Peer_Review
{
    public partial class RegistrationForm : Form
    {
        DatabaseQuery db = new DatabaseQuery();
        private Thread thread;

        public RegistrationForm()
        {
            InitializeComponent();
            txtFirstname.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            //Place all selected Specialism into an array - specialismList
            int noOfSpecialisms = chkListSpecialisms.CheckedItems.Count;
            string[] specialismList = new string[noOfSpecialisms];
            int i = 0;
            foreach (var item in chkListSpecialisms.CheckedItems)
            {
                if (i < noOfSpecialisms)
                {
                    specialismList[i] = item.ToString();
                }
                i++;

            }
            btnRegister.Enabled = false;

            User newUser = new User();
            newUser.Firstname = txtFirstname.Text.Trim().ToLower();
            newUser.Surname = txtSurname.Text.Trim().ToLower();
            newUser.Username = txtUsername.Text.Trim().ToLower();
            newUser.Password = Encrypter.Encrypt(txtPassword.Text);
            newUser.SpecialismList = specialismList;

            Registration registration = new Registration();
            registration.Register(newUser);

            MessageBox.Show(" You have registered successfully.\r You can now login with your Username and Password.", "Welcome To MRIC Peer Review", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            thread = new Thread(openLoginForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            //Loads the Specialism from DB in the Check Box
            string sqlQuery = "Select specialism from specialisms;";
            DataTable dt = db.Read(sqlQuery);
            foreach (DataRow dr in dt.Rows)
            {
                chkListSpecialisms.Items.Add(dr.ItemArray[0].ToString());
            }
        }

        private void openLoginForm()
        {
            Application.Run(new LoginForm());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openLoginForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void txtFirstname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSurname.Focus();
            }
        }

        private void txtSurname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUsername.Focus();
            }
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
                chkListSpecialisms.Focus();
            }
        }

        private void chkListSpecialisms_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegister.Focus();
                btnRegister.PerformClick();

            }
        }
    }

}
