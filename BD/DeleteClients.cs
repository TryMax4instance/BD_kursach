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
    public partial class DeleteClients : Form
    {
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Архив\BD\BD\BK.mdf;Integrated Security = True";
        public DeleteClients()
        {
            InitializeComponent();
            FillCombo();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ChooseForm data = new ChooseForm();

            if (data.CheckDataCB() == true)
            {
                string queryString = "DELETE FROM Clients WHERE Registration_number = '{0}'";
                SqlConnection sqlConnection = new SqlConnection(connectString);

                sqlConnection.Open();

                string deleteFormat = string.Format(queryString, IdComboBox.Text);

                SqlCommand sqlCommand = new SqlCommand(deleteFormat, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                Close();
            }
        }
        private void FillCombo()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT ID_Client FROM Clients";

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
