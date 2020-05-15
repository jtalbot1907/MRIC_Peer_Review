namespace MRIC_Peer_Review
{
    partial class PostRdocForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostRdocForm));
            this.panelMinGrade = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dGridViewMinGrade = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblSecialism = new System.Windows.Forms.Label();
            this.chkListSpecialisms = new System.Windows.Forms.CheckedListBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rtxtLink = new System.Windows.Forms.RichTextBox();
            this.rtxtTitle = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelMinGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewMinGrade)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMinGrade
            // 
            this.panelMinGrade.Controls.Add(this.label1);
            this.panelMinGrade.Controls.Add(this.dGridViewMinGrade);
            this.panelMinGrade.Controls.Add(this.btnSubmit);
            this.panelMinGrade.Location = new System.Drawing.Point(12, 21);
            this.panelMinGrade.Name = "panelMinGrade";
            this.panelMinGrade.Size = new System.Drawing.Size(471, 437);
            this.panelMinGrade.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Define the MinGrade for each Specialism in the table below";
            // 
            // dGridViewMinGrade
            // 
            this.dGridViewMinGrade.AllowUserToAddRows = false;
            this.dGridViewMinGrade.AllowUserToDeleteRows = false;
            this.dGridViewMinGrade.AllowUserToResizeColumns = false;
            this.dGridViewMinGrade.AllowUserToResizeRows = false;
            this.dGridViewMinGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridViewMinGrade.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGridViewMinGrade.BackgroundColor = System.Drawing.Color.White;
            this.dGridViewMinGrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGridViewMinGrade.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dGridViewMinGrade.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dGridViewMinGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewMinGrade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dGridViewMinGrade.GridColor = System.Drawing.SystemColors.Highlight;
            this.dGridViewMinGrade.Location = new System.Drawing.Point(71, 66);
            this.dGridViewMinGrade.Name = "dGridViewMinGrade";
            this.dGridViewMinGrade.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridViewMinGrade.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridViewMinGrade.RowHeadersVisible = false;
            this.dGridViewMinGrade.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGridViewMinGrade.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridViewMinGrade.ShowCellErrors = false;
            this.dGridViewMinGrade.ShowCellToolTips = false;
            this.dGridViewMinGrade.ShowEditingIcon = false;
            this.dGridViewMinGrade.ShowRowErrors = false;
            this.dGridViewMinGrade.Size = new System.Drawing.Size(335, 310);
            this.dGridViewMinGrade.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(379, 399);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 38);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNext.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(391, 420);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(92, 38);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblSecialism
            // 
            this.lblSecialism.AutoSize = true;
            this.lblSecialism.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecialism.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSecialism.Location = new System.Drawing.Point(6, 164);
            this.lblSecialism.Name = "lblSecialism";
            this.lblSecialism.Size = new System.Drawing.Size(80, 15);
            this.lblSecialism.TabIndex = 13;
            this.lblSecialism.Text = "Specialisms:";
            // 
            // chkListSpecialisms
            // 
            this.chkListSpecialisms.CheckOnClick = true;
            this.chkListSpecialisms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkListSpecialisms.FormattingEnabled = true;
            this.chkListSpecialisms.Location = new System.Drawing.Point(17, 183);
            this.chkListSpecialisms.Name = "chkListSpecialisms";
            this.chkListSpecialisms.Size = new System.Drawing.Size(196, 124);
            this.chkListSpecialisms.TabIndex = 12;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblLink.Location = new System.Drawing.Point(6, 95);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(34, 15);
            this.lblLink.TabIndex = 9;
            this.lblLink.Text = "Link:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Location = new System.Drawing.Point(6, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(34, 15);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(12, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 38);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rtxtLink
            // 
            this.rtxtLink.Location = new System.Drawing.Point(17, 113);
            this.rtxtLink.Name = "rtxtLink";
            this.rtxtLink.Size = new System.Drawing.Size(437, 35);
            this.rtxtLink.TabIndex = 17;
            this.rtxtLink.Text = "";
            // 
            // rtxtTitle
            // 
            this.rtxtTitle.Location = new System.Drawing.Point(17, 47);
            this.rtxtTitle.Name = "rtxtTitle";
            this.rtxtTitle.Size = new System.Drawing.Size(437, 35);
            this.rtxtTitle.TabIndex = 18;
            this.rtxtTitle.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.rtxtTitle);
            this.groupBox1.Controls.Add(this.rtxtLink);
            this.groupBox1.Controls.Add(this.lblLink);
            this.groupBox1.Controls.Add(this.lblSecialism);
            this.groupBox1.Controls.Add(this.chkListSpecialisms);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 324);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Review Details";
            // 
            // MakeReviewRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 475);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelMinGrade);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MakeReviewRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Review Request";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MakeReviewRequest_Load);
            this.panelMinGrade.ResumeLayout(false);
            this.panelMinGrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewMinGrade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMinGrade;
        private System.Windows.Forms.DataGridView dGridViewMinGrade;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblSecialism;
        private System.Windows.Forms.CheckedListBox chkListSpecialisms;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox rtxtLink;
        private System.Windows.Forms.RichTextBox rtxtTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}