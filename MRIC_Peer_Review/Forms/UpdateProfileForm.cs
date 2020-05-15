using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        DatabaseQuery db = new DatabaseQuery();


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

            //Loads the Specialism from DB in the Check Box
            string sqlQuery = "Select specialism from specialisms;";
            DataTable dt = db.Read(sqlQuery);
            foreach (DataRow dr in dt.Rows)
            {
                chkListSpecialisms.Items.Add(dr.ItemArray[0].ToString());
            }


        }


    }
}
