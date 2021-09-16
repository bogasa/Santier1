using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Telerik.WinControls.UI;

namespace Santier1
{
    public partial class PlatiControl : UserControl
    {
        private SQLiteConnection sqlConn;
        private SQLiteDataAdapter dbDataAdapter;
        private DataTable dtPlati;

        public PlatiControl()
        {
            sqlConn = new SQLiteConnection(Properties.Settings.Default.Database);
            dbDataAdapter = new SQLiteDataAdapter(
                "SELECT t.Timesheetid, t.EmployeeId, e.FirstName || e.LastName AS Employee FROM employees e  LEFT JOIN timesheets t on t.EmployeeId = e.EmployeeId", sqlConn);
            dtPlati = new DataTable();

            InitializeComponent();

            radDateTimePickerPlati.Format = DateTimePickerFormat.Custom;
            radDateTimePickerPlati.CustomFormat = "MMMM yyyy";


            radDateTimePickerPlati.DateTimePickerElement.Calendar.HeaderNavigationMode = HeaderNavigationMode.Zoom;
            radDateTimePickerPlati.DateTimePickerElement.Calendar.ZoomLevel = ZoomLevel.Months;
            radDateTimePickerPlati.DateTimePickerElement.Calendar.ZoomChanging += Calendar_ZoomChanging;

            radDateTimePickerPlati.DateTimePickerElement.Calendar.SelectionChanged += Calendar_SelectionChanged;

            var calendar = radDateTimePickerPlati.DateTimePickerElement.Calendar;
            var dateSelected = calendar.FocusedDate;
            var month = dateSelected.Month;
            var year = dateSelected.Year;

            for (int i = 1; i <= calendar.CurrentCalendar.GetDaysInMonth(year, month); i++)
            {
                gridPlati.Columns.Add(String.Format("{0}/{1}/{2}", i.ToString(), month.ToString(), year.ToString()));
            }
        }

        private void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            var calendar = radDateTimePickerPlati.DateTimePickerElement.Calendar;
            var dateSelected = calendar.SelectedDate;
            var month = dateSelected.Month;
            var year = dateSelected.Year;

            int colCnt = gridPlati.Columns.Count;
            if (colCnt > 2)
            {
                for (int i = colCnt - 1; i > 1; i--)
                {
                    gridPlati.Columns.RemoveAt(i);
                }
            }
            for (int i = 1; i <= calendar.CurrentCalendar.GetDaysInMonth(year, month); i++)
            {
                gridPlati.Columns.Add(String.Format("{0}/{1}/{2}", i.ToString(), month.ToString(), year.ToString()));
            }
        }

        private void Calendar_ZoomChanging(object sender, CalendarZoomChangingEventArgs e)
        {
            e.Cancel = true;
        }

        private void PlatiControl_Load(object sender, EventArgs e)
        {
            ConfigureBindings();
        }

        private void ConfigureBindings()
        {
            //Columns were added from the Designer, do not allow grid
            //to automatically add columns for each column in the bound Table
            gridPlati.AutoGenerateColumns = true;

            //Give the adapter its commands so it knows how to perform the inserts,
            //updates and deletes as the user makes data changes in the grid.
            dbDataAdapter.InsertCommand = GetInsertCommand();
            dbDataAdapter.UpdateCommand = GetUpdateCommand();
            dbDataAdapter.DeleteCommand = GetDeleteCommand();

            //Get all the fruit data from the database and bind it to the grid
            dbDataAdapter.Fill(dtPlati);
            gridPlati.DataSource = dtPlati;

            //var dateSelected = radDateTimePicker1.DateTimePickerElement.Calendar.SelectedDate;
            //var month = dateSelected.Month;
            //var year = dateSelected.Year;

            //for (int i = 1; i <= 31; i++)
            //{
            //    gridPontaj.Columns.Add(String.Format("{0}/{1}/{2}", i.ToString(), month.ToString(), year.ToString()));
            //}
        }
        private SQLiteCommand GetInsertCommand()
        {
            string qry = String.Empty;
            SQLiteCommand insertCmd = new SQLiteCommand(qry, sqlConn);


            return insertCmd;
        }

        private SQLiteCommand GetUpdateCommand()
        {
            string qry = String.Empty;
            SQLiteCommand updateCmd = new SQLiteCommand(qry, sqlConn);


            return updateCmd;
        }

        private SQLiteCommand GetDeleteCommand()
        {
            string qry = String.Empty;
            SQLiteCommand deleteCmd = new SQLiteCommand(qry, sqlConn);


            return deleteCmd;
        }
    }
}
