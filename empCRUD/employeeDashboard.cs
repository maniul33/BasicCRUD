using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empCRUD
{
    public partial class employeeDashboard : Form
    {
        private string name;
        public employeeDashboard(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void employeeDashboard_Load(object sender, EventArgs e)
        {
            empLabel.Text = "Logged in as "+ name.ToUpperInvariant();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.ShowDialog();
            this.Close();
        }

        private void welcomeText_Click(object sender, EventArgs e)
        {

        }
    }
}
