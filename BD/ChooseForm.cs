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
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {

        }
        public void Admin()
        {
            InitializeComponent();
        }
        public void User()
        {
            InitializeComponent();
            AgentButton.Visible = false;
        }
        public bool CheckDataTB()
        {
            foreach (TextBox tb in Controls.OfType<TextBox>())
                if (string.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show("Заполните все строки!!");
                    return false;
                }
            return true;
        }

        public bool CheckDataCB()
        {
            foreach (ComboBox tb in Controls.OfType<ComboBox>())
                if (string.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show("Заполните все строки!!");
                    return false;
                }
            return true;
        }
        private void AgentButton_Click(object sender, EventArgs e)
        {
            ShowAgents exm = new ShowAgents();
            exm.Show();
        }

        private void BetsButton_Click(object sender, EventArgs e)
        {
            ShowBets exm = new ShowBets();
            exm.Show();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            ShowClients exm = new ShowClients();
            exm.Show();
        }

        private void DevButton_Click(object sender, EventArgs e)
        {
            ShowDev exm = new ShowDev();
            exm.Show();
        }

        private void DocButton_Click(object sender, EventArgs e)
        {
            ManyDocs exm = new ManyDocs();
            exm.Show();
        }
    }
}
