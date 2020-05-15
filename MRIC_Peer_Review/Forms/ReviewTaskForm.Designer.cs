namespace MRIC_Peer_Review
{
    partial class ReviewTasks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewTasks));
            this.lblReviewerDiplay = new System.Windows.Forms.Label();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.txtBoxReview = new System.Windows.Forms.RichTextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dGridClosed = new System.Windows.Forms.DataGridView();
            this.dGridLocked = new System.Windows.Forms.DataGridView();
            this.tabLocked = new System.Windows.Forms.TabPage();
            this.dGridOpen = new System.Windows.Forms.DataGridView();
            this.tabOpen = new System.Windows.Forms.TabPage();
            this.tabAwaiting = new System.Windows.Forms.TabPage();
            this.dGridAwaiting = new System.Windows.Forms.DataGridView();
            this.dGridAll = new System.Windows.Forms.DataGridView();
            this.tabAllReviews = new System.Windows.Forms.TabPage();
            this.lblRefresh = new System.Windows.Forms.Label();
            this.tabReviews = new System.Windows.Forms.TabControl();
            this.tabClosed = new System.Windows.Forms.TabPage();
            this.btnGoToLink = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridLocked)).BeginInit();
            this.tabLocked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridOpen)).BeginInit();
            this.tabOpen.SuspendLayout();
            this.tabAwaiting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAwaiting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAll)).BeginInit();
            this.tabAllReviews.SuspendLayout();
            this.tabReviews.SuspendLayout();
            this.tabClosed.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReviewerDiplay
            // 
            this.lblReviewerDiplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblReviewerDiplay.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblReviewerDiplay.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblReviewerDiplay.Location = new System.Drawing.Point(19, 331);
            this.lblReviewerDiplay.Name = "lblReviewerDiplay";
            this.lblReviewerDiplay.Size = new System.Drawing.Size(883, 48);
            this.lblReviewerDiplay.TabIndex = 20;
            this.lblReviewerDiplay.Text = "Click on a row i the table to insert a comment.";
            this.lblReviewerDiplay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitReview.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSubmitReview.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitReview.ForeColor = System.Drawing.Color.White;
            this.btnSubmitReview.Location = new System.Drawing.Point(764, 495);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(123, 40);
            this.btnSubmitReview.TabIndex = 6;
            this.btnSubmitReview.Text = "Submit";
            this.btnSubmitReview.UseVisualStyleBackColor = false;
            this.btnSubmitReview.Visible = false;
            this.btnSubmitReview.Click += new System.EventHandler(this.btnSubmitReview_Click);
            // 
            // txtBoxReview
            // 
            this.txtBoxReview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxReview.BackColor = System.Drawing.Color.White;
            this.txtBoxReview.Location = new System.Drawing.Point(181, 382);
            this.txtBoxReview.Name = "txtBoxReview";
            this.txtBoxReview.Size = new System.Drawing.Size(558, 88);
            this.txtBoxReview.TabIndex = 4;
            this.txtBoxReview.Text = "";
            this.txtBoxReview.TextChanged += new System.EventHandler(this.txtBoxReview_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(799, 309);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 29);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(27, 495);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dGridClosed
            // 
            this.dGridClosed.AllowUserToAddRows = false;
            this.dGridClosed.AllowUserToDeleteRows = false;
            this.dGridClosed.AllowUserToResizeColumns = false;
            this.dGridClosed.AllowUserToResizeRows = false;
            this.dGridClosed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridClosed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGridClosed.BackgroundColor = System.Drawing.Color.White;
            this.dGridClosed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGridClosed.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dGridClosed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dGridClosed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridClosed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dGridClosed.GridColor = System.Drawing.Color.White;
            this.dGridClosed.Location = new System.Drawing.Point(6, 6);
            this.dGridClosed.Name = "dGridClosed";
            this.dGridClosed.ReadOnly = true;
            this.dGridClosed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridClosed.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridClosed.RowHeadersVisible = false;
            this.dGridClosed.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGridClosed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridClosed.ShowCellErrors = false;
            this.dGridClosed.ShowCellToolTips = false;
            this.dGridClosed.ShowEditingIcon = false;
            this.dGridClosed.ShowRowErrors = false;
            this.dGridClosed.Size = new System.Drawing.Size(842, 277);
            this.dGridClosed.TabIndex = 2;
            this.dGridClosed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridClosed_CellClick);
            this.dGridClosed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridClosed_CellClick);
            this.dGridClosed.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridClosed_CellClick);
            this.dGridClosed.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridClosed_CellClick);
            // 
            // dGridLocked
            // 
            this.dGridLocked.AllowUserToAddRows = false;
            this.dGridLocked.AllowUserToDeleteRows = false;
            this.dGridLocked.AllowUserToResizeColumns = false;
            this.dGridLocked.AllowUserToResizeRows = false;
            this.dGridLocked.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridLocked.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGridLocked.BackgroundColor = System.Drawing.Color.White;
            this.dGridLocked.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGridLocked.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dGridLocked.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dGridLocked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridLocked.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dGridLocked.GridColor = System.Drawing.Color.White;
            this.dGridLocked.Location = new System.Drawing.Point(6, 6);
            this.dGridLocked.Name = "dGridLocked";
            this.dGridLocked.ReadOnly = true;
            this.dGridLocked.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridLocked.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGridLocked.RowHeadersVisible = false;
            this.dGridLocked.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGridLocked.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridLocked.ShowCellErrors = false;
            this.dGridLocked.ShowCellToolTips = false;
            this.dGridLocked.ShowEditingIcon = false;
            this.dGridLocked.ShowRowErrors = false;
            this.dGridLocked.Size = new System.Drawing.Size(842, 277);
            this.dGridLocked.TabIndex = 2;
            this.dGridLocked.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridLocked_CellClick);
            this.dGridLocked.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridLocked_CellClick);
            this.dGridLocked.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridLocked_CellClick);
            this.dGridLocked.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridLocked_CellClick);
            // 
            // tabLocked
            // 
            this.tabLocked.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabLocked.Controls.Add(this.dGridLocked);
            this.tabLocked.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLocked.Location = new System.Drawing.Point(4, 4);
            this.tabLocked.Name = "tabLocked";
            this.tabLocked.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocked.Size = new System.Drawing.Size(858, 292);
            this.tabLocked.TabIndex = 7;
            this.tabLocked.Text = "Locked";
            this.tabLocked.UseVisualStyleBackColor = true;
            // 
            // dGridOpen
            // 
            this.dGridOpen.AllowUserToAddRows = false;
            this.dGridOpen.AllowUserToDeleteRows = false;
            this.dGridOpen.AllowUserToResizeColumns = false;
            this.dGridOpen.AllowUserToResizeRows = false;
            this.dGridOpen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridOpen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGridOpen.BackgroundColor = System.Drawing.Color.White;
            this.dGridOpen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGridOpen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dGridOpen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dGridOpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridOpen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dGridOpen.GridColor = System.Drawing.Color.White;
            this.dGridOpen.Location = new System.Drawing.Point(6, 6);
            this.dGridOpen.Name = "dGridOpen";
            this.dGridOpen.ReadOnly = true;
            this.dGridOpen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridOpen.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGridOpen.RowHeadersVisible = false;
            this.dGridOpen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGridOpen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridOpen.ShowCellErrors = false;
            this.dGridOpen.ShowCellToolTips = false;
            this.dGridOpen.ShowEditingIcon = false;
            this.dGridOpen.ShowRowErrors = false;
            this.dGridOpen.Size = new System.Drawing.Size(842, 276);
            this.dGridOpen.TabIndex = 2;
            this.dGridOpen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridOpen_CellClick);
            this.dGridOpen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridOpen_CellClick);
            this.dGridOpen.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridOpen_CellClick);
            this.dGridOpen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridOpen_CellClick);
            // 
            // tabOpen
            // 
            this.tabOpen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabOpen.Controls.Add(this.dGridOpen);
            this.tabOpen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOpen.Location = new System.Drawing.Point(4, 4);
            this.tabOpen.Name = "tabOpen";
            this.tabOpen.Padding = new System.Windows.Forms.Padding(3);
            this.tabOpen.Size = new System.Drawing.Size(858, 292);
            this.tabOpen.TabIndex = 6;
            this.tabOpen.Text = "Open";
            this.tabOpen.UseVisualStyleBackColor = true;
            // 
            // tabAwaiting
            // 
            this.tabAwaiting.AccessibleName = "AwaitingTab";
            this.tabAwaiting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabAwaiting.Controls.Add(this.dGridAwaiting);
            this.tabAwaiting.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAwaiting.Location = new System.Drawing.Point(4, 4);
            this.tabAwaiting.Name = "tabAwaiting";
            this.tabAwaiting.Padding = new System.Windows.Forms.Padding(3);
            this.tabAwaiting.Size = new System.Drawing.Size(858, 292);
            this.tabAwaiting.TabIndex = 5;
            this.tabAwaiting.Text = "Awaiting";
            this.tabAwaiting.UseVisualStyleBackColor = true;
            // 
            // dGridAwaiting
            // 
            this.dGridAwaiting.AllowUserToAddRows = false;
            this.dGridAwaiting.AllowUserToDeleteRows = false;
            this.dGridAwaiting.AllowUserToResizeColumns = false;
            this.dGridAwaiting.AllowUserToResizeRows = false;
            this.dGridAwaiting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridAwaiting.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGridAwaiting.BackgroundColor = System.Drawing.Color.White;
            this.dGridAwaiting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGridAwaiting.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dGridAwaiting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dGridAwaiting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridAwaiting.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dGridAwaiting.GridColor = System.Drawing.Color.White;
            this.dGridAwaiting.Location = new System.Drawing.Point(6, 6);
            this.dGridAwaiting.Name = "dGridAwaiting";
            this.dGridAwaiting.ReadOnly = true;
            this.dGridAwaiting.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridAwaiting.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dGridAwaiting.RowHeadersVisible = false;
            this.dGridAwaiting.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dGridAwaiting.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridAwaiting.ShowCellErrors = false;
            this.dGridAwaiting.ShowCellToolTips = false;
            this.dGridAwaiting.ShowEditingIcon = false;
            this.dGridAwaiting.ShowRowErrors = false;
            this.dGridAwaiting.Size = new System.Drawing.Size(842, 276);
            this.dGridAwaiting.TabIndex = 2;
            // 
            // dGridAll
            // 
            this.dGridAll.AllowUserToAddRows = false;
            this.dGridAll.AllowUserToDeleteRows = false;
            this.dGridAll.AllowUserToResizeColumns = false;
            this.dGridAll.AllowUserToResizeRows = false;
            this.dGridAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridAll.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGridAll.BackgroundColor = System.Drawing.Color.White;
            this.dGridAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGridAll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dGridAll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dGridAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridAll.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dGridAll.GridColor = System.Drawing.Color.White;
            this.dGridAll.Location = new System.Drawing.Point(6, 6);
            this.dGridAll.Name = "dGridAll";
            this.dGridAll.ReadOnly = true;
            this.dGridAll.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridAll.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGridAll.RowHeadersVisible = false;
            this.dGridAll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dGridAll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridAll.ShowCellErrors = false;
            this.dGridAll.ShowCellToolTips = false;
            this.dGridAll.ShowEditingIcon = false;
            this.dGridAll.ShowRowErrors = false;
            this.dGridAll.Size = new System.Drawing.Size(842, 276);
            this.dGridAll.TabIndex = 1;
            this.dGridAll.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridAll_CellClick);
            this.dGridAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridAll_CellClick);
            this.dGridAll.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridAll_CellClick);
            this.dGridAll.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridAll_CellClick);
            // 
            // tabAllReviews
            // 
            this.tabAllReviews.BackColor = System.Drawing.Color.White;
            this.tabAllReviews.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabAllReviews.Controls.Add(this.dGridAll);
            this.tabAllReviews.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAllReviews.Location = new System.Drawing.Point(4, 4);
            this.tabAllReviews.Name = "tabAllReviews";
            this.tabAllReviews.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllReviews.Size = new System.Drawing.Size(858, 292);
            this.tabAllReviews.TabIndex = 4;
            this.tabAllReviews.Text = "All Reviews";
            // 
            // lblRefresh
            // 
            this.lblRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRefresh.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRefresh.ForeColor = System.Drawing.Color.Red;
            this.lblRefresh.Location = new System.Drawing.Point(308, 316);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(305, 17);
            this.lblRefresh.TabIndex = 24;
            this.lblRefresh.Text = "Click \"Refresh\" to enable \"Review Selection\" above.";
            this.lblRefresh.Visible = false;
            // 
            // tabReviews
            // 
            this.tabReviews.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabReviews.Controls.Add(this.tabAllReviews);
            this.tabReviews.Controls.Add(this.tabAwaiting);
            this.tabReviews.Controls.Add(this.tabOpen);
            this.tabReviews.Controls.Add(this.tabLocked);
            this.tabReviews.Controls.Add(this.tabClosed);
            this.tabReviews.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tabReviews.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabReviews.Location = new System.Drawing.Point(14, 14);
            this.tabReviews.Multiline = true;
            this.tabReviews.Name = "tabReviews";
            this.tabReviews.Padding = new System.Drawing.Point(6, 4);
            this.tabReviews.SelectedIndex = 0;
            this.tabReviews.Size = new System.Drawing.Size(888, 300);
            this.tabReviews.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabReviews.TabIndex = 1;
            // 
            // tabClosed
            // 
            this.tabClosed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabClosed.Controls.Add(this.dGridClosed);
            this.tabClosed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabClosed.Location = new System.Drawing.Point(4, 4);
            this.tabClosed.Name = "tabClosed";
            this.tabClosed.Padding = new System.Windows.Forms.Padding(3);
            this.tabClosed.Size = new System.Drawing.Size(858, 292);
            this.tabClosed.TabIndex = 8;
            this.tabClosed.Text = "Closed";
            this.tabClosed.UseVisualStyleBackColor = true;
            // 
            // btnGoToLink
            // 
            this.btnGoToLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGoToLink.BackColor = System.Drawing.SystemColors.Control;
            this.btnGoToLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToLink.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnGoToLink.ForeColor = System.Drawing.Color.Blue;
            this.btnGoToLink.Location = new System.Drawing.Point(672, 309);
            this.btnGoToLink.Name = "btnGoToLink";
            this.btnGoToLink.Size = new System.Drawing.Size(127, 29);
            this.btnGoToLink.TabIndex = 3;
            this.btnGoToLink.Text = "Go to Selected Link";
            this.btnGoToLink.UseVisualStyleBackColor = false;
            this.btnGoToLink.Click += new System.EventHandler(this.btnGoToLink_Click);
            // 
            // ReviewTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(914, 552);
            this.Controls.Add(this.txtBoxReview);
            this.Controls.Add(this.lblRefresh);
            this.Controls.Add(this.tabReviews);
            this.Controls.Add(this.btnGoToLink);
            this.Controls.Add(this.btnSubmitReview);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblReviewerDiplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReviewTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review Task";
            this.Load += new System.EventHandler(this.ReviewTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridLocked)).EndInit();
            this.tabLocked.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridOpen)).EndInit();
            this.tabOpen.ResumeLayout(false);
            this.tabAwaiting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridAwaiting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAll)).EndInit();
            this.tabAllReviews.ResumeLayout(false);
            this.tabReviews.ResumeLayout(false);
            this.tabClosed.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblReviewerDiplay;
        private System.Windows.Forms.Button btnSubmitReview;
        private System.Windows.Forms.RichTextBox txtBoxReview;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dGridClosed;
        private System.Windows.Forms.DataGridView dGridLocked;
        private System.Windows.Forms.TabPage tabLocked;
        private System.Windows.Forms.DataGridView dGridOpen;
        private System.Windows.Forms.TabPage tabOpen;
        private System.Windows.Forms.TabPage tabAwaiting;
        private System.Windows.Forms.DataGridView dGridAll;
        private System.Windows.Forms.TabPage tabAllReviews;
        private System.Windows.Forms.TabControl tabReviews;
        private System.Windows.Forms.TabPage tabClosed;
        private System.Windows.Forms.Button btnGoToLink;
        private System.Windows.Forms.Label lblRefresh;
        private System.Windows.Forms.DataGridView dGridAwaiting;
    }
}