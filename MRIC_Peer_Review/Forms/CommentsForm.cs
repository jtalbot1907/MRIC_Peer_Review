
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

namespace MRIC_Peer_Review
{
    public partial class CommentsForm : Form
    {
        int userId;
        int reviewerId;
        int authorId;
        private ExtractComments GetAllComments;
        private ExtractReviews GetAllRdocs;

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
            GetAllComments = new ExtractComments();
            DataTable dt = GetAllComments.GetAllComments();
            dGridAllComments.DataSource = dt;
        }

        private void LoadReview()
        {
            GetAllRdocs = new ExtractReviews(reviewerId);
            DataTable dt = GetAllRdocs.GetAllRdocs();
            dGridAllReviews.DataSource = dt;
        }
    }
}
