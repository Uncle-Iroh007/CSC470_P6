namespace Builder
{
    partial class FormSelectRequirementToModify
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
            this.featureList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reqList = new System.Windows.Forms.DataGridView();
            this.reqId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqStatement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selReq = new System.Windows.Forms.Button();
            this.cncl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reqList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feature :";
            // 
            // featureList
            // 
            this.featureList.FormattingEnabled = true;
            this.featureList.Location = new System.Drawing.Point(136, 28);
            this.featureList.Name = "featureList";
            this.featureList.Size = new System.Drawing.Size(623, 24);
            this.featureList.TabIndex = 1;
            this.featureList.Text = "< Make Selection >";
            this.featureList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Requirements :";
            // 
            // reqList
            // 
            this.reqList.AllowUserToAddRows = false;
            this.reqList.AllowUserToDeleteRows = false;
            this.reqList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reqList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reqId,
            this.reqStatement});
            this.reqList.Location = new System.Drawing.Point(136, 77);
            this.reqList.MultiSelect = false;
            this.reqList.Name = "reqList";
            this.reqList.ReadOnly = true;
            this.reqList.RowHeadersWidth = 51;
            this.reqList.RowTemplate.Height = 24;
            this.reqList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reqList.Size = new System.Drawing.Size(623, 333);
            this.reqList.TabIndex = 3;
            // 
            // reqId
            // 
            this.reqId.HeaderText = "Id";
            this.reqId.MinimumWidth = 6;
            this.reqId.Name = "reqId";
            this.reqId.ReadOnly = true;
            this.reqId.Width = 60;
            // 
            // reqStatement
            // 
            this.reqStatement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reqStatement.HeaderText = "Requirement";
            this.reqStatement.MinimumWidth = 6;
            this.reqStatement.Name = "reqStatement";
            this.reqStatement.ReadOnly = true;
            this.reqStatement.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // selReq
            // 
            this.selReq.Location = new System.Drawing.Point(572, 439);
            this.selReq.Name = "selReq";
            this.selReq.Size = new System.Drawing.Size(146, 33);
            this.selReq.TabIndex = 4;
            this.selReq.Text = "Select Requirement";
            this.selReq.UseVisualStyleBackColor = true;
            this.selReq.Click += new System.EventHandler(this.selReq_Click);
            // 
            // cncl
            // 
            this.cncl.Location = new System.Drawing.Point(450, 439);
            this.cncl.Name = "cncl";
            this.cncl.Size = new System.Drawing.Size(87, 33);
            this.cncl.TabIndex = 5;
            this.cncl.Text = "Cancel";
            this.cncl.UseVisualStyleBackColor = true;
            this.cncl.Click += new System.EventHandler(this.cncl_Click);
            // 
            // FormSelectRequirementToModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.cncl);
            this.Controls.Add(this.selReq);
            this.Controls.Add(this.reqList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.featureList);
            this.Controls.Add(this.label1);
            this.Name = "FormSelectRequirementToModify";
            this.Text = "FormSelectRequirementToModify";
            this.Load += new System.EventHandler(this.FormSelectRequirementToModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reqList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox featureList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView reqList;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqId;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqStatement;
        private System.Windows.Forms.Button selReq;
        private System.Windows.Forms.Button cncl;
    }
}