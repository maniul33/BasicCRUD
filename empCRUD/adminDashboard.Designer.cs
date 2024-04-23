namespace empCRUD
{
    partial class adminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.enterIDtxt = new System.Windows.Forms.Label();
            this.enterNametxt = new System.Windows.Forms.Label();
            this.enterID2Txt = new System.Windows.Forms.Label();
            this.enterSalarytxt = new System.Windows.Forms.Label();
            this.enterCitytxt = new System.Windows.Forms.Label();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.idSearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lABDataSet = new empCRUD.LABDataSet();
            this.employeesTableAdapter = new empCRUD.LABDataSetTableAdapters.EmployeesTableAdapter();
            this.employeeRecords = new System.Windows.Forms.DataGridView();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generateIDButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lABDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // enterIDtxt
            // 
            this.enterIDtxt.AutoSize = true;
            this.enterIDtxt.Location = new System.Drawing.Point(35, 76);
            this.enterIDtxt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.enterIDtxt.Name = "enterIDtxt";
            this.enterIDtxt.Size = new System.Drawing.Size(228, 29);
            this.enterIDtxt.TabIndex = 0;
            this.enterIDtxt.Text = "Enter ID to search:";
            this.enterIDtxt.Click += new System.EventHandler(this.enterIDtxt_Click);
            // 
            // enterNametxt
            // 
            this.enterNametxt.AutoSize = true;
            this.enterNametxt.Location = new System.Drawing.Point(99, 157);
            this.enterNametxt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.enterNametxt.Name = "enterNametxt";
            this.enterNametxt.Size = new System.Drawing.Size(158, 29);
            this.enterNametxt.TabIndex = 1;
            this.enterNametxt.Text = "Enter Name:";
            // 
            // enterID2Txt
            // 
            this.enterID2Txt.AutoSize = true;
            this.enterID2Txt.Location = new System.Drawing.Point(99, 227);
            this.enterID2Txt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.enterID2Txt.Name = "enterID2Txt";
            this.enterID2Txt.Size = new System.Drawing.Size(114, 29);
            this.enterID2Txt.TabIndex = 2;
            this.enterID2Txt.Text = "Enter ID:";
            // 
            // enterSalarytxt
            // 
            this.enterSalarytxt.AutoSize = true;
            this.enterSalarytxt.Location = new System.Drawing.Point(99, 328);
            this.enterSalarytxt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.enterSalarytxt.Name = "enterSalarytxt";
            this.enterSalarytxt.Size = new System.Drawing.Size(162, 29);
            this.enterSalarytxt.TabIndex = 3;
            this.enterSalarytxt.Text = "Enter Salary:";
            // 
            // enterCitytxt
            // 
            this.enterCitytxt.AutoSize = true;
            this.enterCitytxt.Location = new System.Drawing.Point(99, 393);
            this.enterCitytxt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.enterCitytxt.Name = "enterCitytxt";
            this.enterCitytxt.Size = new System.Drawing.Size(133, 29);
            this.enterCitytxt.TabIndex = 4;
            this.enterCitytxt.Text = "Enter City:";
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(270, 323);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(274, 34);
            this.salaryBox.TabIndex = 5;
            this.salaryBox.TabStop = false;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(270, 222);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(274, 34);
            this.idBox.TabIndex = 6;
            this.idBox.TabStop = false;
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(270, 157);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(274, 34);
            this.nameBox.TabIndex = 7;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(270, 390);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(274, 34);
            this.cityBox.TabIndex = 8;
            this.cityBox.TabStop = false;
            // 
            // idSearchBox
            // 
            this.idSearchBox.Location = new System.Drawing.Point(272, 76);
            this.idSearchBox.Name = "idSearchBox";
            this.idSearchBox.Size = new System.Drawing.Size(189, 34);
            this.idSearchBox.TabIndex = 9;
            this.idSearchBox.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Location = new System.Drawing.Point(476, 76);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(134, 34);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.lABDataSet;
            // 
            // lABDataSet
            // 
            this.lABDataSet.DataSetName = "LABDataSet";
            this.lABDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // employeeRecords
            // 
            this.employeeRecords.AutoGenerateColumns = false;
            this.employeeRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeRecords.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.employeeRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeeSalaryDataGridViewTextBoxColumn,
            this.employeeCityDataGridViewTextBoxColumn});
            this.employeeRecords.DataSource = this.employeesBindingSource;
            this.employeeRecords.Location = new System.Drawing.Point(565, 145);
            this.employeeRecords.Name = "employeeRecords";
            this.employeeRecords.RowHeadersWidth = 51;
            this.employeeRecords.RowTemplate.Height = 24;
            this.employeeRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeRecords.Size = new System.Drawing.Size(620, 336);
            this.employeeRecords.TabIndex = 12;
            this.employeeRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeRecords_CellClick);
            this.employeeRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeRecords_CellContentClick);
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.employeeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // employeeSalaryDataGridViewTextBoxColumn
            // 
            this.employeeSalaryDataGridViewTextBoxColumn.DataPropertyName = "EmployeeSalary";
            this.employeeSalaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.employeeSalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeSalaryDataGridViewTextBoxColumn.Name = "employeeSalaryDataGridViewTextBoxColumn";
            // 
            // employeeCityDataGridViewTextBoxColumn
            // 
            this.employeeCityDataGridViewTextBoxColumn.DataPropertyName = "EmployeeCity";
            this.employeeCityDataGridViewTextBoxColumn.HeaderText = "City";
            this.employeeCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeCityDataGridViewTextBoxColumn.Name = "employeeCityDataGridViewTextBoxColumn";
            // 
            // generateIDButton
            // 
            this.generateIDButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.generateIDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateIDButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generateIDButton.Location = new System.Drawing.Point(270, 262);
            this.generateIDButton.Name = "generateIDButton";
            this.generateIDButton.Size = new System.Drawing.Size(163, 35);
            this.generateIDButton.TabIndex = 10;
            this.generateIDButton.Text = "Generate ID";
            this.generateIDButton.UseVisualStyleBackColor = false;
            this.generateIDButton.Click += new System.EventHandler(this.generateIDButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Chocolate;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetButton.Location = new System.Drawing.Point(451, 503);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(92, 41);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Location = new System.Drawing.Point(332, 505);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(109, 39);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.Control;
            this.updateButton.Location = new System.Drawing.Point(213, 505);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(109, 39);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.ForestGreen;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addButton.Location = new System.Drawing.Point(96, 506);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(109, 39);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(269, 449);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(274, 34);
            this.passwordBox.TabIndex = 16;
            this.passwordBox.TabStop = false;
            this.passwordBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 452);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Password:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(938, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Logged in as Admin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Firebrick;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.Control;
            this.logoutButton.Location = new System.Drawing.Point(984, 76);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(133, 44);
            this.logoutButton.TabIndex = 18;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1197, 574);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.generateIDButton);
            this.Controls.Add(this.employeeRecords);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.idSearchBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.enterCitytxt);
            this.Controls.Add(this.enterSalarytxt);
            this.Controls.Add(this.enterID2Txt);
            this.Controls.Add(this.enterNametxt);
            this.Controls.Add(this.enterIDtxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "adminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lABDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterIDtxt;
        private System.Windows.Forms.Label enterNametxt;
        private System.Windows.Forms.Label enterID2Txt;
        private System.Windows.Forms.Label enterSalarytxt;
        private System.Windows.Forms.Label enterCitytxt;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox idSearchBox;
        private System.Windows.Forms.Button searchButton;
        private LABDataSet lABDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private LABDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridView employeeRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button generateIDButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logoutButton;
    }
}

