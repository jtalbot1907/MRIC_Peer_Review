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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGridRateReview = new System.Windows.Forms.DataGridView();
            this.lblReviewerDiplay = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dGridRateReview.Location = new System.Drawing.Point(36, 43);
            this.dGridRateReview.Name = "dGridRateReview";
            this.dGridRateReview.ReadOnly = true;
            this.dGridRateReview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridRateReview.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGridRateReview.RowHeadersVisible = false;
            this.dGridRateReview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dGridRateReview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridRateReview.ShowCellErrors = false;
            this.dGridRateReview.ShowCellToolTips = false;
            this.dGridRateReview.ShowEditingIcon = false;
            this.dGridRateReview.ShowRowErrors = false;
            this.dGridRateReview.Size = new System.Drawing.Size(723, 227);
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnSubmitReview.Click += new System.EventHandler(this.btnSubmitReview_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.SteelBlue;
            this.numericUpDown1.Location = new System.Drawing.Point(679, 276);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown1.TabIndex = 24;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(469, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Rate the Review out of ten";
            // 
            // RateReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}