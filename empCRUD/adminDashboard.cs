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
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void enterIDtxt_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(isEmpty())
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
                MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getEmployeeRecord();
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearFields()
        {
            nameBox.Clear();
            salaryBox.Clear();
            cityBox.Clear();
            idBox.Clear();
            idSearchBox.Clear();
            passwordBox.Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idBox.Text))
            {
                MessageBox.Show("Please enter the Employee ID to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection("Data Source=MANIUL\\SQLEXPRESS;Initial Catalog=LAB;Integrated Security=True");

                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM EMPLOYEES WHERE EmployeeID = @EmployeeID", conn);
                cmd.Parameters.AddWithValue("@EmployeeID", int.Parse(idBox.Text));
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Employee information deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getEmployeeRecord();
                    resetButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Employee with the provided ID not found.", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            getEmployeeRecord();
            employeeRecords.ReadOnly = true;
            idBox.ReadOnly = true;
        }

        private void getEmployeeRecord()
        {
            SqlConnection conn = new SqlConnection("Data Source=MANIUL\\SQLEXPRESS;Initial Catalog=LAB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Employees", conn);
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            employeeRecords.DataSource = dt;
        }

        private void employeeRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            generateIDButton.Enabled = false;
            addButton.Enabled = false;
            nameBox.Text = employeeRecords.SelectedRows[0].Cells[0].Value.ToString();
            idBox.Text = employeeRecords.SelectedRows[0].Cells[1].Value.ToString();
            salaryBox.Text = employeeRecords.SelectedRows[0].Cells[2].Value.ToString();
            cityBox.Text = employeeRecords.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            generateIDButton.Enabled = true;
            addButton.Enabled = true;

            if (isEmpty())
            {
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection("Data Source=MANIUL\\SQLEXPRESS;Initial Catalog=LAB;Integrated Security=True");

                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE EMPLOYEES SET EmployeeName = @EmployeeName, EmployeeSalary = @EmployeeSalary, EmployeeCity = @EmployeeCity, EmployeePassword = @EmployeePassword WHERE EmployeeID = @EmployeeID", conn);

                cmd.Parameters.AddWithValue("@EmployeeID", int.Parse(idBox.Text));
                cmd.Parameters.AddWithValue("@EmployeeName", nameBox.Text);
                cmd.Parameters.AddWithValue("@EmployeeSalary", int.Parse(salaryBox.Text));
                cmd.Parameters.AddWithValue("@EmployeeCity", cityBox.Text);
                cmd.Parameters.AddWithValue("@EmployeePassword", passwordBox.Text);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Employee information updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getEmployeeRecord();
                resetButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating employee information: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool isEmpty()
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(idBox.Text) || string.IsNullOrEmpty(salaryBox.Text) || string.IsNullOrEmpty(cityBox.Text))
            {
                MessageBox.Show("Please provide all the required informations.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(idSearchBox.Text))
            {
                MessageBox.Show("Please enter the Employee ID to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection("Data Source=MANIUL\\SQLEXPRESS;Initial Catalog=LAB;Integrated Security=True");

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM EMPLOYEES WHERE EmployeeID = @EmployeeID", conn);
                cmd.Parameters.AddWithValue("@EmployeeID", int.Parse(idSearchBox.Text));

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    generateIDButton.Enabled = false;
                    addButton.Enabled = false;
                    nameBox.Text = reader["EmployeeName"].ToString();
                    idBox.Text = reader["EmployeeID"].ToString();
                    salaryBox.Text = reader["EmployeeSalary"].ToString();
                    cityBox.Text = reader["EmployeeCity"].ToString();
                    MessageBox.Show("Employee found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Employee with the provided ID not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void resetButton_Click(object sender, EventArgs e)
        {
            clearFields();
            generateIDButton.Enabled = true;
            addButton.Enabled = true;
        }

        private void employeeRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = true;
            passwordBox.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.ShowDialog();
            this.Close();
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
