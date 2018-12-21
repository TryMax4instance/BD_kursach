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
    public partial class ShowBets : Form
    {
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Архив\BD\BD\BK.mdf;Integrated Security = True";
        public ShowBets()
        {
            InitializeComponent();

            LoadData();
        }
        private void LoadData()
        {
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var query = "SELECT Bets.ID_Bet, Bets.DateTime_Bet, Developments.ID_Dev, Bets.Count_bet, bets.Rate, Bets.Total, Agents.ID_Agent FROM Bets " +
            "INNER JOIN Developments on Developments.ID_Dev = Bets.ID_Dev " + "INNER JOIN Agents on Agents.ID_Agent = Bets.ID_Agent ORDER BY ID_Bet";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            InsertBets exm = new InsertBets();
            exm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
           DeleteBets exm = new DeleteBets();
            exm.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddBets exm = new AddBets();
            exm.Show();
        }

        private void UpdButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
        }

        private void ShowBets_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(AddButton, "Добавление новой записи о ставке букмекерской конторы");
            t.SetToolTip(DeleteButton, "Удаление существующей записи о ставке букмекерской конторы");
            t.SetToolTip(InsertButton, "Изменение существующей записи  о ставке букмекерской конторы");
        }
    }
}
