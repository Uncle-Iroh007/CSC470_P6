namespace Builder
{
    partial class FormDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.numIssue = new System.Windows.Forms.Label();
            this.IbM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Close_Db = new System.Windows.Forms.Button();
            this.clsButton = new System.Windows.Forms.Button();
            this.issueByMonth_List = new System.Windows.Forms.TextBox();
            this.IssueByDisc_list = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Number of Issues";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numIssue
            // 
            this.numIssue.AutoSize = true;
            this.numIssue.Location = new System.Drawing.Point(241, 46);
            this.numIssue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numIssue.Name = "numIssue";
            this.numIssue.Size = new System.Drawing.Size(27, 20);
            this.numIssue.TabIndex = 1;
            this.numIssue.Text = "__";
            this.numIssue.Click += new System.EventHandler(this.numIssue_Click);
            // 
            // IbM
            // 
            this.IbM.AutoSize = true;
            this.IbM.Location = new System.Drawing.Point(16, 95);
            this.IbM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IbM.Name = "IbM";
            this.IbM.Size = new System.Drawing.Size(131, 20);
            this.IbM.TabIndex = 2;
            this.IbM.Text = "Issues by Month";
            this.IbM.Click += new System.EventHandler(this.IbM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 353);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Issues by Discoverer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Close_Db
            // 
            this.Close_Db.Location = new System.Drawing.Point(305, 743);
            this.Close_Db.Name = "Close_Db";
            this.Close_Db.Size = new System.Drawing.Size(98, 39);
            this.Close_Db.TabIndex = 7;
            this.Close_Db.Text = "Close";
            this.Close_Db.UseVisualStyleBackColor = true;
            this.Close_Db.Click += new System.EventHandler(this.clsButton_Click);
            // 
            // clsButton
            // 
            this.clsButton.Location = new System.Drawing.Point(235, 588);
            this.clsButton.Name = "clsButton";
            this.clsButton.Size = new System.Drawing.Size(101, 33);
            this.clsButton.TabIndex = 8;
            this.clsButton.Text = "Close";
            this.clsButton.UseVisualStyleBackColor = true;
            this.clsButton.Click += new System.EventHandler(this.clsButton_Click);
            // 
            // issueByMonth_List
            // 
            this.issueByMonth_List.Location = new System.Drawing.Point(20, 128);
            this.issueByMonth_List.Multiline = true;
            this.issueByMonth_List.Name = "issueByMonth_List";
            this.issueByMonth_List.ReadOnly = true;
            this.issueByMonth_List.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.issueByMonth_List.ShortcutsEnabled = false;
            this.issueByMonth_List.Size = new System.Drawing.Size(316, 194);
            this.issueByMonth_List.TabIndex = 9;
            // 
            // IssueByDisc_list
            // 
            this.IssueByDisc_list.Location = new System.Drawing.Point(20, 389);
            this.IssueByDisc_list.Multiline = true;
            this.IssueByDisc_list.Name = "IssueByDisc_list";
            this.IssueByDisc_list.ReadOnly = true;
            this.IssueByDisc_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IssueByDisc_list.Size = new System.Drawing.Size(316, 193);
            this.IssueByDisc_list.TabIndex = 10;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 633);
            this.Controls.Add(this.IssueByDisc_list);
            this.Controls.Add(this.issueByMonth_List);
            this.Controls.Add(this.clsButton);
            this.Controls.Add(this.Close_Db);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IbM);
            this.Controls.Add(this.numIssue);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numIssue;
        private System.Windows.Forms.Label IbM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Close_Db;
        private System.Windows.Forms.Button clsButton;
        private System.Windows.Forms.TextBox issueByMonth_List;
        private System.Windows.Forms.TextBox IssueByDisc_list;
    }
}