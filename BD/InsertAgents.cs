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
    public partial class InsertAgents : Form
    {
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Архив\BD\BD\BK.mdf;Integrated Security = True";
        public InsertAgents()
        {
            InitializeComponent();

            FillCombo();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ChooseForm data = new ChooseForm();

            if (data.CheckDataTB() == true && data.CheckDataCB() == true)
            {
                string updateString = "UPDATE Agents SET Surname = N'{0}', Name = N'{1}', Patronymic = N'{2}', Street = N'{3}', HouseNumb = '{4}', FlatNumb = '{5}', Number = '{6}', PassData = '{7}' WHERE ID_Agent = '{8}'";

                SqlConnection sqlConnection = new SqlConnection(connectString);
                sqlConnection.Open();

                string updateFormat = string.Format(updateString, SurnameBox.Text, NameBox.Text, PatronymicBox.Text, StreetBox.Text, HouseBox.Text, FlatBox.Text, NumberBox.Text, PassBox.Text, SearchComboBox.Text);

                SqlCommand command = new SqlCommand(updateFormat, sqlConnection);

                command.ExecuteNonQuery();

                sqlConnection.Close();

            }
        }

        private void FillCombo()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT ID_Agent FROM Agents";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                SearchComboBox.Items.Add(reader.GetInt32(0));
            }

            myConnection.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            var b = SearchComboBox.Text;

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT * FROM Agents WHERE ID_Agent = '{0}' ";

            var spull = string.Format(query, b);

            SqlCommand command = new SqlCommand(spull, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[9]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
    }
}
