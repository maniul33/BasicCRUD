namespace empCRUD
{
    partial class starting
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
            this.registrationButton = new System.Windows.Forms.Button();
            this.optionSelectLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.Green;
            this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registrationButton.Location = new System.Drawing.Point(470, 201);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(220, 49);
            this.registrationButton.TabIndex = 14;
            this.registrationButton.Text = "Registration";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // optionSelectLabel
            // 
            this.optionSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionSelectLabel.Location = new System.Drawing.Point(403, 107);
            this.optionSelectLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.optionSelectLabel.Name = "optionSelectLabel";
            this.optionSelectLabel.Size = new System.Drawing.Size(375, 64);
            this.optionSelectLabel.TabIndex = 20;
            this.optionSelectLabel.Text = "Please Select an option:";
            this.optionSelectLabel.Click += new System.EventHandler(this.optionSelectLabel_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.SteelBlue;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Location = new System.Drawing.Point(470, 293);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(220, 47);
            this.loginButton.TabIndex = 21;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // starting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 551);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.optionSelectLabel);
            this.Controls.Add(this.registrationButton);
            this.Name = "starting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "starting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Label optionSelectLabel;
        private System.Windows.Forms.Button loginButton;
    }
}