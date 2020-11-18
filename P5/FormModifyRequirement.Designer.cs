namespace Builder
{
    partial class FormModifyRequirement
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
            this.featsList = new System.Windows.Forms.ComboBox();
            this.statBox = new System.Windows.Forms.RichTextBox();
            this.cncl = new System.Windows.Forms.Button();
            this.mdfyReq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feature :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Statement :";
            // 
            // featsList
            // 
            this.featsList.FormattingEnabled = true;
            this.featsList.Location = new System.Drawing.Point(126, 53);
            this.featsList.Name = "featsList";
            this.featsList.Size = new System.Drawing.Size(625, 24);
            this.featsList.TabIndex = 2;
            // 
            // statBox
            // 
            this.statBox.Location = new System.Drawing.Point(126, 100);
            this.statBox.Name = "statBox";
            this.statBox.Size = new System.Drawing.Size(625, 292);
            this.statBox.TabIndex = 3;
            this.statBox.Text = "";
            // 
            // cncl
            // 
            this.cncl.Location = new System.Drawing.Point(428, 425);
            this.cncl.Name = "cncl";
            this.cncl.Size = new System.Drawing.Size(110, 35);
            this.cncl.TabIndex = 4;
            this.cncl.Text = "Cancel";
            this.cncl.UseVisualStyleBackColor = true;
            this.cncl.Click += new System.EventHandler(this.cncl_Click);
            // 
            // mdfyReq
            // 
            this.mdfyReq.Location = new System.Drawing.Point(574, 425);
            this.mdfyReq.Name = "mdfyReq";
            this.mdfyReq.Size = new System.Drawing.Size(177, 35);
            this.mdfyReq.TabIndex = 5;
            this.mdfyReq.Text = "Modify Requirement";
            this.mdfyReq.UseVisualStyleBackColor = true;
            this.mdfyReq.Click += new System.EventHandler(this.mdfyReq_Click);
            // 
            // FormModifyRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.mdfyReq);
            this.Controls.Add(this.cncl);
            this.Controls.Add(this.statBox);
            this.Controls.Add(this.featsList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormModifyRequirement";
            this.Text = "FormModifyRequirement";
            this.Load += new System.EventHandler(this.FormModifyRequirement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox featsList;
        private System.Windows.Forms.RichTextBox statBox;
        private System.Windows.Forms.Button cncl;
        private System.Windows.Forms.Button mdfyReq;
    }
}