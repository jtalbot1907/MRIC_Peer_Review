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

namespace MRIC_Peer_Review.Forms
{
    public partial class RateReviewsForm : Form
    {
        int commentId;

        RateRecorder rateRecorder;
        public RateReviewsForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            int rate = (int)numericUpDown1.Value;
            rateRecorder = new RateRecorder(commentId, rate);
            rateRecorder.RecordRate();
            LoadDataInDataGridView();
        }

        private void LoadDataInDataGridView()
        {
            ExtractComments extractComments = new ExtractComments();
            dGridRateReview.DataSource = extractComments.GetAllOpenAndLockedComments();
            dGridRateReview.Columns["commentId"].Visible = false;
        }

        private void RateReviewsForm_Load(object sender, EventArgs e)
        {
            LoadDataInDataGridView();
        }

        private void dGridRateReview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            commentId = (int)dGridRateReview.Rows[e.RowIndex].Cells["commentId"].Value;
        }
    }
}
