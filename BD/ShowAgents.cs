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
    public partial class ShowAgents : Form
    {
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Архив\BD\BD\BK.mdf;Integrated Security = True";

        public ShowAgents()
        {
            InitializeComponent();

            LoadData();            
        }

        private void LoadData()
        {   
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT * FROM Agents ORDER BY ID_Agent";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[9]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();

            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddAgents exm = new AddAgents();
            exm.Show();
        }

        private void ShowAgents_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(AddButton, "Добавление новой записи об агенте букмекерской конторы");
            t.SetToolTip(DeleteButton, "Удаление существующей записи об агенте букмекерской конторы");
            t.SetToolTip(InsertButton, "Изменение существующей записи об агенте букмекерской конторы");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteAgents exm = new DeleteAgents();
            exm.Show();            
        }

        private void UpdButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            InsertAgents exm = new InsertAgents();
            exm.Show();
        }
    }
}
