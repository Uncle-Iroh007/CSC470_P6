namespace Builder
{
    partial class FormRemoveIssue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /*private void InitializeComponent()
        {
            this.Load += new System.EventHandler(this.FormRemoveIssue_Load);
        }*/

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
            this.issuesList = new System.Windows.Forms.DataGridView();
            this.isId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intiDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selIss = new System.Windows.Forms.Button();
            this.cnclSel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.issuesList)).BeginInit();
            this.SuspendLayout();
            // 
            // issuesList
            // 
            this.issuesList.AllowUserToAddRows = false;
            this.issuesList.AllowUserToDeleteRows = false;
            this.issuesList.AllowUserToResizeColumns = false;
            this.issuesList.AllowUserToResizeRows = false;
            this.issuesList.ColumnHeadersHeight = 29;
            this.issuesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.issuesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isId,
            this.issTitle,
            this.discDate,
            this.disc,
            this.intiDesc,
            this.comp,
            this.stat});
            this.issuesList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.issuesList.Location = new System.Drawing.Point(12, 12);
            this.issuesList.MultiSelect = false;
            this.issuesList.Name = "issuesList";
            this.issuesList.ReadOnly = true;
            this.issuesList.RowHeadersWidth = 51;
            this.issuesList.RowTemplate.Height = 24;
            this.issuesList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.issuesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.issuesList.Size = new System.Drawing.Size(1151, 393);
            this.issuesList.TabIndex = 0;
            // 
            // isId
            // 
            this.isId.HeaderText = "Id";
            this.isId.MinimumWidth = 6;
            this.isId.Name = "isId";
            this.isId.ReadOnly = true;
            this.isId.Width = 50;
            // 
            // issTitle
            // 
            this.issTitle.HeaderText = "Title";
            this.issTitle.MinimumWidth = 6;
            this.issTitle.Name = "issTitle";
            this.issTitle.ReadOnly = true;
            this.issTitle.Width = 160;
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
            this.intiDesc.HeaderText = "InitialDescription";
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
            // selIss
            // 
            this.selIss.Location = new System.Drawing.Point(1021, 411);
            this.selIss.Name = "selIss";
            this.selIss.Size = new System.Drawing.Size(142, 38);
            this.selIss.TabIndex = 1;
            this.selIss.Text = "Select Issue";
            this.selIss.UseVisualStyleBackColor = true;
            this.selIss.Click += new System.EventHandler(this.selIss_Click);
            // 
            // cnclSel
            // 
            this.cnclSel.Location = new System.Drawing.Point(883, 411);
            this.cnclSel.Name = "cnclSel";
            this.cnclSel.Size = new System.Drawing.Size(113, 38);
            this.cnclSel.TabIndex = 2;
            this.cnclSel.Text = "Cancel";
            this.cnclSel.UseVisualStyleBackColor = true;
            this.cnclSel.Click += new System.EventHandler(this.cnclSel_Click);
            // 
            // FormRemoveIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 482);
            this.Controls.Add(this.cnclSel);
            this.Controls.Add(this.selIss);
            this.Controls.Add(this.issuesList);
            this.Name = "FormRemoveIssue";
            this.Text = "Remove Issue";
            this.Load += new System.EventHandler(this.FormRemoveIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.issuesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView issuesList;
        private System.Windows.Forms.Button selIss;
        private System.Windows.Forms.Button cnclSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn isId;
        private System.Windows.Forms.DataGridViewTextBoxColumn issTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn discDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn intiDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn comp;
        private System.Windows.Forms.DataGridViewTextBoxColumn stat;

    }

    }