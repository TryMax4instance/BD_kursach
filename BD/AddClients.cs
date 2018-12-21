using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class AddClients : Form
    {
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Архив\BD\BD\BK.mdf;Integrated Security = True";
        public AddClients()
        {
            InitializeComponent();
            FillCombo();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ChooseForm data = new ChooseForm();

            if (data.CheckDataTB() == true && data.CheckDataCB() == true)
            {
                OkButton.Enabled = true;

                string queryString = "INSERT INTO Clients (Registration_number, ID_Bet) " + "VALUES ('{0}', '{1}')";

                SqlConnection sqlConnection = new SqlConnection(connectString);

                sqlConnection.Open();

                string insertFormat = string.Format(queryString, RegBox.Text, IdComboBox.Text);

                SqlCommand command = new SqlCommand(insertFormat, sqlConnection);

                command.ExecuteNonQuery();

                sqlConnection.Close();

                Close();
            }
            OkButton.Enabled = false;
        }

        private void FillCombo()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT Bets.ID_Bet FROM Bets";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                IdComboBox.Items.Add(reader.GetInt32(0));
            }

            myConnection.Close();
        }
    }
}
