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
    public partial class ClientOrder : Form
    {
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Архив\BD\BD\BK.mdf;Integrated Security = True";
        public ClientOrder()
        {
            InitializeComponent();
            FillCombo();
        }
        private void FillCombo()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT Id_Client FROM Clients";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                ClientCombo.Items.Add(reader.GetInt32(0));
            }

            myConnection.Close();
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            ChooseForm d = new ChooseForm();

            if (d.CheckDataCB() == true)
            {
                string String = "SELECT Registration_number FROM Clients where Id_Client = '{0}'";

                SqlConnection sqlConnection = new SqlConnection(connectString);
                sqlConnection.Open();

                string Format = string.Format(String, ClientCombo.Text);

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
                doc.CreateClientOrderDocument(Convert.ToInt32(data[data.Count - 1][0]));
            }
        }
    }
}
