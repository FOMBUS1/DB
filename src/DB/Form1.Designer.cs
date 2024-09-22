namespace DB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DoctorAddButton = new System.Windows.Forms.Button();
            this.AppointmentAddButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DoctorEditButton = new System.Windows.Forms.Button();
            this.AppointmentEdit = new System.Windows.Forms.Button();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jotTitleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasportSeriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasportNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DB.DataSet1();
            this.appointemtIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteDoctor = new System.Windows.Forms.Button();
            this.DeleteAppointment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointemtIDDataGridViewTextBoxColumn,
            this.doctorFKDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.patientBirthdayDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.appointmentsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 301);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(867, 178);
            this.dataGridView2.TabIndex = 24;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // DoctorAddButton
            // 
            this.DoctorAddButton.Location = new System.Drawing.Point(885, 93);
            this.DoctorAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.DoctorAddButton.Name = "DoctorAddButton";
            this.DoctorAddButton.Size = new System.Drawing.Size(113, 57);
            this.DoctorAddButton.TabIndex = 30;
            this.DoctorAddButton.Text = "Добавить запись";
            this.DoctorAddButton.UseVisualStyleBackColor = true;
            this.DoctorAddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AppointmentAddButton
            // 
            this.AppointmentAddButton.Location = new System.Drawing.Point(885, 352);
            this.AppointmentAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AppointmentAddButton.Name = "AppointmentAddButton";
            this.AppointmentAddButton.Size = new System.Drawing.Size(113, 34);
            this.AppointmentAddButton.TabIndex = 31;
            this.AppointmentAddButton.Text = "Добавить запись";
            this.AppointmentAddButton.UseVisualStyleBackColor = true;
            this.AppointmentAddButton.Click += new System.EventHandler(this.AppointmentAddButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.departmentIDDataGridViewTextBoxColumn,
            this.jotTitleIDDataGridViewTextBoxColumn,
            this.pasportSeriesDataGridViewTextBoxColumn,
            this.pasportNumberDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.doctorsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 51);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 44;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(867, 231);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEdited);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // DoctorEditButton
            // 
            this.DoctorEditButton.Location = new System.Drawing.Point(885, 155);
            this.DoctorEditButton.Name = "DoctorEditButton";
            this.DoctorEditButton.Size = new System.Drawing.Size(113, 57);
            this.DoctorEditButton.TabIndex = 34;
            this.DoctorEditButton.Text = "Редактировать запись";
            this.DoctorEditButton.UseVisualStyleBackColor = true;
            this.DoctorEditButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AppointmentEdit
            // 
            this.AppointmentEdit.Location = new System.Drawing.Point(885, 391);
            this.AppointmentEdit.Name = "AppointmentEdit";
            this.AppointmentEdit.Size = new System.Drawing.Size(113, 34);
            this.AppointmentEdit.TabIndex = 35;
            this.AppointmentEdit.Text = "Редактировать запись";
            this.AppointmentEdit.UseVisualStyleBackColor = true;
            this.AppointmentEdit.Click += new System.EventHandler(this.AppointmentEdit_Click);
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.doctorIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "День Рождения";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "Отделение";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            this.departmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jotTitleIDDataGridViewTextBoxColumn
            // 
            this.jotTitleIDDataGridViewTextBoxColumn.DataPropertyName = "JotTitleID";
            this.jotTitleIDDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.jotTitleIDDataGridViewTextBoxColumn.Name = "jotTitleIDDataGridViewTextBoxColumn";
            this.jotTitleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pasportSeriesDataGridViewTextBoxColumn
            // 
            this.pasportSeriesDataGridViewTextBoxColumn.DataPropertyName = "PasportSeries";
            this.pasportSeriesDataGridViewTextBoxColumn.HeaderText = "Серия паспорта";
            this.pasportSeriesDataGridViewTextBoxColumn.Name = "pasportSeriesDataGridViewTextBoxColumn";
            this.pasportSeriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pasportNumberDataGridViewTextBoxColumn
            // 
            this.pasportNumberDataGridViewTextBoxColumn.DataPropertyName = "PasportNumber";
            this.pasportNumberDataGridViewTextBoxColumn.HeaderText = "Номер паспорта";
            this.pasportNumberDataGridViewTextBoxColumn.Name = "pasportNumberDataGridViewTextBoxColumn";
            this.pasportNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            this.doctorsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointemtIDDataGridViewTextBoxColumn
            // 
            this.appointemtIDDataGridViewTextBoxColumn.DataPropertyName = "AppointemtID";
            this.appointemtIDDataGridViewTextBoxColumn.HeaderText = "AppointemtID";
            this.appointemtIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appointemtIDDataGridViewTextBoxColumn.Name = "appointemtIDDataGridViewTextBoxColumn";
            this.appointemtIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // doctorFKDataGridViewTextBoxColumn
            // 
            this.doctorFKDataGridViewTextBoxColumn.DataPropertyName = "DoctorFK";
            this.doctorFKDataGridViewTextBoxColumn.HeaderText = "Врач";
            this.doctorFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorFKDataGridViewTextBoxColumn.Name = "doctorFKDataGridViewTextBoxColumn";
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "ФИО Пациента";
            this.patientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            // 
            // patientBirthdayDataGridViewTextBoxColumn
            // 
            this.patientBirthdayDataGridViewTextBoxColumn.DataPropertyName = "PatientBirthday";
            this.patientBirthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения пациента";
            this.patientBirthdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientBirthdayDataGridViewTextBoxColumn.Name = "patientBirthdayDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата встречи";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.dataSet1;
            // 
            // DeleteDoctor
            // 
            this.DeleteDoctor.Location = new System.Drawing.Point(885, 225);
            this.DeleteDoctor.Name = "DeleteDoctor";
            this.DeleteDoctor.Size = new System.Drawing.Size(113, 57);
            this.DeleteDoctor.TabIndex = 41;
            this.DeleteDoctor.Text = "Удалить запись";
            this.DeleteDoctor.UseVisualStyleBackColor = true;
            this.DeleteDoctor.Click += new System.EventHandler(this.DeleteDoctor_Click);
            // 
            // DeleteAppointment
            // 
            this.DeleteAppointment.Location = new System.Drawing.Point(885, 431);
            this.DeleteAppointment.Name = "DeleteAppointment";
            this.DeleteAppointment.Size = new System.Drawing.Size(113, 34);
            this.DeleteAppointment.TabIndex = 42;
            this.DeleteAppointment.Text = "Удалить запись";
            this.DeleteAppointment.UseVisualStyleBackColor = true;
            this.DeleteAppointment.Click += new System.EventHandler(this.DeleteAppointment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 517);
            this.Controls.Add(this.DeleteAppointment);
            this.Controls.Add(this.DeleteDoctor);
            this.Controls.Add(this.AppointmentEdit);
            this.Controls.Add(this.DoctorEditButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AppointmentAddButton);
            this.Controls.Add(this.DoctorAddButton);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jotTitleFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private System.Windows.Forms.Button DoctorAddButton;
        private System.Windows.Forms.Button AppointmentAddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jotTitleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasportSeriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasportNumberDataGridViewTextBoxColumn;
        protected internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointemtIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientBirthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DoctorEditButton;
        private System.Windows.Forms.Button AppointmentEdit;
        private System.Windows.Forms.Button DeleteDoctor;
        private System.Windows.Forms.Button DeleteAppointment;
    }
}

