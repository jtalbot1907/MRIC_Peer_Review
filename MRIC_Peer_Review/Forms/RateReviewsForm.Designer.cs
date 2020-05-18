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
            this.numSel = new System.Windows.Forms.NumericUpDown();
            this.lblRate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridRateReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSel)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dGridRateReview.BackgroundColor = System.Drawing.Color.White;
            this.dGridRateReview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGridRateReview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dGridRateReview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dGridRateReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridRateReview.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dGridRateReview.GridColor = System.Drawing.Color.White;
            this.dGridRateReview.Location = new System.Drawing.Point(6, 7);
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
            this.dGridRateReview.Size = new System.Drawing.Size(788, 246);
            this.dGridRateReview.TabIndex = 2;
            this.dGridRateReview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridRateReview_CellClick);
            this.dGridRateReview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridRateReview_CellClick);
            this.dGridRateReview.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridRateReview_CellClick);
            this.dGridRateReview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridRateReview_CellClick);
            // 
            // lblReviewerDiplay
            // 
            this.lblReviewerDiplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblReviewerDiplay.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblReviewerDiplay.ForeColor = System.Drawing.Color.Red;
            this.lblReviewerDiplay.Location = new System.Drawing.Point(47, 302);
            this.lblReviewerDiplay.Name = "lblReviewerDiplay";
            this.lblReviewerDiplay.Size = new System.Drawing.Size(627, 132);
            this.lblReviewerDiplay.TabIndex = 21;
            this.lblReviewerDiplay.Text = "Click on a row to rate a Comment";
            this.lblReviewerDiplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(12, 456);
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
            this.btnSubmitReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitReview.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitReview.ForeColor = System.Drawing.Color.White;
            this.btnSubmitReview.Location = new System.Drawing.Point(725, 456);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(123, 40);
            this.btnSubmitReview.TabIndex = 23;
            this.btnSubmitReview.Text = "Submit";
            this.btnSubmitReview.UseVisualStyleBackColor = false;
            this.btnSubmitReview.Click += new System.EventHandler(this.btnSubmitReview_Click);
            // 
            // numSel
            // 
            this.numSel.BackColor = System.Drawing.Color.White;
            this.numSel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numSel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSel.ForeColor = System.Drawing.Color.SteelBlue;
            this.numSel.Location = new System.Drawing.Point(769, 369);
            this.numSel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSel.Name = "numSel";
            this.numSel.Size = new System.Drawing.Size(42, 25);
            this.numSel.TabIndex = 24;
            this.numSel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSel.ValueChanged += new System.EventHandler(this.numSel_ValueChanged);
            // 
            // lblRate
            // 
            this.lblRate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblRate.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblRate.Location = new System.Drawing.Point(690, 346);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(140, 22);
            this.lblRate.TabIndex = 25;
            this.lblRate.Text = "Rate the Comment";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dGridRateReview);
            this.panel1.Location = new System.Drawing.Point(28, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 264);
            this.panel1.TabIndex = 26;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(694, 289);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 29);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Cancel Selection";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // RateReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numSel);
            this.Controls.Add(this.btnSubmitReview);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblReviewerDiplay);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.btnRefresh);
            this.Name = "RateReviewsForm";
            this.Text = "RateReviews";
            this.Load += new System.EventHandler(this.RateReviewsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridRateReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridRateReview;
        private System.Windows.Forms.Label lblReviewerDiplay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmitReview;
        private System.Windows.Forms.NumericUpDown numSel;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
    }
}