using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class ManyDocs : Form
    {
        public ManyDocs()
        {
            InitializeComponent();
        }

        private void ClientBankbutton_Click(object sender, EventArgs e)
        {
            ClientBank exm = new ClientBank();
            exm.Show();
        }

        private void BankRollbutton_Click(object sender, EventArgs e)
        {
            BankRoll exm = new BankRoll();
            exm.Show();
        }

        private void ClientOrderbutton_Click(object sender, EventArgs e)
        {
            ClientOrder exm = new ClientOrder();
            exm.Show();
        }
    }
}
