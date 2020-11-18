namespace Builder
{
    partial class FormSelectFeatureToRemove
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
            this.featureId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.featTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnclRem = new System.Windows.Forms.Button();
            this.selFeatToRem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.featureId,
            this.featTitle});
            this.dataGridView1.Location = new System.Drawing.Point(62, 39);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(677, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // featureId
            // 
            this.featureId.HeaderText = "Id";
            this.featureId.MinimumWidth = 6;
            this.featureId.Name = "featureId";
            this.featureId.ReadOnly = true;
            this.featureId.Width = 60;
            // 
            // featTitle
            // 
            this.featTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.featTitle.HeaderText = "Feature";
            this.featTitle.MinimumWidth = 6;
            this.featTitle.Name = "featTitle";
            this.featTitle.ReadOnly = true;
            this.featTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cnclRem
            // 
            this.cnclRem.Location = new System.Drawing.Point(526, 419);
            this.cnclRem.Name = "cnclRem";
            this.cnclRem.Size = new System.Drawing.Size(75, 39);
            this.cnclRem.TabIndex = 1;
            this.cnclRem.Text = "Cancel";
            this.cnclRem.UseVisualStyleBackColor = true;
            this.cnclRem.Click += new System.EventHandler(this.cnclRem_Click);
            // 
            // selFeatToRem
            // 
            this.selFeatToRem.Location = new System.Drawing.Point(621, 419);
            this.selFeatToRem.Name = "selFeatToRem";
            this.selFeatToRem.Size = new System.Drawing.Size(118, 39);
            this.selFeatToRem.TabIndex = 2;
            this.selFeatToRem.Text = "Select Feature";
            this.selFeatToRem.UseVisualStyleBackColor = true;
            this.selFeatToRem.Click += new System.EventHandler(this.selFeatToRem_Click);
            // 
            // FormSelectFeatureToRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.selFeatToRem);
            this.Controls.Add(this.cnclRem);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "FormSelectFeatureToRemove";
            this.Text = "Select Feature";
            this.Load += new System.EventHandler(this.FormSelectFeatureToRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn featureId;
        private System.Windows.Forms.DataGridViewTextBoxColumn featTitle;
        private System.Windows.Forms.Button cnclRem;
        private System.Windows.Forms.Button selFeatToRem;
    }
}