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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DoctorAddButton = new System.Windows.Forms.Button();
            this.AppointmentAddButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jotTitleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasportSeriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasportNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DB.DataSet1();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointemtIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorEditButton = new System.Windows.Forms.Button();
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
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dataGridView2.Size = new System.Drawing.Size(623, 84);
            this.dataGridView2.TabIndex = 24;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // DoctorAddButton
            // 
            this.DoctorAddButton.Location = new System.Drawing.Point(669, 50);
            this.DoctorAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.DoctorAddButton.Name = "DoctorAddButton";
            this.DoctorAddButton.Size = new System.Drawing.Size(113, 37);
            this.DoctorAddButton.TabIndex = 30;
            this.DoctorAddButton.Text = "Добавить";
            this.DoctorAddButton.UseVisualStyleBackColor = true;
            this.DoctorAddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AppointmentAddButton
            // 
            this.AppointmentAddButton.Location = new System.Drawing.Point(669, 301);
            this.AppointmentAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AppointmentAddButton.Name = "AppointmentAddButton";
            this.AppointmentAddButton.Size = new System.Drawing.Size(88, 34);
            this.AppointmentAddButton.TabIndex = 31;
            this.AppointmentAddButton.Text = "Добавить";
            this.AppointmentAddButton.UseVisualStyleBackColor = true;
            this.AppointmentAddButton.Click += new System.EventHandler(this.AppointmentAddButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.departmentIDDataGridViewTextBoxColumn,
            this.jotTitleIDDataGridViewTextBoxColumn,
            this.pasportSeriesDataGridViewTextBoxColumn,
            this.pasportNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(650, 98);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEdited);
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
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.dataSet1;
            // 
            // appointemtIDDataGridViewTextBoxColumn
            // 
            this.appointemtIDDataGridViewTextBoxColumn.DataPropertyName = "AppointemtID";
            this.appointemtIDDataGridViewTextBoxColumn.HeaderText = "AppointemtID";
            this.appointemtIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appointemtIDDataGridViewTextBoxColumn.Name = "appointemtIDDataGridViewTextBoxColumn";
            this.appointemtIDDataGridViewTextBoxColumn.Visible = false;
            this.appointemtIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorFKDataGridViewTextBoxColumn
            // 
            this.doctorFKDataGridViewTextBoxColumn.DataPropertyName = "DoctorFK";
            this.doctorFKDataGridViewTextBoxColumn.HeaderText = "Врач";
            this.doctorFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorFKDataGridViewTextBoxColumn.Name = "doctorFKDataGridViewTextBoxColumn";
            this.doctorFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "ФИО Пациента";
            this.patientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            this.patientNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientBirthdayDataGridViewTextBoxColumn
            // 
            this.patientBirthdayDataGridViewTextBoxColumn.DataPropertyName = "PatientBirthday";
            this.patientBirthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения пациента";
            this.patientBirthdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientBirthdayDataGridViewTextBoxColumn.Name = "patientBirthdayDataGridViewTextBoxColumn";
            this.patientBirthdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата встречи";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // DoctorEditButton
            // 
            this.DoctorEditButton.Location = new System.Drawing.Point(669, 92);
            this.DoctorEditButton.Name = "DoctorEditButton";
            this.DoctorEditButton.Size = new System.Drawing.Size(113, 57);
            this.DoctorEditButton.TabIndex = 34;
            this.DoctorEditButton.Text = "Редактировать запись";
            this.DoctorEditButton.UseVisualStyleBackColor = true;
            this.DoctorEditButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 459);
            this.Controls.Add(this.DoctorEditButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AppointmentAddButton);
            this.Controls.Add(this.DoctorAddButton);
            this.Controls.Add(this.dataGridView2);
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
        private DbStorage storage = DbStorage.GetInstance();
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
    }
}

