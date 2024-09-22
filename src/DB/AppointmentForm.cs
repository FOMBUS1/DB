using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class AppointmentForm : Form
    {
        DataSet1 dataSet;
        public AppointmentForm(DataSet1 dataSet)
        {
            InitializeComponent();
            this.dataSet = dataSet;
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

            AddAppointment(doctorFK, patientName, patientBirthday, date);
            dataSet.WriteXml("C:\\Users\\krivo\\source\\repos\\DB\\src\\DB\\Db.xml");
        }
        public void AddAppointment(int doctorFK, string patientName, DateTime patientBirthDay, DateTime date)
        {
            DataTable dataTable = dataSet.Tables["Appointments"];
            DataRow row = dataSet.Appointments.NewRow();

            row.ItemArray = new object[] { null, doctorFK, patientName, patientBirthDay, date };
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
    }
}
