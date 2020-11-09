namespace Builder
{
    partial class FormModifyIssue
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.issueID = new System.Windows.Forms.TextBox();
            this.issueTitle = new System.Windows.Forms.TextBox();
            this.issComp = new System.Windows.Forms.TextBox();
            this.initDesc = new System.Windows.Forms.RichTextBox();
            this.mdfyIssue = new System.Windows.Forms.Button();
            this.cnclMdfy = new System.Windows.Forms.Button();
            this.discDate = new System.Windows.Forms.DateTimePicker();
            this.disc = new System.Windows.Forms.ComboBox();
            this.issStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discovery Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Discoverer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Component";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Initial Description";
            // 
            // issueID
            // 
            this.issueID.Location = new System.Drawing.Point(139, 42);
            this.issueID.Name = "issueID";
            this.issueID.ReadOnly = true;
            this.issueID.Size = new System.Drawing.Size(56, 22);
            this.issueID.TabIndex = 7;
            // 
            // issueTitle
            // 
            this.issueTitle.Location = new System.Drawing.Point(139, 85);
            this.issueTitle.Name = "issueTitle";
            this.issueTitle.Size = new System.Drawing.Size(258, 22);
            this.issueTitle.TabIndex = 8;
            // 
            // issComp
            // 
            this.issComp.Location = new System.Drawing.Point(139, 181);
            this.issComp.Name = "issComp";
            this.issComp.Size = new System.Drawing.Size(258, 22);
            this.issComp.TabIndex = 11;
            // 
            // initDesc
            // 
            this.initDesc.Location = new System.Drawing.Point(139, 283);
            this.initDesc.Name = "initDesc";
            this.initDesc.Size = new System.Drawing.Size(258, 213);
            this.initDesc.TabIndex = 13;
            this.initDesc.Text = "";
            // 
            // mdfyIssue
            // 
            this.mdfyIssue.Location = new System.Drawing.Point(279, 516);
            this.mdfyIssue.Name = "mdfyIssue";
            this.mdfyIssue.Size = new System.Drawing.Size(118, 33);
            this.mdfyIssue.TabIndex = 14;
            this.mdfyIssue.Text = "Modify Issue";
            this.mdfyIssue.UseVisualStyleBackColor = true;
            this.mdfyIssue.Click += new System.EventHandler(this.mdfyIssue_Click);
            // 
            // cnclMdfy
            // 
            this.cnclMdfy.Location = new System.Drawing.Point(176, 517);
            this.cnclMdfy.Name = "cnclMdfy";
            this.cnclMdfy.Size = new System.Drawing.Size(81, 32);
            this.cnclMdfy.TabIndex = 15;
            this.cnclMdfy.Text = "Cancel";
            this.cnclMdfy.UseVisualStyleBackColor = true;
            this.cnclMdfy.Click += new System.EventHandler(this.cnclMdfy_Click);
            // 
            // discDate
            // 
            this.discDate.CustomFormat = "hh:mm:ss tt d MMM yyyy";
            this.discDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.discDate.Location = new System.Drawing.Point(139, 114);
            this.discDate.Name = "discDate";
            this.discDate.Size = new System.Drawing.Size(258, 22);
            this.discDate.TabIndex = 16;
            // 
            // disc
            // 
            this.disc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disc.FormattingEnabled = true;
            this.disc.Location = new System.Drawing.Point(139, 146);
            this.disc.MaxDropDownItems = 50;
            this.disc.Name = "disc";
            this.disc.Size = new System.Drawing.Size(258, 24);
            this.disc.TabIndex = 17;
            // 
            // issStatus
            // 
            this.issStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.issStatus.FormattingEnabled = true;
            this.issStatus.Location = new System.Drawing.Point(136, 215);
            this.issStatus.Name = "issStatus";
            this.issStatus.Size = new System.Drawing.Size(261, 24);
            this.issStatus.TabIndex = 18;
            // 
            // FormModifyIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 571);
            this.Controls.Add(this.issStatus);
            this.Controls.Add(this.disc);
            this.Controls.Add(this.discDate);
            this.Controls.Add(this.cnclMdfy);
            this.Controls.Add(this.mdfyIssue);
            this.Controls.Add(this.initDesc);
            this.Controls.Add(this.issComp);
            this.Controls.Add(this.issueTitle);
            this.Controls.Add(this.issueID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormModifyIssue";
            this.Text = "FormModifyIssue";
            this.Load += new System.EventHandler(this.FormModifyIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox issueID;
        private System.Windows.Forms.TextBox issueTitle;
        private System.Windows.Forms.TextBox issComp;
        private System.Windows.Forms.RichTextBox initDesc;
        private System.Windows.Forms.Button mdfyIssue;
        private System.Windows.Forms.Button cnclMdfy;
        private System.Windows.Forms.DateTimePicker discDate;
        private System.Windows.Forms.ComboBox disc;
        private System.Windows.Forms.ComboBox issStatus;
    }
}