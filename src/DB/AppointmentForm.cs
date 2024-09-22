using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class AppointmentForm : Form
    {
        DataSet1 dataSet;
        private int? inx;
        public AppointmentForm(DataSet1 dataSet, int? index = null)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            if (index != null)
            {
                inx = (int)index;
                object[] items = dataSet.Tables[1].Rows[(int)inx].ItemArray;
                DoctorFKInput.Text = Convert.ToString((int)items[1]);
                patientNameInput.Text = (string)items[2];
                patientBirthdayInput.Text = Convert.ToString((DateTime)items[3]);
                dateInput.Text = Convert.ToString((DateTime)items[4]);
            }
        }

        private void DoctorName_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            DateTime date = ParseDate(dateInput.Text);
            DateTime patientBirthday = ParseDate(patientBirthdayInput.Text);

            int doctorFK = Convert.ToInt32(DoctorFKInput.Text);
            string patientName = patientNameInput.Text;

            if (inx == null)
            {
                AddAppointment(doctorFK, patientName, patientBirthday, date);
            }
            else
            {
                EditAppointment(doctorFK, patientName, patientBirthday, date);
            }
            dataSet.WriteXml("C:\\Users\\krivo\\source\\repos\\DB\\src\\DB\\Db.xml");
            this.Close();
        }
        public void AddAppointment(int doctorFK, string patientName, DateTime patientBirthDay, DateTime date)
        {
            DataTable dataTable = dataSet.Tables["Appointments"];
            DataRow row = dataSet.Appointments.NewRow();

            row.ItemArray = new object[] { null, doctorFK, patientName, patientBirthDay, date };
            dataTable.Rows.Add(row);
        }

        
        public void EditAppointment(
                                        int doctorFK,
                                        string patientName,
                                        DateTime birthDay,
                                        DateTime date
                                    )
        {
            DataRow row = dataSet.Tables[1].Rows[(int)inx];
            if (row != null)
            {
                row.ItemArray = new object[] { null, doctorFK, patientName, birthDay, date };
            }
            else
            {
                MessageBox.Show("Что-то пошло не так!");
            }
        }

        private DateTime ParseDate(string in_date)
        {
            int day = Convert.ToInt32(in_date.Split('.')[0]);
            int month = Convert.ToInt32(in_date.Split('.')[1]);
            int year = Convert.ToInt32(in_date.Split('.')[2]);

            DateTime date = new DateTime(year, month, day);
            return date;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
