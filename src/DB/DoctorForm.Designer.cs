namespace DB
{
    partial class DoctorForm
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
            this.Save = new System.Windows.Forms.Button();
            this.DoctorNameInput = new System.Windows.Forms.MaskedTextBox();
            this.DoctorName = new System.Windows.Forms.Label();
            this.DoctorBirthdayLabel = new System.Windows.Forms.Label();
            this.DoctorBirthdayInput = new System.Windows.Forms.MaskedTextBox();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.DepartmentInput = new System.Windows.Forms.MaskedTextBox();
            this.JobTitleLabel = new System.Windows.Forms.Label();
            this.JobTitleInput = new System.Windows.Forms.MaskedTextBox();
            this.PassportSeriesLabel = new System.Windows.Forms.Label();
            this.SeriesInput = new System.Windows.Forms.MaskedTextBox();
            this.PassportNumberLabel = new System.Windows.Forms.Label();
            this.NumberInput = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(75, 295);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(152, 35);
            this.Save.TabIndex = 0;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // DoctorNameInput
            // 
            this.DoctorNameInput.Location = new System.Drawing.Point(108, 66);
            this.DoctorNameInput.Name = "DoctorNameInput";
            this.DoctorNameInput.Size = new System.Drawing.Size(182, 20);
            this.DoctorNameInput.TabIndex = 1;
            // 
            // DoctorName
            // 
            this.DoctorName.AutoSize = true;
            this.DoctorName.Location = new System.Drawing.Point(12, 69);
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.Size = new System.Drawing.Size(66, 13);
            this.DoctorName.TabIndex = 2;
            this.DoctorName.Text = "ФИО врача";
            // 
            // DoctorBirthdayLabel
            // 
            this.DoctorBirthdayLabel.AutoSize = true;
            this.DoctorBirthdayLabel.Location = new System.Drawing.Point(12, 100);
            this.DoctorBirthdayLabel.Name = "DoctorBirthdayLabel";
            this.DoctorBirthdayLabel.Size = new System.Drawing.Size(86, 13);
            this.DoctorBirthdayLabel.TabIndex = 3;
            this.DoctorBirthdayLabel.Text = "Дата рождения";
            // 
            // DoctorBirthdayInput
            // 
            this.DoctorBirthdayInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoctorBirthdayInput.Location = new System.Drawing.Point(167, 97);
            this.DoctorBirthdayInput.Mask = "00/00/0000";
            this.DoctorBirthdayInput.Name = "DoctorBirthdayInput";
            this.DoctorBirthdayInput.Size = new System.Drawing.Size(60, 13);
            this.DoctorBirthdayInput.TabIndex = 4;
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(12, 128);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(76, 13);
            this.DepartmentLabel.TabIndex = 5;
            this.DepartmentLabel.Text = "№ Отделения";
            // 
            // DepartmentInput
            // 
            this.DepartmentInput.Location = new System.Drawing.Point(167, 125);
            this.DepartmentInput.Name = "DepartmentInput";
            this.DepartmentInput.Size = new System.Drawing.Size(60, 20);
            this.DepartmentInput.TabIndex = 6;
            // 
            // JobTitleLabel
            // 
            this.JobTitleLabel.AutoSize = true;
            this.JobTitleLabel.Location = new System.Drawing.Point(12, 160);
            this.JobTitleLabel.Name = "JobTitleLabel";
            this.JobTitleLabel.Size = new System.Drawing.Size(79, 13);
            this.JobTitleLabel.TabIndex = 7;
            this.JobTitleLabel.Text = "№ Должности";
            // 
            // JobTitleInput
            // 
            this.JobTitleInput.Location = new System.Drawing.Point(167, 157);
            this.JobTitleInput.Name = "JobTitleInput";
            this.JobTitleInput.Size = new System.Drawing.Size(60, 20);
            this.JobTitleInput.TabIndex = 8;
            // 
            // PassportSeriesLabel
            // 
            this.PassportSeriesLabel.AutoSize = true;
            this.PassportSeriesLabel.Location = new System.Drawing.Point(12, 190);
            this.PassportSeriesLabel.Name = "PassportSeriesLabel";
            this.PassportSeriesLabel.Size = new System.Drawing.Size(88, 13);
            this.PassportSeriesLabel.TabIndex = 9;
            this.PassportSeriesLabel.Text = "Серия паспорта";
            this.PassportSeriesLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // SeriesInput
            // 
            this.SeriesInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SeriesInput.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SeriesInput.Location = new System.Drawing.Point(167, 190);
            this.SeriesInput.Mask = "0000";
            this.SeriesInput.Name = "SeriesInput";
            this.SeriesInput.Size = new System.Drawing.Size(60, 13);
            this.SeriesInput.TabIndex = 10;
            this.SeriesInput.ValidatingType = typeof(int);
            // 
            // PassportNumberLabel
            // 
            this.PassportNumberLabel.AutoSize = true;
            this.PassportNumberLabel.Location = new System.Drawing.Point(12, 222);
            this.PassportNumberLabel.Name = "PassportNumberLabel";
            this.PassportNumberLabel.Size = new System.Drawing.Size(91, 13);
            this.PassportNumberLabel.TabIndex = 11;
            this.PassportNumberLabel.Text = "Номер паспорта";
            this.PassportNumberLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // NumberInput
            // 
            this.NumberInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumberInput.ForeColor = System.Drawing.SystemColors.InfoText;
            this.NumberInput.Location = new System.Drawing.Point(167, 222);
            this.NumberInput.Mask = "000000";
            this.NumberInput.Name = "NumberInput";
            this.NumberInput.Size = new System.Drawing.Size(60, 13);
            this.NumberInput.TabIndex = 12;
            this.NumberInput.ValidatingType = typeof(int);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 358);
            this.Controls.Add(this.NumberInput);
            this.Controls.Add(this.PassportNumberLabel);
            this.Controls.Add(this.SeriesInput);
            this.Controls.Add(this.PassportSeriesLabel);
            this.Controls.Add(this.JobTitleInput);
            this.Controls.Add(this.JobTitleLabel);
            this.Controls.Add(this.DepartmentInput);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.DoctorBirthdayInput);
            this.Controls.Add(this.DoctorBirthdayLabel);
            this.Controls.Add(this.DoctorName);
            this.Controls.Add(this.DoctorNameInput);
            this.Controls.Add(this.Save);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.MaskedTextBox DoctorNameInput;
        private System.Windows.Forms.Label DoctorName;
        private System.Windows.Forms.Label DoctorBirthdayLabel;
        private System.Windows.Forms.MaskedTextBox DoctorBirthdayInput;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.MaskedTextBox DepartmentInput;
        private System.Windows.Forms.Label JobTitleLabel;
        private System.Windows.Forms.MaskedTextBox JobTitleInput;
        private System.Windows.Forms.Label PassportSeriesLabel;
        private System.Windows.Forms.MaskedTextBox SeriesInput;
        private System.Windows.Forms.Label PassportNumberLabel;
        private System.Windows.Forms.MaskedTextBox NumberInput;
    }
}