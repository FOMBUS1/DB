using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class DoctorForm : Form
    {
        private DataSet1 dataSet;
        private int? inx;
        public DoctorForm(DataSet1 _dataSet, int? index = null)
        {   
            dataSet = _dataSet;
            InitializeComponent();
            if (index != null)
            {
                inx = (int)index;
                object[] items = dataSet.Tables[0].Rows[(int)inx].ItemArray;
                DoctorNameInput.Text = (string) items[1];
                DoctorBirthdayInput.Text = Convert.ToString((DateTime)items[2]);
                DepartmentInput.Text = Convert.ToString((int)items[3]);
                JobTitleInput.Text = Convert.ToString((int)items[4]);
                SeriesInput.Text = Convert.ToString((int)items[5]);
                NumberInput.Text = Convert.ToString((int)items[6]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birthday = ParseDate(DoctorBirthdayInput.Text);

            int departmentID = Convert.ToInt32(DepartmentInput.Text);
            int jobTitleID = Convert.ToInt32(JobTitleInput.Text);
            int passportSeries = Convert.ToInt32(SeriesInput.Text);
            int passportNumber = Convert.ToInt32(NumberInput.Text);
            if (inx == null)
            {
                AddDoctor(DoctorNameInput.Text, birthday, departmentID, jobTitleID, passportSeries, passportNumber);
            }
            else
            {
                EditDoctor(DoctorNameInput.Text, birthday, departmentID, jobTitleID, passportSeries, passportNumber);
            }
            dataSet.WriteXml("C:\\Users\\krivo\\source\\repos\\DB\\src\\DB\\Db.xml");
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void AddDoctor(string fullName, DateTime birthDay, int departmentID, int jobTitleID, int pasportSeries, int pasportNumber)
        {
            DataTable dataTable = dataSet.Tables["Doctors"];
            DataRow row = dataSet.Doctors.NewRow();

            row.ItemArray = new object[] { null, fullName, birthDay, departmentID, jobTitleID, pasportSeries, pasportNumber };
            dataTable.Rows.Add(row);
        }

        private DateTime ParseDate(string in_date)
        {
            int day = Convert.ToInt32(in_date.Split('.')[0]);
            int month = Convert.ToInt32(in_date.Split('.')[1]);
            int year = Convert.ToInt32(in_date.Split('.')[2]);

            DateTime date = new DateTime(year, month, day);
            return date;
        }

        public void EditDoctor(
                                    string fullName,
                                    DateTime birthDay,
                                    int departmentID,
                                    int jobTitleID,
                                    int pasportSeries,
                                    int pasportNumber
                                )
        {
            DataRow row = dataSet.Tables[0].Rows[(int)inx];
            if (row != null ) 
            {
                row.ItemArray = new object[] { inx, fullName, birthDay, departmentID, jobTitleID, pasportSeries, pasportNumber };
            }
            else
            {
                MessageBox.Show("Что-то пошло не так!");
            }
        }
    }
}
