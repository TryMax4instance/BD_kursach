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
    public partial class ClientBank : Form
    {
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Архив\BD\BD\BK.mdf;Integrated Security = True";
        public ClientBank()
        {
            InitializeComponent();
            FillComboD();
            FillComboR();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            ChooseForm d = new ChooseForm();

            if (d.CheckDataCB() == true)
            {
                string String = "Select clients.Registration_number, Developments.ID_Dev, Bets.Total FROM Clients " + "join bets on Bets.ID_Bet = Clients.ID_Bet " + "join Developments on Developments.ID_Dev = bets.ID_Dev where Developments.Result = 'Yes'";

                SqlConnection sqlConnection = new SqlConnection(connectString);
                sqlConnection.Open();

                string Format = string.Format(String, IdReg.Text, IdDev.Text);

                SqlCommand command = new SqlCommand(Format, sqlConnection);

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

                sqlConnection.Close();

                Doc doc = new Doc();
                doc.CreateBankDocument(Convert.ToInt32(IdReg.Text), Convert.ToInt32(IdDev.Text), Convert.ToDouble(data[data.Count - 1][2]));
            }            
        }

        private void FillComboD()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT ID_Dev FROM Developments";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                IdDev.Items.Add(reader.GetInt32(0));
            }

            myConnection.Close();
        }
        private void FillComboR()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT Registration_number FROM Clients";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                IdReg.Items.Add(reader.GetInt32(0));
            }

            myConnection.Close();
        }
    }
}
