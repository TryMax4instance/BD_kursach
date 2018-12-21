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
    public partial class ShowClients : Form
    {
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Архив\BD\BD\BK.mdf;Integrated Security = True";
        public ShowClients()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT Clients.Id_Client, Clients.Registration_number, Bets.ID_Bet FROM Clients " + "INNER JOIN Bets ON Clients.ID_Bet = Bets.ID_Bet ORDER BY Id_Client";

            SqlCommand command = new SqlCommand(query, myConnection);

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

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void UpdButton_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            AddClients exm = new AddClients();
            exm.Show();
        }

        private void InsertButton_Click_1(object sender, EventArgs e)
        {
            InsertClients exm = new InsertClients();
            exm.Show();
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            DeleteClients exm = new DeleteClients();
            exm.Show();
        }

        private void ShowClients_Load_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(AddButton, "Добавление новой записи о клиенте букмекерской конторы");
            t.SetToolTip(DeleteButton, "Удаление существующей записи о клиенте букмекерской конторы");
            t.SetToolTip(InsertButton, "Изменение существующей записи о клиенте букмекерской конторы");
        }
    }
}
