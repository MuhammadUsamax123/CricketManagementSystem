namespace CricketManagementSystem
{
    partial class AddCountry
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
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.cName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.sError = new System.Windows.Forms.Label();
            this.pBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBack)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(15, 118);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(53, 19);
            this.materialLabel7.TabIndex = 31;
            this.materialLabel7.Text = "Name:";
            // 
            // cName
            // 
            this.cName.Depth = 0;
            this.cName.Hint = "";
            this.cName.Location = new System.Drawing.Point(157, 118);
            this.cName.MouseState = MaterialSkin.MouseState.HOVER;
            this.cName.Name = "cName";
            this.cName.PasswordChar = '\0';
            this.cName.SelectedText = "";
            this.cName.SelectionLength = 0;
            this.cName.SelectionStart = 0;
            this.cName.Size = new System.Drawing.Size(216, 23);
            this.cName.TabIndex = 39;
            this.cName.UseSystemPasswordChar = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(502, 395);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(64, 36);
            this.materialFlatButton1.TabIndex = 52;
            this.materialFlatButton1.Text = "Cancel";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(420, 395);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(64, 36);
            this.materialRaisedButton2.TabIndex = 51;
            this.materialRaisedButton2.Text = "Save";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // sError
            // 
            this.sError.AutoSize = true;
            this.sError.Location = new System.Drawing.Point(16, 158);
            this.sError.Name = "sError";
            this.sError.Size = new System.Drawing.Size(35, 13);
            this.sError.TabIndex = 58;
            this.sError.Text = "label3";
            this.sError.Visible = false;
            // 
            // pBack
            // 
            this.pBack.BackColor = System.Drawing.Color.Transparent;
            this.pBack.Image = global::CricketManagementSystem.Properties.Resources.reply;
            this.pBack.Location = new System.Drawing.Point(532, 24);
            this.pBack.Name = "pBack";
            this.pBack.Size = new System.Drawing.Size(47, 40);
            this.pBack.TabIndex = 59;
            this.pBack.TabStop = false;
            // 
            // AddCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 439);
            this.Controls.Add(this.pBack);
            this.Controls.Add(this.sError);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.cName);
            this.Controls.Add(this.materialLabel7);
            this.MaximizeBox = false;
            this.Name = "AddCountry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Country";
            ((System.ComponentModel.ISupportInitialize)(this.pBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField cName;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.Label sError;
        private System.Windows.Forms.PictureBox pBack;
    }
}