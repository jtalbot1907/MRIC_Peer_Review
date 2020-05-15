using System;
using System.Data;
using System.Windows.Forms;
using MRIC_Peer_Review.Entities;
using MRIC_Peer_Review.Processes;

namespace MRIC_Peer_Review
{
    public partial class PostRdocForm : Form
    {
        DatabaseQuery db = new DatabaseQuery();
        DataTable dt = new DataTable("SelectedrDocSpecialism");
        PostingRDoc reviewRequest;
        TargetingReviewer reviewerSelection;

        public PostRdocForm()
        {
            InitializeComponent();
        }

        private void MakeReviewRequest_Load(object sender, EventArgs e)
        {
            panelMinGrade.Visible = false;
            string sqlQuery = "select specialism from specialisms;";
            DataTable dt = db.Read(sqlQuery);
            foreach (DataRow dr in dt.Rows)
            {
                chkListSpecialisms.Items.Add(dr.ItemArray[0].ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DataColumn col;
            DataRow row;
            col = new DataColumn();
            panelMinGrade.Visible = true;
            col.DataType = Type.GetType("System.String");
            col.ColumnName = "Specialism";
            dt.Columns.Add(col);
            col = new DataColumn();
            col.DataType = Type.GetType("System.Int32");
            col.ColumnName = "MinGrade";
            dt.Columns.Add(col);

            int noOfSpecialisms = chkListSpecialisms.CheckedItems.Count;

            int i = 0;
            foreach (var item in chkListSpecialisms.CheckedItems)
            {
                if (i < noOfSpecialisms)
                {
                    row = dt.NewRow();
                    row["Specialism"] = item.ToString();
                    row["MinGrade"] = 5;
                    dt.Rows.Add(row);
                }
                i++;
            }
            dGridViewMinGrade.DataSource = dt;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                    (
                    " Your Review\r '"+ rtxtTitle.Text.Trim().ToUpper() +"'\r has been successfully Updated.\r" +
                    " ",
                    "Update Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    ); 
            RDoc rDoc = new RDoc();
            int rdocId;
            rDoc.Title = rtxtTitle.Text.Trim().ToUpper();
            rDoc.Link = rtxtLink.Text.Trim().ToLower();
            rDoc.AuthorId = 17; //TODO Hardcode
            rDoc.rDocSpecialism = dt;
            reviewRequest = new PostingRDoc(rDoc);
            reviewRequest.MakeReviewRequest();
            rdocId = reviewRequest.GetLastRDocId();
            btnSubmit.Enabled = false;
            reviewerSelection = new TargetingReviewer(rdocId, rDoc.AuthorId);
            reviewerSelection.CreateReview();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
