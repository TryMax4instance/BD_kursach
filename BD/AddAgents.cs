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
    public partial class AddAgents : Form
    {
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Архив\BD\BD\BK.mdf;Integrated Security = True";

        public AddAgents()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ChooseForm data = new ChooseForm();

            if (data.CheckDataTB() == true)
            {
                OkButton.Enabled = true;

                string queryString = "INSERT INTO Agents (Surname, Name, Patronymic, Street, HouseNumb, FlatNumb, Number, PassData) " +
        "VALUES (N'{0}', N'{1}', N'{2}', N'{3}', '{4}', '{5}', '{6}', '{7}')";

                SqlConnection sqlConnection = new SqlConnection(connectString);

                sqlConnection.Open();

                string insertFormat = string.Format(queryString, SurnameBox.Text, NameBox.Text, PatronymicBox.Text, StreetBox.Text, HouseBox.Text, FlatBox.Text, NumberBox.Text, PassBox.Text);

                SqlCommand command = new SqlCommand(insertFormat, sqlConnection);

                command.ExecuteNonQuery();

                sqlConnection.Close();

                Close();
            }
            OkButton.Enabled = false;
        }
    }
}