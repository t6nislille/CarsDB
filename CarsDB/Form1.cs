using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CarsDB.Properties.Settings.CarConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCarsInGarageTable();
        }

        private void PopulateCarsInGarageTable()
        {
            using (connection = new SqlConnection(connectionString))    
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CarMark", connection))
            {
                DataTable caringarageTable = new DataTable();
                adapter.Fill(caringarageTable);

                listCarsInGarage.DisplayMember = "CarMarkName";
                listCarsInGarage.ValueMember = "Id";
                listCarsInGarage.DataSource = caringarageTable;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listCarsInGarage_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateCarNames();
        }

        private void PopulateCarNames()
        {
            string query = "SELECT CarInGarage.CarModleName FROM CarMark INNER JOIN CarInGarage ON CarInGarage.MarkId = CarMark.Id WHERE CarMark.Id = @MarkId";
            using(connection = new SqlConnection(connectionString))
            using(SqlCommand command = new SqlCommand(query, connection)) 
            using(SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@MarkId", listCarsInGarage.SelectedValue);
                DataTable carNameTable = new DataTable();
                adapter.Fill(carNameTable);

                listCarNames.DisplayMember = "CarModleName";
                listCarNames.ValueMember = "Id";
                listCarNames.DataSource = carNameTable;
            }
                
        }
    }
}
