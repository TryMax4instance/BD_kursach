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
    public partial class InsertBets : Form
    {
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Архив\BD\BD\BK.mdf;Integrated Security = True";
        public InsertBets()
        {
            InitializeComponent();
            FillComboBets();
            FillComboAgents();
            FillComboDev();
        }
        private void FillComboBets()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT ID_Bet FROM Bets";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                SearchComboBox.Items.Add(reader.GetInt32(0));
            }

            myConnection.Close();
        }
        private void FillComboAgents()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT ID_Agent FROM Agents";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                AgentComboBox.Items.Add(reader.GetInt32(0));
            }

            myConnection.Close();
        }
        private void FillComboDev()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT ID_Dev FROM Developments";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                DevComboBox.Items.Add(reader.GetInt32(0));
            }

            myConnection.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ChooseForm data = new ChooseForm();

            if (data.CheckDataTB() == true && data.CheckDataCB() == true)
            {
                string updateString = "UPDATE Bets SET DateTime_Bet = '{0}', Id_Dev = '{1}', Count_bet = '{2}', Rate = '{3}', Total = '{4}', Id_Agent = '{5}' WHERE ID_Bet = '{6}'";

                SqlConnection sqlConnection = new SqlConnection(connectString);
                sqlConnection.Open();

                string updateFormat = string.Format(updateString, DateTimePicker.Text, DevComboBox.Text, CountBox.Text, RateBox.Text, (Convert.ToInt32(CountBox.Text) * Convert.ToDouble(RateBox.Text)).ToString(), AgentComboBox.Text, SearchComboBox.Text);

                SqlCommand command = new SqlCommand(updateFormat, sqlConnection);

                command.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            var b = SearchComboBox.Text;

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT * FROM Bets WHERE ID_Bet = '{0}' ";

            var spull = string.Format(query, b);

            SqlCommand command = new SqlCommand(spull, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);

            DateTimePicker.Text = DevComboBox.Text = CountBox.Text = RateBox.Text = AgentComboBox.Text = null;
        }
    }

}
