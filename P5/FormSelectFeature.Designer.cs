namespace Builder
{
    partial class FormSelectFeature
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
            this.featList = new System.Windows.Forms.DataGridView();
            this.featId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnclSel = new System.Windows.Forms.Button();
            this.selFeat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.featList)).BeginInit();
            this.SuspendLayout();
            // 
            // featList
            // 
            this.featList.AllowUserToAddRows = false;
            this.featList.AllowUserToDeleteRows = false;
            this.featList.AllowUserToResizeColumns = false;
            this.featList.AllowUserToResizeRows = false;
            this.featList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.featList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.featId,
            this.feat});
            this.featList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.featList.Location = new System.Drawing.Point(28, 29);
            this.featList.MultiSelect = false;
            this.featList.Name = "featList";
            this.featList.ReadOnly = true;
            this.featList.RowHeadersWidth = 51;
            this.featList.RowTemplate.Height = 24;
            this.featList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.featList.Size = new System.Drawing.Size(634, 277);
            this.featList.TabIndex = 0;
            // 
            // featId
            // 
            this.featId.HeaderText = "Id";
            this.featId.MinimumWidth = 6;
            this.featId.Name = "featId";
            this.featId.ReadOnly = true;
            this.featId.Width = 60;
            // 
            // feat
            // 
            this.feat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.feat.HeaderText = "Feature";
            this.feat.MinimumWidth = 6;
            this.feat.Name = "feat";
            this.feat.ReadOnly = true;
            this.feat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cnclSel
            // 
            this.cnclSel.Location = new System.Drawing.Point(425, 343);
            this.cnclSel.Name = "cnclSel";
            this.cnclSel.Size = new System.Drawing.Size(92, 35);
            this.cnclSel.TabIndex = 1;
            this.cnclSel.Text = "Cancel";
            this.cnclSel.UseVisualStyleBackColor = true;
            // 
            // selFeat
            // 
            this.selFeat.Location = new System.Drawing.Point(538, 343);
            this.selFeat.Name = "selFeat";
            this.selFeat.Size = new System.Drawing.Size(124, 35);
            this.selFeat.TabIndex = 2;
            this.selFeat.Text = "Select Feature";
            this.selFeat.UseVisualStyleBackColor = true;
            this.selFeat.Click += new System.EventHandler(this.selFeat_Click);
            // 
            // FormSelectFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 418);
            this.Controls.Add(this.selFeat);
            this.Controls.Add(this.cnclSel);
            this.Controls.Add(this.featList);
            this.Name = "FormSelectFeature";
            this.Text = "Select Feature";
            this.Load += new System.EventHandler(this.FormSelectFeature_Load);
            ((System.ComponentModel.ISupportInitialize)(this.featList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView featList;
        private System.Windows.Forms.DataGridViewTextBoxColumn featId;
        private System.Windows.Forms.DataGridViewTextBoxColumn feat;
        private System.Windows.Forms.Button cnclSel;
        private System.Windows.Forms.Button selFeat;
    }
}