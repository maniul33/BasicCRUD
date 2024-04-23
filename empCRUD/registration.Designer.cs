namespace empCRUD
{
    partial class registration
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
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generateIDButton = new System.Windows.Forms.Button();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.enterCitytxt = new System.Windows.Forms.Label();
            this.enterSalarytxt = new System.Windows.Forms.Label();
            this.enterID2Txt = new System.Windows.Forms.Label();
            this.enterNametxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(400, 399);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(274, 22);
            this.passwordBox.TabIndex = 27;
            this.passwordBox.TabStop = false;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 401);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Password:";
            // 
            // generateIDButton
            // 
            this.generateIDButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.generateIDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateIDButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generateIDButton.Location = new System.Drawing.Point(401, 212);
            this.generateIDButton.Name = "generateIDButton";
            this.generateIDButton.Size = new System.Drawing.Size(163, 35);
            this.generateIDButton.TabIndex = 25;
            this.generateIDButton.Text = "Generate ID";
            this.generateIDButton.UseVisualStyleBackColor = false;
            this.generateIDButton.Click += new System.EventHandler(this.generateIDButton_Click);
            // 
            // cityBox
            // 
            this.cityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityBox.Location = new System.Drawing.Point(401, 340);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(274, 22);
            this.cityBox.TabIndex = 24;
            this.cityBox.TabStop = false;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(401, 107);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(274, 22);
            this.nameBox.TabIndex = 23;
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(401, 172);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(274, 22);
            this.idBox.TabIndex = 22;
            this.idBox.TabStop = false;
            // 
            // salaryBox
            // 
            this.salaryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryBox.Location = new System.Drawing.Point(401, 273);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(274, 22);
            this.salaryBox.TabIndex = 21;
            this.salaryBox.TabStop = false;
            // 
            // enterCitytxt
            // 
            this.enterCitytxt.AutoSize = true;
            this.enterCitytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCitytxt.Location = new System.Drawing.Point(230, 343);
            this.enterCitytxt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.enterCitytxt.Name = "enterCitytxt";
            this.enterCitytxt.Size = new System.Drawing.Size(99, 20);
            this.enterCitytxt.TabIndex = 20;
            this.enterCitytxt.Text = "Enter City:";
            // 
            // enterSalarytxt
            // 
            this.enterSalarytxt.AutoSize = true;
            this.enterSalarytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterSalarytxt.Location = new System.Drawing.Point(230, 278);
            this.enterSalarytxt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.enterSalarytxt.Name = "enterSalarytxt";
            this.enterSalarytxt.Size = new System.Drawing.Size(119, 20);
            this.enterSalarytxt.TabIndex = 19;
            this.enterSalarytxt.Text = "Enter Salary:";
            // 
            // enterID2Txt
            // 
            this.enterID2Txt.AutoSize = true;
            this.enterID2Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterID2Txt.Location = new System.Drawing.Point(230, 177);
            this.enterID2Txt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.enterID2Txt.Name = "enterID2Txt";
            this.enterID2Txt.Size = new System.Drawing.Size(85, 20);
            this.enterID2Txt.TabIndex = 18;
            this.enterID2Txt.Text = "Enter ID:";
            // 
            // enterNametxt
            // 
            this.enterNametxt.AutoSize = true;
            this.enterNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNametxt.Location = new System.Drawing.Point(230, 107);
            this.enterNametxt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.enterNametxt.Name = "enterNametxt";
            this.enterNametxt.Size = new System.Drawing.Size(114, 20);
            this.enterNametxt.TabIndex = 17;
            this.enterNametxt.Text = "Enter Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Please Fill All The Informations:";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.ForestGreen;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.SystemColors.Control;
            this.registerButton.Location = new System.Drawing.Point(400, 449);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(127, 39);
            this.registerButton.TabIndex = 29;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Chocolate;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetButton.Location = new System.Drawing.Point(549, 449);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(126, 41);
            this.resetButton.TabIndex = 30;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 600);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateIDButton);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.enterCitytxt);
            this.Controls.Add(this.enterSalarytxt);
            this.Controls.Add(this.enterID2Txt);
            this.Controls.Add(this.enterNametxt);
            this.Name = "registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateIDButton;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.Label enterCitytxt;
        private System.Windows.Forms.Label enterSalarytxt;
        private System.Windows.Forms.Label enterID2Txt;
        private System.Windows.Forms.Label enterNametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button resetButton;
    }
}