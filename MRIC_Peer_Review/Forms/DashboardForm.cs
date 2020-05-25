using System;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using MRIC_Peer_Review.Forms;
using MRIC_Peer_Review.Processes;

namespace MRIC_Peer_Review
{
    public partial class Dashboard : Form
    {
        private Thread thread;
        private int userId;
        private int reviewerId;
        private string fullName;
        private DataTable dtSpecialism;
        DataTable dt = new DataTable();
        //DataTable dt = new DataTable();

        ExtractReviews reviewTaskExtractor;

        public Dashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            fullName = new LogIn(userId).GetFullName();
            this.lblWelcome.Text = "Welcome,  "+fullName+".";

            dtSpecialism = new LogIn(reviewerId).GetSpecialism();
            dataGridView1.DataSource = dtSpecialism;
           

        }

        private void openLoginForm()
        {
            Application.Run(new LoginForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openLoginForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenDashboard()
        {
            Application.Run(new PostRdocForm());
        }

        private void btnPostRDoc_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenDashboard);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenReviewTasks()
        {
            Application.Run(new ReviewTasks(userId));
        }

        private void btnCommentReviews_Click(object sender, EventArgs e)
        {
            //this.Close();
            thread = new Thread(OpenReviewTasks);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenRegistrationUpdate()
        {
            Application.Run(new UpdateProfileForm(userId));
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenRegistrationUpdate);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenCommentsForm()
        {
            Application.Run(new CommentsForm());
        }

        private void btnViewAllComments_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenCommentsForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenRateReviewsForm()
        {
            Application.Run(new RateReviewsForm());
        }

        private void btnRateReviews_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenRateReviewsForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnWebsite_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.mric.mu/");
        }
    }   
}
