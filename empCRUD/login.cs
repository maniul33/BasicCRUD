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

namespace empCRUD
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = true;
            passwordBox.PasswordChar = '*';
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            starting s = new starting();
            s.ShowDialog();
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdBox.Text) || string.IsNullOrEmpty(passwordBox.Text))
            {
                MessageBox.Show("Please fill all the informations.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if(IdBox.Text == "admin" && passwordBox.Text == "admin")
            {
                this.Hide();
                adminDashboard ad = new adminDashboard();
                ad.ShowDialog();
                this.Close();
            }

            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=MANIUL\\SQLEXPRESS;Initial Catalog=LAB;Integrated Security=True");

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM EMPLOYEES WHERE EmployeeID = @EmployeeID", conn);
                    cmd.Parameters.AddWithValue("@EmployeeID", int.Parse(IdBox.Text));

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string password = reader["EmployeePassword"].ToString();
                        if (password == passwordBox.Text)
                        {
                            string name = reader["EmployeeName"].ToString();
                            MessageBox.Show("Login Successful.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            employeeDashboard emp = new employeeDashboard(name);
                            emp.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            passwordBox.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid information.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        IdBox.Clear();
                        passwordBox.Clear();
                    }

                    reader.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
