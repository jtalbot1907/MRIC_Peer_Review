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

        private void LoadDataInDataGridView()
        {
            //Extract Data
            ExtractComments extractComments = new ExtractComments();
            dGridRateReview.DataSource = extractComments.GetAllOpenAndLockedComments();

            // Enable DataGrid
            dGridRateReview.Enabled = true;

            // TextWrap in DataGrid
            dGridRateReview.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Hide CommentId an Rate
            dGridRateReview.Columns["CommentId"].Visible = false;
            dGridRateReview.Columns["rate"].Visible = false;

            // Resize column Width in DataGrid
            dGridRateReview.Columns["Title"].FillWeight = 15;
            dGridRateReview.Columns["Comments"].FillWeight = 60;
            dGridRateReview.Columns["Status"].FillWeight = 10;

            // Hide Items
            lblRate.Visible = false;
            numSel.Visible = false;
            btnSubmitReview.Visible = false;
            lblReviewerDiplay.Text = "Click on a row to rate a Comment";
            lblReviewerDiplay.ForeColor = Color.Red;
        }

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            int rate = (int)numSel.Value;
            rateRecorder = new RateRecorder(commentId, rate);
            rateRecorder.RecordRate();
            LoadDataInDataGridView();
        }
        
        private void RateReviewsForm_Load(object sender, EventArgs e)
        {
            LoadDataInDataGridView();
        }

        private void dGridRateReview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGridRateReview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                // Full Row Selection
                dGridRateReview.CurrentRow.Selected = true;

                // Disable DataTable Click
                dGridRateReview.Enabled = false;

                // Comment Selection to be Rated
                commentId = (int)dGridRateReview.Rows[e.RowIndex].Cells["CommentId"].Value;

                // Change State
                lblRate.Visible = true;
                numSel.Visible = true;
                lblReviewerDiplay.ForeColor = Color.SteelBlue;
                lblReviewerDiplay.Text = "Selected Comment:\r\r" + dGridRateReview.Rows[e.RowIndex].Cells["Comments"].FormattedValue.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numSel_ValueChanged(object sender, EventArgs e)
        {
            btnSubmitReview.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataInDataGridView();
        }
    }
}
