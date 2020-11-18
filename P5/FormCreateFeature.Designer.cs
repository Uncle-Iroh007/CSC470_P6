namespace Builder
{
    partial class FormCreateFeature
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
            this.newFeatTitle = new System.Windows.Forms.TextBox();
            this.cnclFeat = new System.Windows.Forms.Button();
            this.CreateFeat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title :";
            // 
            // newFeatTitle
            // 
            this.newFeatTitle.Location = new System.Drawing.Point(127, 43);
            this.newFeatTitle.Name = "newFeatTitle";
            this.newFeatTitle.Size = new System.Drawing.Size(420, 22);
            this.newFeatTitle.TabIndex = 1;
            // 
            // cnclFeat
            // 
            this.cnclFeat.Location = new System.Drawing.Point(337, 87);
            this.cnclFeat.Name = "cnclFeat";
            this.cnclFeat.Size = new System.Drawing.Size(75, 32);
            this.cnclFeat.TabIndex = 2;
            this.cnclFeat.Text = "Cancel";
            this.cnclFeat.UseVisualStyleBackColor = true;
            this.cnclFeat.Click += new System.EventHandler(this.cnclFeat_Click);
            // 
            // CreateFeat
            // 
            this.CreateFeat.Location = new System.Drawing.Point(434, 87);
            this.CreateFeat.Name = "CreateFeat";
            this.CreateFeat.Size = new System.Drawing.Size(113, 32);
            this.CreateFeat.TabIndex = 3;
            this.CreateFeat.Text = "Create Feature";
            this.CreateFeat.UseVisualStyleBackColor = true;
            this.CreateFeat.Click += new System.EventHandler(this.CreateFeat_Click);
            // 
            // FormCreateFeature
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(598, 156);
            this.Controls.Add(this.CreateFeat);
            this.Controls.Add(this.cnclFeat);
            this.Controls.Add(this.newFeatTitle);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateFeature";
            this.Text = "Create Feature";
            this.Load += new System.EventHandler(this.FormCreateFeature_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newFeatTitle;
        private System.Windows.Forms.Button cnclFeat;
        private System.Windows.Forms.Button CreateFeat;
    }
}