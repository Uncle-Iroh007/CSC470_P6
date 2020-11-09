namespace Builder
{
    partial class selectIssueToModify
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
            this.listOfIssues = new System.Windows.Forms.DataGridView();
            this.issueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intiDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelIssue = new System.Windows.Forms.Button();
            this.MdfyCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listOfIssues)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfIssues
            // 
            this.listOfIssues.AllowUserToAddRows = false;
            this.listOfIssues.AllowUserToDeleteRows = false;
            this.listOfIssues.AllowUserToResizeColumns = false;
            this.listOfIssues.AllowUserToResizeRows = false;
            this.listOfIssues.ColumnHeadersHeight = 29;
            this.listOfIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.listOfIssues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issueId,
            this.issTitle,
            this.discDate,
            this.disc,
            this.intiDesc,
            this.comp,
            this.stat});
            this.listOfIssues.Location = new System.Drawing.Point(1, 2);
            this.listOfIssues.MultiSelect = false;
            this.listOfIssues.Name = "listOfIssues";
            this.listOfIssues.ReadOnly = true;
            this.listOfIssues.RowHeadersWidth = 51;
            this.listOfIssues.RowTemplate.Height = 24;
            this.listOfIssues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listOfIssues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listOfIssues.Size = new System.Drawing.Size(1241, 395);
            this.listOfIssues.TabIndex = 0;
            // 
            // issueId
            // 
            this.issueId.HeaderText = "Id";
            this.issueId.MinimumWidth = 6;
            this.issueId.Name = "issueId";
            this.issueId.ReadOnly = true;
            this.issueId.Width = 50;
            // 
            // issTitle
            // 
            this.issTitle.HeaderText = "TItle";
            this.issTitle.MinimumWidth = 6;
            this.issTitle.Name = "issTitle";
            this.issTitle.ReadOnly = true;
            this.issTitle.Width = 190;
            // 
            // discDate
            // 
            this.discDate.HeaderText = "DiscoveryDate";
            this.discDate.MinimumWidth = 6;
            this.discDate.Name = "discDate";
            this.discDate.ReadOnly = true;
            this.discDate.Width = 125;
            // 
            // disc
            // 
            this.disc.HeaderText = "Discoverer";
            this.disc.MinimumWidth = 6;
            this.disc.Name = "disc";
            this.disc.ReadOnly = true;
            this.disc.Width = 125;
            // 
            // intiDesc
            // 
            this.intiDesc.HeaderText = "InitialDescsription";
            this.intiDesc.MinimumWidth = 6;
            this.intiDesc.Name = "intiDesc";
            this.intiDesc.ReadOnly = true;
            this.intiDesc.Width = 125;
            // 
            // comp
            // 
            this.comp.HeaderText = "Component";
            this.comp.MinimumWidth = 6;
            this.comp.Name = "comp";
            this.comp.ReadOnly = true;
            this.comp.Width = 125;
            // 
            // stat
            // 
            this.stat.HeaderText = "Status";
            this.stat.MinimumWidth = 6;
            this.stat.Name = "stat";
            this.stat.ReadOnly = true;
            this.stat.Width = 125;
            // 
            // SelIssue
            // 
            this.SelIssue.Location = new System.Drawing.Point(1065, 419);
            this.SelIssue.Name = "SelIssue";
            this.SelIssue.Size = new System.Drawing.Size(177, 38);
            this.SelIssue.TabIndex = 1;
            this.SelIssue.Text = "Select Issue";
            this.SelIssue.UseVisualStyleBackColor = true;
            this.SelIssue.Click += new System.EventHandler(this.SelIssue_Click);
            // 
            // MdfyCancel
            // 
            this.MdfyCancel.Location = new System.Drawing.Point(925, 419);
            this.MdfyCancel.Name = "MdfyCancel";
            this.MdfyCancel.Size = new System.Drawing.Size(104, 38);
            this.MdfyCancel.TabIndex = 2;
            this.MdfyCancel.Text = "Cancel";
            this.MdfyCancel.UseVisualStyleBackColor = true;
            this.MdfyCancel.Click += new System.EventHandler(this.MdfyCancel_Click);
            // 
            // selectIssueToModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 478);
            this.Controls.Add(this.MdfyCancel);
            this.Controls.Add(this.SelIssue);
            this.Controls.Add(this.listOfIssues);
            this.Name = "selectIssueToModify";
            this.Text = "Select Issue";
            this.Load += new System.EventHandler(this.FormSelectIssueToModidy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listOfIssues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listOfIssues;
        private System.Windows.Forms.Button SelIssue;
        private System.Windows.Forms.Button MdfyCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueId;
        private System.Windows.Forms.DataGridViewTextBoxColumn issTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn discDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn intiDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn comp;
        private System.Windows.Forms.DataGridViewTextBoxColumn stat;
    }
}