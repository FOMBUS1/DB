using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    
    static class DataStorage
    {   

        public static DataSet1 CreateDataset(string path = "DB.xml")
        {
            DataSet1 ds = new DataSet1();
            ds.ReadXml(path);

            return ds;
        }

        public static void CreateAppointment(DataTable appointments, int doctorId, string patientName)
        {
            DataRow row = appointments.NewRow();
            row.ItemArray = new object[] { null, doctorId, patientName };
            appointments.Rows.Add(row);
        }

        public static void CreateDoctor(DataTable doctors, string Fullname, DateTime birthday, int departmentId, int jobTitleId, int passportSeries, int passportNumber)
        {
            DataRow row = doctors.NewRow();
            row.ItemArray = new object[] { null, Fullname, birthday, departmentId, jobTitleId, passportSeries, passportNumber };
            doctors.Rows.Add(row);
        }


    }
    
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
