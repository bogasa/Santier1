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
using System.Data.SqlClient;
using System.Configuration;

namespace Santier1
{
    public partial class AngajatiControl : UserControl
    {
        private SQLiteConnection sqlConn;
        private SQLiteDataAdapter dbDataAdapter;
        private DataTable dtAngajat;
        

        public AngajatiControl()
        {
            //sqlConn = new SQLiteConnection(Properties.Settings.Default.Database);
            //dbDataAdapter = new SQLiteDataAdapter(
            //    "SELECT EmployeeId, FirstName, LastName, Title, HireDate, Address, City FROM employees", sqlConn);
            //dtAngajat = new DataTable();

            dtAngajat = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["SQLEXPRESSConnection"].ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = String.Empty;
                // write the sql statement to execute
                if (!String.IsNullOrWhiteSpace(conn.ToString()))
                {
                    sql = "SELECT EmployeeId, FirstName, LastName, Title, HireDate, Address, City FROM employees";
                }
            }

            InitializeComponent();
        }

        private void AngajatiControl_Load(object sender, EventArgs e)
        {
            ConfigureBindings();
        }

        private void ConfigureBindings()
        {
            //Columns were added from the Designer, do not allow grid
            //to automatically add columns for each column in the bound Table
            gridAngajati.AutoGenerateColumns = false;

            //Give the adapter its commands so it knows how to perform the inserts,
            //updates and deletes as the user makes data changes in the grid.
            dbDataAdapter.InsertCommand = GetInsertCommand();
            dbDataAdapter.UpdateCommand = GetUpdateCommand();
            dbDataAdapter.DeleteCommand = GetDeleteCommand();

            //Get all the fruit data from the database and bind it to the grid
            dbDataAdapter.Fill(dtAngajat);
            gridAngajati.DataSource = dtAngajat;
        }
        private SQLiteCommand GetInsertCommand()
        {
            string qry = @"INSERT INTO employees
                (FirstName, LastName, Title, HireDate, Address, City)
                VALUES(@FirstName, @LastName, @Title, @HireDate, @Address, @City)";

            SQLiteCommand insertCmd = new SQLiteCommand(qry, sqlConn);

            var parNumeAngajat = new SQLiteParameter("@FirstName", DbType.String, "FirstName");
            var parPrenumeAngajat = new SQLiteParameter("@LastName", DbType.String, "LastName");
            var parFunctieAngajat = new SQLiteParameter("@Title", DbType.String, "Title");
            var parDataAngajariiAngajat = new SQLiteParameter("@HireDate", DbType.String, "HireDate");
            var parAdresaAngajat = new SQLiteParameter("@Address", DbType.String, "Address");
            var parOrasAngajat = new SQLiteParameter("@City", DbType.String, "City");

            insertCmd.Parameters.AddRange(new SQLiteParameter[]
            {
                parNumeAngajat, parPrenumeAngajat, parFunctieAngajat, parDataAngajariiAngajat, parAdresaAngajat, parOrasAngajat
            });

            return insertCmd;
        }

        private SQLiteCommand GetUpdateCommand()
        {
            string qry = @"UPDATE employees
                SET FirstName = @FirstName,
                    LastName = @LastName,
                    Title = @Title,
                    HireDate = @HireDate,
                    Address = @Address,
                    City = @City
                WHERE EmployeeId = @EmployeeId";

            SQLiteCommand updateCmd = new SQLiteCommand(qry, sqlConn);

            var parIdAngajat = new SQLiteParameter("@EmployeeId", DbType.Int32, "EmployeeId");
            var parNumeAngajat = new SQLiteParameter("@FirstName", DbType.String, "FirstName");
            var parPrenumeAngajat = new SQLiteParameter("@LastName", DbType.String, "LastName");
            var parFunctieAngajat = new SQLiteParameter("@Title", DbType.String, "Title");
            var parDataAngajariiAngajat = new SQLiteParameter("@HireDate", DbType.String, "HireDate");
            var parAdresaAngajat = new SQLiteParameter("@Address", DbType.String, "Address");
            var parOrasAngajat = new SQLiteParameter("@City", DbType.String, "City");

            updateCmd.Parameters.AddRange(new SQLiteParameter[]
            {
                parIdAngajat, parNumeAngajat, parPrenumeAngajat, parFunctieAngajat, parDataAngajariiAngajat, parAdresaAngajat, parOrasAngajat
            });

            return updateCmd;
        }

        private SQLiteCommand GetDeleteCommand()
        {
            string qry = @"DELETE FROM employees WHERE EmployeeId = @EmployeeId";

            SQLiteCommand deleteCmd = new SQLiteCommand(qry, sqlConn);

            var parIdAngajat = new SQLiteParameter("@EmployeeId", DbType.Int32, "EmployeeId");

            deleteCmd.Parameters.Add(parIdAngajat);

            return deleteCmd;
        }

        private void btnAngajati_Click(object sender, EventArgs e)
        {
            try {
                dbDataAdapter.Update(dtAngajat);
                dtAngajat.AcceptChanges();
                dtAngajat.Clear();
                dbDataAdapter.Fill(dtAngajat);
            }
            catch (SqlException ex)
            {
                
            }
        }
    }
}
