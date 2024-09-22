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
            LoadData();
        }

        private void LoadData()
        {
            dataSet1.ReadXml("C:\\Users\\krivo\\source\\repos\\DB\\src\\DB\\Db.xml");
        }

        private void SaveData()
        {
            dataSet1.WriteXml("C:\\Users\\krivo\\source\\repos\\DB\\src\\DB\\Db.xml");
        }

        private void AddNewRow(int rowIndex)
        {
            
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
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
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            SaveData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorForm editForm = new DoctorForm(dataSet1);
            editForm.ShowDialog();
        }

        private void AppointmentAddButton_Click(object sender, EventArgs e)
        {
            AppointmentForm editForm = new AppointmentForm(dataSet1);
            editForm.ShowDialog();
        }
       
        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellEdited(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine(Convert.ToString(sender));
            MessageBox.Show(Convert.ToString(e));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                
            }
        }
    }
}
