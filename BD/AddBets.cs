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
    public partial class AddBets : Form
    {
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Архив\BD\BD\BK.mdf;Integrated Security = True";
        public AddBets()
        {
            InitializeComponent();
            FillComboAgents();
            FillComboDev();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ChooseForm data = new ChooseForm();

            if (data.CheckDataTB() == true && data.CheckDataCB() == true)
            {
                OkButton.Enabled = true;

                string queryString = "INSERT INTO Bets (DateTime_Bet, Id_Dev, Count_bet, Rate, Total, Id_Agent) " +
        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')";

                SqlConnection sqlConnection = new SqlConnection(connectString);

                sqlConnection.Open();

                string insertFormat = string.Format(queryString, DateTimePicker.Text, DevComboBox.Text, CountBox.Text, RateBox.Text, (Convert.ToInt32(CountBox.Text) * Convert.ToDouble(RateBox.Text)).ToString(), AgentComboBox.Text);

                SqlCommand command = new SqlCommand(insertFormat, sqlConnection);

                command.ExecuteNonQuery();

                sqlConnection.Close();

                Close();
            }
            OkButton.Enabled = false;
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
    }
}
