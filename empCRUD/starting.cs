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
    public partial class starting : Form
    {
        public starting()
        {
            InitializeComponent();
        }

        private void optionSelectLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.ShowDialog();
            this.Close();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            registration r = new registration();
            r.ShowDialog();
            this.Close();
        }
    }
}
