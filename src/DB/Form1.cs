using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void InitializeDataGridView()
        {
            dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            this.Controls.Add(dataGridView1);

            // Добавляем колонки
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Имя";
            nameColumn.Name = "name";

            DataGridViewTextBoxColumn birthDateColumn = new DataGridViewTextBoxColumn();
            birthDateColumn.HeaderText = "Дата рождения";
            birthDateColumn.Name = "birthDate";

            DataGridViewTextBoxColumn departmentColumn = new DataGridViewTextBoxColumn();
            departmentColumn.HeaderText = "Отдел";
            departmentColumn.Name = "department";

            DataGridViewTextBoxColumn jobTitleColumn = new DataGridViewTextBoxColumn();
            jobTitleColumn.HeaderText = "Должность";
            jobTitleColumn.Name = "jobTitle";

            DataGridViewTextBoxColumn passportSeriesColumn = new DataGridViewTextBoxColumn();
            passportSeriesColumn.HeaderText = "Паспортная серия";
            passportSeriesColumn.Name = "passportSeries";

            DataGridViewTextBoxColumn passportNumberColumn = new DataGridViewTextBoxColumn();
            passportNumberColumn.HeaderText = "Номер паспорта";
            passportNumberColumn.Name = "passportNumber";

            // Добавляем кнопку сохранения в последнюю колонку
            DataGridViewButtonColumn saveButtonColumn = new DataGridViewButtonColumn();
            saveButtonColumn.HeaderText = "Сохранить";
            saveButtonColumn.Name = "saveButton";
            saveButtonColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(nameColumn);
            dataGridView1.Columns.Add(birthDateColumn);
            dataGridView1.Columns.Add(departmentColumn);
            dataGridView1.Columns.Add(jobTitleColumn);
            dataGridView1.Columns.Add(passportSeriesColumn);
            dataGridView1.Columns.Add(passportNumberColumn);
            dataGridView1.Columns.Add(saveButtonColumn);

            // Обрабатываем клик по кнопке сохранения
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private void InitializeTextBoxSearch()
        {
            textBoxSearch = new TextBox();
            textBoxSearch.Dock = DockStyle.Top;
            this.Controls.Add(textBoxSearch);
        }

        private void InitializeDbStorage()
        {
            storage = DbStorage.GetInstance();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dataTable = storage.dataSet.Tables["Doctors"];
            dataGridView1.DataSource = dataTable.DefaultView;
        }

        private void SaveData()
        {
            storage.Save("Db.xml");
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "saveButton")
            {
                AddNewRow(e.RowIndex);
            }
        }

        private void AddNewRow(int rowIndex)
        {
            DataRow row = storage.dataSet.Doctors.NewRow();

            row.ItemArray = new object[] { null, textBoxName.Text, DateTime.Parse(textBoxBirthDate.Text),
                                          int.Parse(textBoxDepartment.Text), int.Parse(textBoxJobTitle.Text),
                                          int.Parse(textBoxPassportSeries.Text), int.Parse(textBoxPassportNumber.Text) };

            storage.dataSet.Doctors.Rows.InsertAt(row, rowIndex + 1);
            LoadData();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = storage.dataSet.Doctors.DefaultView;
            dv.RowFilter = string.Format("Имя LIKE '%{0}%' OR Дата рождения LIKE '%{1}%'", textBoxSearch.Text, textBoxSearch.Text);
            dataGridView1.DataSource = dv;
        }

        private void InitializeButtons()
        {
            
        }

        private void InitializeTextBoxes()
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
