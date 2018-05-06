namespace CricketManagementSystem
{
    partial class Login
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
            this.userName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginbutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorLabel = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Depth = 0;
            this.userName.Hint = "User Name";
            this.userName.Location = new System.Drawing.Point(33, 102);
            this.userName.MouseState = MaterialSkin.MouseState.HOVER;
            this.userName.Name = "userName";
            this.userName.PasswordChar = '\0';
            this.userName.SelectedText = "";
            this.userName.SelectionLength = 0;
            this.userName.SelectionStart = 0;
            this.userName.Size = new System.Drawing.Size(206, 23);
            this.userName.TabIndex = 0;
            this.userName.UseSystemPasswordChar = false;
            // 
            // password
            // 
            this.password.Depth = 0;
            this.password.Hint = "Password";
            this.password.Location = new System.Drawing.Point(33, 148);
            this.password.MouseState = MaterialSkin.MouseState.HOVER;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(206, 23);
            this.password.TabIndex = 1;
            this.password.UseSystemPasswordChar = false;
            // 
            // loginbutton
            // 
            this.loginbutton.Depth = 0;
            this.loginbutton.Location = new System.Drawing.Point(164, 234);
            this.loginbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Primary = true;
            this.loginbutton.Size = new System.Drawing.Size(75, 34);
            this.loginbutton.TabIndex = 2;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(4, 281);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(14, 13);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "#";
            this.errorLabel.Visible = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(29, 197);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Login As:";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Facotry Owner",
            "Account Manager",
            "Sales Manager"});
            this.metroComboBox1.Location = new System.Drawing.Point(107, 193);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(132, 29);
            this.metroComboBox1.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 310);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField userName;
        private MaterialSkin.Controls.MaterialSingleLineTextField password;
        private MaterialSkin.Controls.MaterialRaisedButton loginbutton;
        private System.Windows.Forms.Label errorLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}

