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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void clearFields()
        {
            nameBox.Clear();
            salaryBox.Clear();
            cityBox.Clear();
            idBox.Clear();
            passwordBox.Clear();
        }

        private bool isEmpty()
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(idBox.Text) || string.IsNullOrEmpty(salaryBox.Text) || string.IsNullOrEmpty(cityBox.Text) || string.IsNullOrEmpty(passwordBox.Text))
            {
                MessageBox.Show("Please provide all the required informations.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void generateIDButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int r = random.Next(100000, 999999);

            bool dupliFound = true;

            while (dupliFound)
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=MANIUL\\SQLEXPRESS;Initial Catalog=LAB;Integrated Security=True");

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM EMPLOYEES WHERE EmployeeID = @EmployeeID", conn);
                    cmd.Parameters.AddWithValue("@EmployeeID", r);

                    int rowCount = (int)cmd.ExecuteScalar();

                    if (rowCount > 0)
                    {
                        r = random.Next(100000, 999999);
                    }
                    else
                    {
                        dupliFound = false;
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            idBox.Text = Convert.ToString(r);
        }


        private void registerButton_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection("Data Source=MANIUL\\SQLEXPRESS;Initial Catalog=LAB;Integrated Security=True");

                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO EMPLOYEES VALUES(@EmployeeID,@EmployeeName,@EmployeeSalary,@EmployeeCity,@EmployeePassword)", conn);
                cmd.Parameters.AddWithValue("@EmployeeID", int.Parse(idBox.Text));
                cmd.Parameters.AddWithValue("@EmployeeName", nameBox.Text);
                cmd.Parameters.AddWithValue("@EmployeeSalary", int.Parse(salaryBox.Text));
                cmd.Parameters.AddWithValue("@EmployeeCity", cityBox.Text);
                cmd.Parameters.AddWithValue("@EmployeePassword", passwordBox.Text);

                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                login log = new login();
                log.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            clearFields();
            generateIDButton.Enabled = true;
            registerButton.Enabled = true;
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = true;
            passwordBox.PasswordChar = '*';
        }
    }
}
