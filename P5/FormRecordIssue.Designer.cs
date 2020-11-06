namespace Builder
{
    partial class FormRecordIssue
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
            this.Iss_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.disc_dateTime = new System.Windows.Forms.DateTimePicker();
            this.discoverers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comp = new System.Windows.Forms.TextBox();
            this.statuses = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.initDesc = new System.Windows.Forms.RichTextBox();
            this.cnclCreate = new System.Windows.Forms.Button();
            this.crtIssue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // Iss_Id
            // 
            this.Iss_Id.Location = new System.Drawing.Point(137, 34);
            this.Iss_Id.Name = "Iss_Id";
            this.Iss_Id.ReadOnly = true;
            this.Iss_Id.Size = new System.Drawing.Size(71, 22);
            this.Iss_Id.TabIndex = 1;
            this.Iss_Id.TextChanged += new System.EventHandler(this.Iss_Id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(137, 73);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(269, 22);
            this.titleBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Discovery Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Discoverer";
            // 
            // disc_dateTime
            // 
            this.disc_dateTime.CustomFormat = "hh:mm:ss tt d MMM yyyy";
            this.disc_dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.disc_dateTime.Location = new System.Drawing.Point(137, 108);
            this.disc_dateTime.MaxDate = new System.DateTime(2020, 11, 2, 0, 0, 0, 0);
            this.disc_dateTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.disc_dateTime.Name = "disc_dateTime";
            this.disc_dateTime.Size = new System.Drawing.Size(269, 22);
            this.disc_dateTime.TabIndex = 9;
            this.disc_dateTime.Value = new System.DateTime(2020, 11, 2, 0, 0, 0, 0);
            // 
            // discoverers
            // 
            this.discoverers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discoverers.FormattingEnabled = true;
            this.discoverers.IntegralHeight = false;
            this.discoverers.Location = new System.Drawing.Point(137, 151);
            this.discoverers.MaxDropDownItems = 50;
            this.discoverers.Name = "discoverers";
            this.discoverers.Size = new System.Drawing.Size(269, 24);
            this.discoverers.TabIndex = 10;
            this.discoverers.SelectedIndexChanged += new System.EventHandler(this.discoverers_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Component";
            // 
            // comp
            // 
            this.comp.Location = new System.Drawing.Point(137, 195);
            this.comp.Name = "comp";
            this.comp.Size = new System.Drawing.Size(269, 22);
            this.comp.TabIndex = 12;
            // 
            // statuses
            // 
            this.statuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statuses.FormattingEnabled = true;
            this.statuses.Location = new System.Drawing.Point(137, 240);
            this.statuses.Name = "statuses";
            this.statuses.Size = new System.Drawing.Size(269, 24);
            this.statuses.TabIndex = 13;
            this.statuses.SelectedIndexChanged += new System.EventHandler(this.statuses_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Status";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Initial Description";
            // 
            // initDesc
            // 
            this.initDesc.Location = new System.Drawing.Point(137, 314);
            this.initDesc.Name = "initDesc";
            this.initDesc.Size = new System.Drawing.Size(269, 258);
            this.initDesc.TabIndex = 16;
            this.initDesc.Text = "";
            // 
            // cnclCreate
            // 
            this.cnclCreate.Location = new System.Drawing.Point(164, 600);
            this.cnclCreate.Name = "cnclCreate";
            this.cnclCreate.Size = new System.Drawing.Size(75, 41);
            this.cnclCreate.TabIndex = 17;
            this.cnclCreate.Text = "Cancel";
            this.cnclCreate.UseVisualStyleBackColor = true;
            this.cnclCreate.Click += new System.EventHandler(this.cnclCreate_Click);
            // 
            // crtIssue
            // 
            this.crtIssue.Location = new System.Drawing.Point(262, 600);
            this.crtIssue.Name = "crtIssue";
            this.crtIssue.Size = new System.Drawing.Size(144, 41);
            this.crtIssue.TabIndex = 18;
            this.crtIssue.Text = "Create Issue";
            this.crtIssue.UseVisualStyleBackColor = true;
            this.crtIssue.Click += new System.EventHandler(this.crtIssue_Click);
            // 
            // FormRecordIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 653);
            this.Controls.Add(this.crtIssue);
            this.Controls.Add(this.cnclCreate);
            this.Controls.Add(this.initDesc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statuses);
            this.Controls.Add(this.comp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.discoverers);
            this.Controls.Add(this.disc_dateTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Iss_Id);
            this.Controls.Add(this.label1);
            this.Name = "FormRecordIssue";
            this.Text = "Record Issue";
            this.Load += new System.EventHandler(this.FormRecordIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Iss_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker disc_dateTime;
        private System.Windows.Forms.ComboBox discoverers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox comp;
        private System.Windows.Forms.ComboBox statuses;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox initDesc;
        private System.Windows.Forms.Button cnclCreate;
        private System.Windows.Forms.Button crtIssue;
    }
}