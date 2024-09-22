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
        public DoctorForm(DataSet1 _dataSet)
        {   
            dataSet = _dataSet;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birthday = ParseDate(DoctorBirthdayInput.Text);

            int departmentID = Convert.ToInt32(DepartmentInput.Text);
            int jobTitleID = Convert.ToInt32(JobTitleInput.Text);
            int passportSeries = Convert.ToInt32(SeriesInput.Text);
            int passportNumber = Convert.ToInt32(NumberInput.Text);
            AddDoctor(DoctorNameInput.Text, birthday, departmentID, jobTitleID, passportSeries, passportNumber);
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
        /*public void EditDoctor(
                                    int doctorID,
                                    string? fullName = null,
                                    DateTime? birthDay = null,
                                    int? departmentID = null,
                                    int? jobTitleID = null,
                                    int? pasportSeries = null,
                                    int? pasportNumber = null
                                )
        {
            DataRow row = dataSet.Doctors.Rows.Find(doctorID);

            row.ItemArray = new object[] { null, fullName, birthDay, departmentID, jobTitleID, pasportSeries, pasportNumber };

        }

        public void EditAppointment(
                                        int appoitmentID,
                                        int? doctorFK = null,
                                        string? patientName = null,
                                        DateTime? birthDay = null,
                                        DateTime? date = null
                                    )
        {
            DataRow row = dataSet.Appointments.Rows.Find(appoitmentID);
            row.ItemArray = new object[] { null, doctorFK, patientName, birthDay, date };
        }*/
    }
}
