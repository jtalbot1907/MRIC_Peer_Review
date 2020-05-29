using System;
using System.Data;
using System.Drawing.Text;
using System.Windows.Forms;
using MRIC_Peer_Review.Processes;

namespace MRIC_Peer_Review.Forms
{
    public partial class UpdateProfileForm : Form
    {
        int userId;
        string firstName;
        string surname;
        string password;
        string username;
        private LogIn GetSpec;

        DatabaseQuery db = new DatabaseQuery();
        DataTable dtSpecialism = new DataTable();
        DataTable dtSpec = new DataTable();


        public UpdateProfileForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            firstName = new LogIn(userId).GetFirstName();
            txtFirstname.Text = firstName;
            surname = new LogIn(userId).GetSurname();
            txtSurname.Text = surname;
            username = new LogIn(userId).GetUsername();
            txtUsername.Text = username;
            txtPassword.Text = password;

            GetSpec = new LogIn(userId);
            DataTable dt = GetSpec.GetSpecialism();
            dGridSpecialism.DataSource = dt;
            DataGridViewColumn dtCol = dGridSpecialism.Columns[1];
            dtCol.FillWeight = 20;

            //Loads the Specialism from DB in the Check Box
            string sqlQuery = "Select specialism from specialisms;";
            DataTable dtSpec = db.Read(sqlQuery);
            foreach (DataRow dr in dtSpec.Rows)
            {
                chkListSpecialisms.Items.Add(dr.ItemArray[0].ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
