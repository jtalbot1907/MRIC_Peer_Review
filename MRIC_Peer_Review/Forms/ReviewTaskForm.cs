
using System;
using System.Data;
using System.Windows.Forms;
using MRIC_Peer_Review.Entities;
using MRIC_Peer_Review.Processes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MRIC_Peer_Review
{
    public partial class ReviewTasks : Form
    {
       
// this is an identifier for git.......    


        int reviewerId;
        int reviewId;
        string link;
        DatabaseQuery db = new DatabaseQuery();
        DataTable dt = new DataTable();
        private readonly ExtractReviews reviewTaskExtractor;

        public ReviewTasks(int reviewerId)
        {
            InitializeComponent();
            this.reviewerId = reviewerId;
            reviewTaskExtractor = new ExtractReviews(reviewerId);
        }

        private void Initialisation()
        {
            // Enable DataGrid
            dGridAll.Enabled = true;
            dGridAwaiting.Enabled = true;
            dGridOpen.Enabled = true;
            dGridLocked.Enabled = true;
            dGridClosed.Enabled = true;

            //Hide label and panel
            pnlComment.Visible = false;
            lblRefresh.Visible = false;
            lblRateReview.Visible = false;
            btnSubmitReview.Visible = false;
            btnGoToLink.Visible = false;

            //Set Label to blue color
            lblReviewerDiplay.ForeColor = Color.SteelBlue;

            tabReviews.Cursor = Cursors.IBeam;

            //Load Data in DataGrid
            DataTable dtAll = reviewTaskExtractor.GetReviewsAllStatus();
            DataTable dtAwaiting = reviewTaskExtractor.GetReviewsAwaiting();
            DataTable dtOpen = reviewTaskExtractor.GetReviewsOpen();
            DataTable dtLocked = reviewTaskExtractor.GetReviewsLocked();
            DataTable dtClosed = reviewTaskExtractor.GetReviewsClosed();
            dGridAll.DataSource = dtAll;
            dGridAwaiting.DataSource = dtAwaiting;
            dGridOpen.DataSource = dtOpen;
            dGridLocked.DataSource = dtLocked;
            dGridClosed.DataSource = dtClosed;

            //Text Wrap in DataGrid
            dGridAll.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dGridAwaiting.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dGridOpen.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dGridLocked.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dGridClosed.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            //Hide Data ReviewId in DataGrid
            DataGridViewColumn dGridAllColreviewId = dGridAll.Columns["reviewId"];
            DataGridViewColumn dGridAwaitingColreviewId = dGridAwaiting.Columns["reviewId"];
            DataGridViewColumn dGridOpenColreviewId = dGridOpen.Columns["reviewId"];
            DataGridViewColumn dGridLockedColreviewId = dGridLocked.Columns["reviewId"];
            DataGridViewColumn dGridClosedColreviewId = dGridClosed.Columns["reviewId"];
            dGridAllColreviewId.Visible = false;
            dGridAwaitingColreviewId.Visible = false;
            dGridOpenColreviewId.Visible = false;
            dGridLockedColreviewId.Visible = false;
            dGridClosedColreviewId.Visible = false;

            //Hide Data Link in DataGrid
            DataGridViewColumn dGridAllColLink = dGridAll.Columns["Link"];
            DataGridViewColumn dGridAwaitingColLink = dGridAwaiting.Columns["Link"];
            DataGridViewColumn dGridOpenColLink = dGridOpen.Columns["Link"];
            DataGridViewColumn dGridLockedColLink = dGridLocked.Columns["Link"];
            DataGridViewColumn dGridClosedColLink = dGridClosed.Columns["Link"];
            dGridAllColLink.Visible = false;
            dGridAwaitingColLink.Visible = false;
            dGridOpenColLink.Visible = false;
            dGridLockedColLink.Visible = false;
            dGridClosedColLink.Visible = false;

            //Set Status Column Width
            DataGridViewColumn dGridAllColStatus = dGridAll.Columns["Status"];
            DataGridViewColumn dGridAwaitingColStatus = dGridAwaiting.Columns["Status"];
            DataGridViewColumn dGridOpenColStatus = dGridOpen.Columns["Status"];
            DataGridViewColumn dGridLockedColStatus = dGridLocked.Columns["Status"];
            DataGridViewColumn dGridClosedColStatus = dGridClosed.Columns["Status"];
            dGridAllColStatus.FillWeight = 12;
            dGridAwaitingColStatus.FillWeight = 12;
            dGridOpenColStatus.FillWeight = 12;
            dGridLockedColStatus.FillWeight = 12;
            dGridClosedColStatus.FillWeight = 12;

            //Set Specialism Column Width
            DataGridViewColumn dGridAllColSpecialism = dGridAll.Columns["Specialism"];
            DataGridViewColumn dGridAwaitingColSpecialism = dGridAwaiting.Columns["Specialism"];
            DataGridViewColumn dGridOpenColSpecialism = dGridOpen.Columns["Specialism"];
            DataGridViewColumn dGridLockedColSpecialism = dGridLocked.Columns["Specialism"];
            DataGridViewColumn dGridClosedColSpecialism = dGridClosed.Columns["Specialism"];
            dGridAllColSpecialism.FillWeight = 35;
            dGridAwaitingColSpecialism.FillWeight = 35;
            dGridOpenColSpecialism.FillWeight = 35;
            dGridLockedColSpecialism.FillWeight = 35;
            dGridClosedColSpecialism.FillWeight = 35;
        }

        private void ReviewTasks_Load(object sender, EventArgs e)
        {
            Initialisation();
        }

        private void DGridAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGridAll.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                btnGoToLink.Visible = true;
                dGridAll.CurrentRow.Selected = true;
                reviewId = (int)dGridAll.Rows[e.RowIndex].Cells["reviewId"].Value;
                link = (string)dGridAll.Rows[e.RowIndex].Cells["link"].FormattedValue.ToString();

                if (dGridAll.Rows[e.RowIndex].Cells["Status"].Value.Equals("awaiting")
                    ||
                    dGridAll.Rows[e.RowIndex].Cells["Status"].Value.Equals("open"))
                {
                    dGridAll.Enabled = false;
                    dGridAwaiting.Enabled = false;
                    dGridOpen.Enabled = false;
                    dGridLocked.Enabled = false;
                    dGridClosed.Enabled = false;

                    tabReviews.Cursor = Cursors.No;

                    pnlComment.Visible = true;
                    lblRefresh.Visible = true;
                    lblReviewerDiplay.ForeColor = Color.SteelBlue;
                    lblReviewerDiplay.Text = "Selected Review:\r\r"+ dGridAll.Rows[e.RowIndex].Cells["Title"].FormattedValue.ToString();
                }
                else
                {
                    pnlComment.Visible = false;
                    lblRefresh.Visible = false;
                    lblReviewerDiplay.ForeColor = Color.Red;
                    lblReviewerDiplay.Text = "Review is already "+ dGridAll.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
                }
            }
            else
            {
                pnlComment.Visible = false;
                lblRefresh.Visible = false;
            }
        }

        private void DGridAwaiting_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGridAwaiting.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                btnGoToLink.Visible = true;
                dGridAwaiting.CurrentRow.Selected = true;
                reviewId = (int)dGridAwaiting.Rows[e.RowIndex].Cells["reviewId"].Value;
                link = (string)dGridAwaiting.Rows[e.RowIndex].Cells["link"].FormattedValue.ToString();

                if (dGridAwaiting.Rows[e.RowIndex].Cells["Status"].Value.Equals("awaiting")
                    ||
                    dGridAwaiting.Rows[e.RowIndex].Cells["Status"].Value.Equals("open"))
                {
                    dGridAll.Enabled = false;
                    dGridAwaiting.Enabled = false;
                    dGridOpen.Enabled = false;
                    dGridLocked.Enabled = false;
                    dGridClosed.Enabled = false;

                    tabReviews.Cursor = Cursors.No;

                    pnlComment.Visible = true;
                    lblRefresh.Visible = true;
                    lblReviewerDiplay.ForeColor = Color.SteelBlue;
                    lblReviewerDiplay.Text = "Selected Review:\r\r" + dGridAwaiting.Rows[e.RowIndex].Cells["Title"].FormattedValue.ToString();
                }
                else
                {
                    pnlComment.Visible = false;
                    lblRefresh.Visible = false;
                    lblReviewerDiplay.ForeColor = Color.Red;
                    lblReviewerDiplay.Text = "Review is already " + dGridAwaiting.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
                }
            }
            else
            {
                pnlComment.Visible = false;
                lblRefresh.Visible = false;
            }
        }

        private void DGridOpen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGridOpen.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                btnGoToLink.Visible = true;
                dGridOpen.CurrentRow.Selected = true;
                reviewId = (int)dGridOpen.Rows[e.RowIndex].Cells["reviewId"].Value;
                link = (string)dGridOpen.Rows[e.RowIndex].Cells["link"].FormattedValue.ToString();

                if (dGridOpen.Rows[e.RowIndex].Cells["Status"].Value.Equals("awaiting")
                    ||
                    dGridOpen.Rows[e.RowIndex].Cells["Status"].Value.Equals("open"))
                {
                    dGridAll.Enabled = false;
                    dGridAwaiting.Enabled = false;
                    dGridOpen.Enabled = false;
                    dGridLocked.Enabled = false;
                    dGridClosed.Enabled = false;

                    tabReviews.Cursor = Cursors.No; 
                    
                    pnlComment.Visible = true;
                    lblRefresh.Visible = true;
                    lblReviewerDiplay.ForeColor = Color.SteelBlue;
                    lblReviewerDiplay.Text = "Selected Review:\r\r" + dGridOpen.Rows[e.RowIndex].Cells["Title"].FormattedValue.ToString();
                }
                else
                {
                    pnlComment.Visible = false;
                    lblRefresh.Visible = false;
                    lblReviewerDiplay.ForeColor = Color.Red;
                    lblReviewerDiplay.Text = "Review is already " + dGridOpen.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
                }
            }
            else
            {
                pnlComment.Visible = false;
                lblRefresh.Visible = false;
            }
        }

        private void DGridLocked_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGridLocked.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                

                btnGoToLink.Visible = true;
                dGridLocked.CurrentRow.Selected = true;
                reviewId = (int)dGridLocked.Rows[e.RowIndex].Cells["reviewId"].Value;
                link = (string)dGridLocked.Rows[e.RowIndex].Cells["link"].FormattedValue.ToString();

                if (dGridLocked.Rows[e.RowIndex].Cells["Status"].Value.Equals("awaiting")
                    ||
                    dGridLocked.Rows[e.RowIndex].Cells["Status"].Value.Equals("open"))
                {
                    dGridAll.Enabled = false;
                    dGridAwaiting.Enabled = false;
                    dGridOpen.Enabled = false;
                    dGridLocked.Enabled = false;
                    dGridClosed.Enabled = false;

                    tabReviews.Cursor = Cursors.No; 

                    pnlComment.Visible = true;
                    lblRefresh.Visible = true;
                    lblReviewerDiplay.ForeColor = Color.SteelBlue;
                    lblReviewerDiplay.Text = "Selected Review:\r\r" + dGridLocked.Rows[e.RowIndex].Cells["Title"].FormattedValue.ToString();
                }
                else
                {
                    pnlComment.Visible = false;
                    lblRefresh.Visible = false;
                    lblReviewerDiplay.ForeColor = Color.Red;
                    lblReviewerDiplay.Text = "Review is already " + dGridLocked.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
                }
            }
            else
            {
                pnlComment.Visible = false;
                lblRefresh.Visible = false;
            }
        }

        private void DGridClosed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGridClosed.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                btnGoToLink.Visible = true;
                dGridClosed.CurrentRow.Selected = true;
                reviewId = (int)dGridClosed.Rows[e.RowIndex].Cells["reviewId"].Value;
                link = (string)dGridClosed.Rows[e.RowIndex].Cells["link"].FormattedValue.ToString();

                if (dGridClosed.Rows[e.RowIndex].Cells["Status"].Value.Equals("awaiting")
                    ||
                    dGridClosed.Rows[e.RowIndex].Cells["Status"].Value.Equals("open"))
                {
                    dGridAll.Enabled = false;
                    dGridAwaiting.Enabled = false;
                    dGridOpen.Enabled = false;
                    dGridLocked.Enabled = false;
                    dGridClosed.Enabled = false;

                    tabReviews.Cursor = Cursors.No; 
                    
                    pnlComment.Visible = true;
                    lblRefresh.Visible = true;
                    lblReviewerDiplay.ForeColor = Color.SteelBlue;
                    lblReviewerDiplay.Text = "Selected Review:\r\r" + dGridClosed.Rows[e.RowIndex].Cells["Title"].FormattedValue.ToString();
                }
                else
                {
                    pnlComment.Visible = false;
                    lblRefresh.Visible = false;
                    lblReviewerDiplay.ForeColor = Color.Red;
                    lblReviewerDiplay.Text = "Review is already " + dGridClosed.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
                }
            }
            else
            {
                pnlComment.Visible = false;
                lblRefresh.Visible = false;
            }
        }
       
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if(txtBoxReview.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show
                    (
                    " Refreshing will discard existing comment.\r Do you want to proceed.", " Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Stop
                    );
                if (result == DialogResult.Yes)
                {
                    Initialisation();
                    txtBoxReview.Text = "";
                }
            }
            else
            {
                Initialisation();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (txtBoxReview.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show
                    (
                    " Comment has not been submitted.\r Closing will discard existing comment.\r Do you want to proceed.", " Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                    );
                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void txtBoxReview_TextChanged(object sender, EventArgs e)
        {
            numRate.Visible = true;
            lblRateReview.Visible = true;
        }

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                    (
                    " Your comment has been successfully Updated.\r" +
                    " ",
                    "Update Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            string comment = txtBoxReview.Text;
            int rate = (int)numRate.Value;
            Commenting commenting = new Commenting(reviewId, comment, rate);
            commenting.SaveComment();
            Initialisation();
        }

        private void numRate_ValueChanged(object sender, EventArgs e)
        {
            btnSubmitReview.Visible = true;
        }

        private void btnGoToLink_Click(object sender, EventArgs e)
        {
            Process.Start(link);
        }
    }
}