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
    public partial class InsertDev : Form
    {
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Архив\BD\BD\BK.mdf;Integrated Security = True";
        public InsertDev()
        {
            InitializeComponent();

            FillCombo();
        }
        private void FillCombo()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT ID_Dev FROM Developments";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                SearchComboBox.Items.Add(reader.GetInt32(0));
            }

            myConnection.Close();

            string[] a = {"Произошло", "Не произошло"};
            ResultComboBox.Items.AddRange(a);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ChooseForm data = new ChooseForm();

            if (data.CheckDataTB() == true && data.CheckDataCB() == true)
            {
                string updateString = "UPDATE Developments SET Dev = N'{0}', DateDev = '{1}', Result = N'{2}' Where Id_Dev = '{3}'";
                SqlConnection sqlConnection = new SqlConnection(connectString);
                sqlConnection.Open();

                string updateFormat = string.Format(updateString, DevBox.Text, DateTimePicker.Text, ResultComboBox.Text, SearchComboBox.Text);

                SqlCommand command = new SqlCommand(updateFormat, sqlConnection);

                command.ExecuteNonQuery();

                sqlConnection.Close();

                SearchComboBox.Text = DevBox.Text = DateTimePicker.Text = ResultComboBox.Text = null;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            var b = SearchComboBox.Text;

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = " SELECT * FROM Developments WHERE Id_Dev = '{0}' ";

            var spull = string.Format(query, b);

            SqlCommand command = new SqlCommand(spull, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
    }
}
