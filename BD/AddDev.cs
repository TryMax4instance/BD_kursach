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
    public partial class AddDev : Form
    {
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Архив\BD\BD\BK.mdf;Integrated Security = True";
        public AddDev()
        {
            InitializeComponent();

            string[] a = { "Произошло", "Не произошло" };
            ResultComboBox.Items.AddRange(a);
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            ChooseForm data = new ChooseForm();           

            if (data.CheckDataTB() == true)
            {
                OkButton.Enabled = true;

                string queryString = "INSERT INTO Developments (Dev, DateDev, Result) " + "VALUES (N'{0}', '{1}', N'{2}')";

                SqlConnection sqlConnection = new SqlConnection(connectString);

                sqlConnection.Open();

                string insertFormat = string.Format(queryString, DevBox.Text, DateTimePicker.Text, ResultComboBox.Text);

                SqlCommand command = new SqlCommand(insertFormat, sqlConnection);

                command.ExecuteNonQuery();

                sqlConnection.Close();

                Close();
            }
            OkButton.Enabled = false;
        }
        
    }

}
