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
    public partial class ShowDev : Form
    {
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Архив\BD\BD\BK.mdf;Integrated Security = True";
        public ShowDev()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT * FROM Developments ORDER BY ID_Dev";

            SqlCommand command = new SqlCommand(query, myConnection);

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
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddDev exm = new AddDev();
            exm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteDev exm = new DeleteDev();
            exm.Show();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            InsertDev exm = new InsertDev();
            exm.Show();
        }

        private void UpdButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
        }

        private void ShowDev_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(AddButton, "Добавление новой записи о событии букмекерской конторы");
            t.SetToolTip(DeleteButton, "Удаление существующей записи о событии букмекерской конторы");
            t.SetToolTip(InsertButton, "Изменение существующей записи о событии букмекерской конторы");
        }
    }
}
