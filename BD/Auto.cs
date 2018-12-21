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
    public partial class Auto : Form
    {
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Архив\BD\BD\BK.mdf;Integrated Security = True";
        public Auto()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT * FROM Autorization Where login = '{0}'";

            var str = string.Format(query, LoginBox.Text);

            SqlCommand command = new SqlCommand(str, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string> data = new List<string>();

            while (reader.Read())
            {
                data.Add(reader[1].ToString());
                data.Add(reader[2].ToString());
            }

            reader.Close();
            myConnection.Close();

            ChooseForm d = new ChooseForm();

            if (d.CheckDataTB() == true)
            {
                EnterButton.Enabled = true;
                if (LoginBox.Text == data[0] && PassBox.Text.GetHashCode() == Convert.ToInt32(data[1]))
                {
                    if (LoginBox.Text != "admin")
                    {
                        d.User();
                        d.Show();
                    }
                    else
                    {
                        d.Admin();
                        d.Show();
                    }
                }
            }
        }
    }
}
