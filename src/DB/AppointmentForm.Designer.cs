namespace DB
{
    partial class AppointmentForm
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
            this.DoctorFK = new System.Windows.Forms.Label();
            this.DoctorFKInput = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.patientNameInput = new System.Windows.Forms.MaskedTextBox();
            this.DoctorBirthdayLabel = new System.Windows.Forms.Label();
            this.patientBirthdayInput = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.MaskedTextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoctorFK
            // 
            this.DoctorFK.AutoSize = true;
            this.DoctorFK.Location = new System.Drawing.Point(12, 44);
            this.DoctorFK.Name = "DoctorFK";
            this.DoctorFK.Size = new System.Drawing.Size(50, 13);
            this.DoctorFK.TabIndex = 3;
            this.DoctorFK.Text = "№ врача";
            this.DoctorFK.Click += new System.EventHandler(this.DoctorName_Click);
            // 
            // DoctorFKInput
            // 
            this.DoctorFKInput.Location = new System.Drawing.Point(115, 37);
            this.DoctorFKInput.Name = "DoctorFKInput";
            this.DoctorFKInput.Size = new System.Drawing.Size(100, 20);
            this.DoctorFKInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ФИО пациента";
            // 
            // patientNameInput
            // 
            this.patientNameInput.Location = new System.Drawing.Point(115, 77);
            this.patientNameInput.Name = "patientNameInput";
            this.patientNameInput.Size = new System.Drawing.Size(134, 20);
            this.patientNameInput.TabIndex = 6;
            // 
            // DoctorBirthdayLabel
            // 
            this.DoctorBirthdayLabel.AutoSize = true;
            this.DoctorBirthdayLabel.Location = new System.Drawing.Point(10, 118);
            this.DoctorBirthdayLabel.Name = "DoctorBirthdayLabel";
            this.DoctorBirthdayLabel.Size = new System.Drawing.Size(86, 13);
            this.DoctorBirthdayLabel.TabIndex = 7;
            this.DoctorBirthdayLabel.Text = "Дата рождения";
            // 
            // patientBirthdayInput
            // 
            this.patientBirthdayInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientBirthdayInput.Location = new System.Drawing.Point(115, 118);
            this.patientBirthdayInput.Mask = "00/00/0000";
            this.patientBirthdayInput.Name = "patientBirthdayInput";
            this.patientBirthdayInput.Size = new System.Drawing.Size(60, 13);
            this.patientBirthdayInput.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дата встречи";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateInput
            // 
            this.dateInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateInput.Location = new System.Drawing.Point(115, 159);
            this.dateInput.Mask = "00/00/0000";
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(60, 13);
            this.dateInput.TabIndex = 10;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(63, 205);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(152, 35);
            this.Save.TabIndex = 11;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 263);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patientBirthdayInput);
            this.Controls.Add(this.DoctorBirthdayLabel);
            this.Controls.Add(this.patientNameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoctorFKInput);
            this.Controls.Add(this.DoctorFK);
            this.Name = "AppointmentForm";
            this.Text = "Создать встречу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DoctorFK;
        private System.Windows.Forms.MaskedTextBox DoctorFKInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox patientNameInput;
        private System.Windows.Forms.Label DoctorBirthdayLabel;
        private System.Windows.Forms.MaskedTextBox patientBirthdayInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox dateInput;
        private System.Windows.Forms.Button Save;
    }
}