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
    public partial class InsertClients : Form
    {
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Архив\BD\BD\BK.mdf;Integrated Security = True";
        public InsertClients()
        {
            InitializeComponent();

            FillComboSearch();
            FillComboBets();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            var b = SearchComboBox.Text;

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = " SELECT * FROM Clients WHERE Registration_number = '{0}' ";

            var spull = string.Format(query, b);

            SqlCommand command = new SqlCommand(spull, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ChooseForm data = new ChooseForm();

            if (data.CheckDataTB() == true && data.CheckDataCB() == true)
            {
                string updateString = "UPDATE Clients SET Registration_number = '{0}', Id_Bet = '{1}' Where Id_Client = '{2}'";

                SqlConnection sqlConnection = new SqlConnection(connectString);
                sqlConnection.Open();

                string updateFormat = string.Format(updateString, RegBox.Text, IdComboBox.Text);

                SqlCommand command = new SqlCommand(updateFormat, sqlConnection);

                command.ExecuteNonQuery();

                sqlConnection.Close();

                RegBox.Text = null;
            }
        }
        private void FillComboSearch()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT Registration_number FROM Clients";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                SearchComboBox.Items.Add(reader.GetInt32(0));
            }

            myConnection.Close();
        }

        private void FillComboBets()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT Id_Bet FROM Bets";

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
