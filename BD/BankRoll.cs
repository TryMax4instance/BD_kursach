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
    public partial class BankRoll : Form
    {
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Архив\BD\BD\BK.mdf;Integrated Security = True";
        public BankRoll()
        {
            InitializeComponent();
        }

        private void BankRollButton_Click(object sender, EventArgs e)
        {
            ChooseForm d = new ChooseForm();

            if (d.CheckDataCB() == true)
            {
                string String = "SELECT sum (bets.Count_bet) FROM Bets " + "join Developments on Developments.id_dev = Bets.id_dev where Developments.result = 'No'";

                SqlConnection sqlConnection = new SqlConnection(connectString);
                sqlConnection.Open();

                string Format = string.Format(String);

                SqlCommand command = new SqlCommand(Format, sqlConnection);

                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[1]);

                    data[data.Count - 1][0] = reader[0].ToString();
                }

                reader.Close();

                sqlConnection.Close();

                Doc doc = new Doc();
                doc.CreateBankRollDocument(Convert.ToDouble(data[data.Count - 1][0]));
            }
        }
    }
}
