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
            DatabaseQuery db = new DatabaseQuery();
            DataTable dt = new DataTable();

           //Extract Data
            ExtractComments extractComments = new ExtractComments();
            dGridAllComments.DataSource = extractComments.GetAllComments();

            // TextWrap in DataGrid
            dGridAllComments.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            //    // Hide CommentId an Rate
            //    dGridRateReview.Columns["CommentId"].Visible = false;
            //    dGridRateReview.Columns["rate"].Visible = false;

            // Resize column Width in DataGrid
            dGridAllComments.Columns[0].FillWeight = 15;
            dGridAllComments.Columns[1].FillWeight = 60;
            dGridAllComments.Columns[2].FillWeight = 10;
            dGridAllComments.Columns[3].FillWeight = 60;
            dGridAllComments.Columns[4].FillWeight = 8;

        }

        private void LoadReview()
        {

        }

    }
}
