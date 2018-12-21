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
    public partial class DeleteBets : Form
    {
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Архив\BD\BD\BK.mdf;Integrated Security = True";
        public DeleteBets()
        {
            InitializeComponent();
            FillCombo();
        }

        private void FillCombo()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT ID_Bet FROM Bets";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                IdComboBox.Items.Add(reader.GetInt32(0));
            }

            myConnection.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ChooseForm data = new ChooseForm();

            if (data.CheckDataCB() == true)
            {
                string queryString = "DELETE FROM Bets WHERE ID_Bet = '{0}'";
                SqlConnection sqlConnection = new SqlConnection(connectString);

                sqlConnection.Open();

                string deleteFormat = string.Format(queryString, IdComboBox.Text);

                SqlCommand sqlCommand = new SqlCommand(deleteFormat, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                Close();
            }
        }
    }
}
