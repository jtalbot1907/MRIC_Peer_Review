namespace MRIC_Peer_Review.Forms
{
    partial class RateReviewsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGridRateReview = new System.Windows.Forms.DataGridView();
            this.lblReviewerDiplay = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dGridRateReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridRateReview
            // 
            this.dGridRateReview.AllowUserToAddRows = false;
            this.dGridRateReview.AllowUserToDeleteRows = false;
            this.dGridRateReview.AllowUserToResizeColumns = false;
            this.dGridRateReview.AllowUserToResizeRows = false;
            this.dGridRateReview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridRateReview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGridRateReview.BackgroundColor = System.Drawing.Color.Silver;
            this.dGridRateReview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGridRateReview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dGridRateReview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGridRateReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridRateReview.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dGridRateReview.GridColor = System.Drawing.Color.White;
            this.dGridRateReview.Location = new System.Drawing.Point(36, 79);
            this.dGridRateReview.Name = "dGridRateReview";
            this.dGridRateReview.ReadOnly = true;
            this.dGridRateReview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridRateReview.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridRateReview.RowHeadersVisible = false;
            this.dGridRateReview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dGridRateReview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridRateReview.ShowCellErrors = false;
            this.dGridRateReview.ShowCellToolTips = false;
            this.dGridRateReview.ShowEditingIcon = false;
            this.dGridRateReview.ShowRowErrors = false;
            this.dGridRateReview.Size = new System.Drawing.Size(723, 253);
            this.dGridRateReview.TabIndex = 2;
            // 
            // lblReviewerDiplay
            // 
            this.lblReviewerDiplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblReviewerDiplay.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblReviewerDiplay.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblReviewerDiplay.Location = new System.Drawing.Point(12, 9);
            this.lblReviewerDiplay.Name = "lblReviewerDiplay";
            this.lblReviewerDiplay.Size = new System.Drawing.Size(360, 22);
            this.lblReviewerDiplay.TabIndex = 21;
            this.lblReviewerDiplay.Text = "Click on a row i the table to rate the review";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(12, 398);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 40);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitReview.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSubmitReview.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitReview.ForeColor = System.Drawing.Color.White;
            this.btnSubmitReview.Location = new System.Drawing.Point(665, 398);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(123, 40);
            this.btnSubmitReview.TabIndex = 23;
            this.btnSubmitReview.Text = "Submit";
            this.btnSubmitReview.UseVisualStyleBackColor = false;
            this.btnSubmitReview.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(505, 358);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 24;
            // 
            // RateReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnSubmitReview);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblReviewerDiplay);
            this.Controls.Add(this.dGridRateReview);
            this.Name = "RateReviewsForm";
            this.Text = "RateReviews";
            ((System.ComponentModel.ISupportInitialize)(this.dGridRateReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridRateReview;
        private System.Windows.Forms.Label lblReviewerDiplay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmitReview;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}