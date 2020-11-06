namespace Builder
{
    partial class SelectIssue
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selIss = new System.Windows.Forms.Button();
            this.cnclSel = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.tille,
            this.discDate,
            this.disc,
            this.initDesc,
            this.comp,
            this.stat});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(927, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // selIss
            // 
            this.selIss.Location = new System.Drawing.Point(786, 440);
            this.selIss.Name = "selIss";
            this.selIss.Size = new System.Drawing.Size(153, 38);
            this.selIss.TabIndex = 1;
            this.selIss.Text = "Select Issue";
            this.selIss.UseVisualStyleBackColor = true;
            // 
            // cnclSel
            // 
            this.cnclSel.Location = new System.Drawing.Point(656, 440);
            this.cnclSel.Name = "cnclSel";
            this.cnclSel.Size = new System.Drawing.Size(99, 38);
            this.cnclSel.TabIndex = 2;
            this.cnclSel.Text = "Cancel";
            this.cnclSel.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 40;
            // 
            // tille
            // 
            this.tille.HeaderText = "Title";
            this.tille.MinimumWidth = 6;
            this.tille.Name = "tille";
            this.tille.Width = 180;
            // 
            // discDate
            // 
            this.discDate.HeaderText = "Discovery Date";
            this.discDate.MinimumWidth = 6;
            this.discDate.Name = "discDate";
            this.discDate.Width = 125;
            // 
            // disc
            // 
            this.disc.HeaderText = "Discoverer";
            this.disc.MinimumWidth = 6;
            this.disc.Name = "disc";
            this.disc.Width = 125;
            // 
            // initDesc
            // 
            this.initDesc.HeaderText = "Initial Description";
            this.initDesc.MinimumWidth = 6;
            this.initDesc.Name = "initDesc";
            this.initDesc.Width = 125;
            // 
            // comp
            // 
            this.comp.HeaderText = "Component";
            this.comp.MinimumWidth = 6;
            this.comp.Name = "comp";
            this.comp.Width = 125;
            // 
            // stat
            // 
            this.stat.HeaderText = "Status";
            this.stat.MinimumWidth = 6;
            this.stat.Name = "stat";
            this.stat.Width = 125;
            // 
            // SelectIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 506);
            this.Controls.Add(this.cnclSel);
            this.Controls.Add(this.selIss);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SelectIssue";
            this.Text = "SelectIssue";
            this.Load += new System.EventHandler(this.SelectIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button selIss;
        private System.Windows.Forms.Button cnclSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tille;
        private System.Windows.Forms.DataGridViewTextBoxColumn discDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn initDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn comp;
        private System.Windows.Forms.DataGridViewTextBoxColumn stat;
    }
}