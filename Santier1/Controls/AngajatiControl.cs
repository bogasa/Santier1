using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Santier1
{
    public partial class AngajatiControl : UserControl
    {
        private SqlConnection connection;
        private SqlDataAdapter dbDataAdapter;
        private DataTable dtAngajat;
        private DataSet dsAngajat;

        public AngajatiControl()
        {          
            string connectionString = ConfigurationManager.ConnectionStrings["SQLEXPRESSConnection"].ConnectionString;
            connection = new SqlConnection(connectionString);

            string sql = String.Empty;
            // write the sql statement to execute
            if (!String.IsNullOrWhiteSpace(connection.ToString()))
            {
                sql = "SELECT EmployeeId, FirstName, LastName, Title, HireDate, Address, City FROM employees";
                dbDataAdapter = new SqlDataAdapter();
                dsAngajat = new DataSet();
                dtAngajat = new DataTable();
                dbDataAdapter.SelectCommand = new SqlCommand(sql, connection);
            
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

            connection.Open();
            //Get all the fruit data from the database and bind it to the grid
            dbDataAdapter.Fill(dsAngajat);
            gridAngajati.DataSource = dsAngajat.Tables[0];
            //dbDataAdapter.Dispose();
            connection.Close();
        }
        private SqlCommand GetInsertCommand()
        {
            string qry = @"INSERT INTO employees
                (FirstName, LastName, Title, HireDate, Address, City)
                VALUES(@FirstName, @LastName, @Title, @HireDate, @Address, @City)";

            SqlCommand insertCmd = new SqlCommand(qry, connection);

            var parNumeAngajat = new SqlParameter("@FirstName", "FirstName");
            var parPrenumeAngajat = new SqlParameter("@LastName", "LastName");
            var parFunctieAngajat = new SqlParameter("@Title", "Title");
            var parDataAngajariiAngajat = new SqlParameter("@HireDate", "HireDate");
            var parAdresaAngajat = new SqlParameter("@Address", "Address");
            var parOrasAngajat = new SqlParameter("@City", "City");

            insertCmd.Parameters.AddRange(new SqlParameter[]
            {
                parNumeAngajat, parPrenumeAngajat, parFunctieAngajat, parDataAngajariiAngajat, parAdresaAngajat, parOrasAngajat
            });

            return insertCmd;
        }

        private SqlCommand GetUpdateCommand()
        {
            string qry = @"UPDATE employees
                SET FirstName = @FirstName,
                    LastName = @LastName,
                    Title = @Title,
                    HireDate = @HireDate,
                    Address = @Address,
                    City = @City
                WHERE EmployeeId = @EmployeeId";

            SqlCommand updateCmd = new SqlCommand(qry, connection);

            var parIdAngajat = new SqlParameter("@EmployeeId", "EmployeeId");
            var parNumeAngajat = new SqlParameter("@FirstName", "FirstName");
            var parPrenumeAngajat = new SqlParameter("@LastName", "LastName");
            var parFunctieAngajat = new SqlParameter("@Title", "Title");
            var parDataAngajariiAngajat = new SqlParameter("@HireDate", "HireDate");
            var parAdresaAngajat = new SqlParameter("@Address", "Address");
            var parOrasAngajat = new SqlParameter("@City", "City");

            updateCmd.Parameters.AddRange(new SqlParameter[]
            {
                parIdAngajat, parNumeAngajat, parPrenumeAngajat, parFunctieAngajat, parDataAngajariiAngajat, parAdresaAngajat, parOrasAngajat
            });

            return updateCmd;
        }

        private SqlCommand GetDeleteCommand()
        {
            string qry = @"DELETE FROM employees WHERE EmployeeId = @EmployeeId";

            SqlCommand deleteCmd = new SqlCommand(qry, connection);

            var parIdAngajat = new SqlParameter("@EmployeeId", "EmployeeId");

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
                MessageBox.Show(ex.Message);
            }
        }
    }
}
