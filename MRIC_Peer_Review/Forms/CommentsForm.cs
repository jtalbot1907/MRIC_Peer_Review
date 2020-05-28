using MRIC_Peer_Review.Processes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRIC_Peer_Review
{
    public partial class CommentsForm : Form
    {
        int userId;
        int reviewerId;
        int authorId;
        private ExtractComments GetComments;
        private ExtractReviews GetReviews;

        DatabaseQuery db = new DatabaseQuery();
        DataTable dt = new DataTable();

        public CommentsForm()
        {
            InitializeComponent();
        }

        private void CommentsForm_Load(object sender, EventArgs e)
        {
            LoadComments();
            LoadReview();
        }

        private void LoadComments()
        {
            GetComments = new ExtractComments();
            DataTable dt = GetComments.GetAllComments();
            dGridAllComments.DataSource = dt;
        }

        private void LoadReview()
        {
            GetReviews = new ExtractReviews(reviewerId);
            DataTable dt = GetReviews.GetAllRdocs();
            dGridAllReviews.DataSource = dt;
        }

     
       

    }
}
