using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace DB
{
    interface IStorage
    {
        void Load(string filename);
        void Save(string filename);
    }
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }

    class DbStorage : IStorage
    {
        private static DbStorage instance;
        private static DataSet1 dataSet;
        private DbStorage() { }

        public static DbStorage GetInstance()
        {
            if (instance == null)
            {
                dataSet = new DataSet1();
                instance = new DbStorage();
            }
            return instance;
        }
        public void AddDoctor(string fullName, DateTime birthDay, int departmentID, int jobTitleID, int pasportSeries, int pasportNumber)
        {
            DataTable dataTable = dataSet.Tables["Doctors"];
            DataRow row = dataSet.Doctors.NewRow();

            row.ItemArray = new object[] { null, fullName, birthDay, departmentID, jobTitleID, pasportSeries, pasportNumber };
            dataTable.Rows.Add(row);
        }

        public void AddAppointment(int doctorFK, string patientName, DateTime patientBirthDay, DateTime date)
        {
            DataTable dataTable = dataSet.Tables["Appointments"];
            DataRow row = dataSet.Appointments.NewRow();

            row.ItemArray = new object[] { null, doctorFK, patientName, patientBirthDay, date };
            dataTable.Rows.Add(row);
        }

        public void EditDoctor ( 
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

        public void EditAppointment (
                                        int appoitmentID,
                                        int? doctorFK = null,
                                        string? patientName = null,
                                        DateTime? birthDay = null,
                                        DateTime? date = null
                                    )
        {
            DataRow row = dataSet.Appointments.Rows.Find(appoitmentID);
            row.ItemArray = new object[] { null, doctorFK, patientName, birthDay, date };
        }

        public void Load(string filepath)
        {
            dataSet.ReadXml(filepath);
        }

        public void Save(string filepath)
        {
            dataSet.WriteXml(filepath);
        }
    }
}
