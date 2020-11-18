namespace Builder
{
    partial class FormCreateRequirement
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
            this.statMentBox = new System.Windows.Forms.RichTextBox();
            this.cnclReqCrt = new System.Windows.Forms.Button();
            this.CrtReq = new System.Windows.Forms.Button();
            this.selFeat = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feature : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Statement :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // statMentBox
            // 
            this.statMentBox.Location = new System.Drawing.Point(104, 92);
            this.statMentBox.Name = "statMentBox";
            this.statMentBox.Size = new System.Drawing.Size(519, 298);
            this.statMentBox.TabIndex = 3;
            this.statMentBox.Text = "";
            this.statMentBox.TextChanged += new System.EventHandler(this.statMentBox_TextChanged);
            // 
            // cnclReqCrt
            // 
            this.cnclReqCrt.Location = new System.Drawing.Point(341, 407);
            this.cnclReqCrt.Name = "cnclReqCrt";
            this.cnclReqCrt.Size = new System.Drawing.Size(86, 31);
            this.cnclReqCrt.TabIndex = 4;
            this.cnclReqCrt.Text = "Cancel";
            this.cnclReqCrt.UseVisualStyleBackColor = true;
            this.cnclReqCrt.Click += new System.EventHandler(this.cnclReqCrt_Click);
            // 
            // CrtReq
            // 
            this.CrtReq.Location = new System.Drawing.Point(449, 407);
            this.CrtReq.Name = "CrtReq";
            this.CrtReq.Size = new System.Drawing.Size(174, 31);
            this.CrtReq.TabIndex = 5;
            this.CrtReq.Text = "Create Requirement";
            this.CrtReq.UseVisualStyleBackColor = true;
            this.CrtReq.Click += new System.EventHandler(this.CrtReq_Click);
            // 
            // selFeat
            // 
            this.selFeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selFeat.FormattingEnabled = true;
            this.selFeat.Location = new System.Drawing.Point(104, 36);
            this.selFeat.MaxDropDownItems = 80;
            this.selFeat.Name = "selFeat";
            this.selFeat.Size = new System.Drawing.Size(519, 24);
            this.selFeat.TabIndex = 6;
            this.selFeat.SelectedIndexChanged += new System.EventHandler(this.selFeat_SelectedIndexChanged);
            // 
            // FormCreateRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 491);
            this.Controls.Add(this.selFeat);
            this.Controls.Add(this.CrtReq);
            this.Controls.Add(this.cnclReqCrt);
            this.Controls.Add(this.statMentBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateRequirement";
            this.Text = "Create Requirement";
            this.Load += new System.EventHandler(this.FormCreateRequirement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox statMentBox;
        private System.Windows.Forms.Button cnclReqCrt;
        private System.Windows.Forms.Button CrtReq;
        private System.Windows.Forms.ComboBox selFeat;
    }
}