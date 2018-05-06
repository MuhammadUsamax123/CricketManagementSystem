namespace CricketManagementSystem
{
    partial class AddBoard
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
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.bName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bChairman = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.bImage = new System.Windows.Forms.PictureBox();
            this.pBrowse = new System.Windows.Forms.PictureBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bCountry = new MetroFramework.Controls.MetroComboBox();
            this.sError = new System.Windows.Forms.Label();
            this.pBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBack)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(15, 182);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(65, 19);
            this.materialLabel9.TabIndex = 33;
            this.materialLabel9.Text = "Country:";
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
            this.materialLabel7.Size = new System.Drawing.Size(96, 19);
            this.materialLabel7.TabIndex = 31;
            this.materialLabel7.Text = "Board Name:";
            // 
            // bName
            // 
            this.bName.Depth = 0;
            this.bName.Hint = "";
            this.bName.Location = new System.Drawing.Point(157, 118);
            this.bName.MouseState = MaterialSkin.MouseState.HOVER;
            this.bName.Name = "bName";
            this.bName.PasswordChar = '\0';
            this.bName.SelectedText = "";
            this.bName.SelectionLength = 0;
            this.bName.SelectionStart = 0;
            this.bName.Size = new System.Drawing.Size(216, 23);
            this.bName.TabIndex = 39;
            this.bName.UseSystemPasswordChar = false;
            // 
            // bChairman
            // 
            this.bChairman.Depth = 0;
            this.bChairman.Hint = "";
            this.bChairman.Location = new System.Drawing.Point(157, 147);
            this.bChairman.MouseState = MaterialSkin.MouseState.HOVER;
            this.bChairman.Name = "bChairman";
            this.bChairman.PasswordChar = '\0';
            this.bChairman.SelectedText = "";
            this.bChairman.SelectionLength = 0;
            this.bChairman.SelectionStart = 0;
            this.bChairman.Size = new System.Drawing.Size(216, 23);
            this.bChairman.TabIndex = 41;
            this.bChairman.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(15, 147);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(121, 19);
            this.materialLabel1.TabIndex = 40;
            this.materialLabel1.Text = "Chairman Name:";
            // 
            // bImage
            // 
            this.bImage.BackColor = System.Drawing.Color.LightGray;
            this.bImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bImage.Location = new System.Drawing.Point(420, 118);
            this.bImage.Name = "bImage";
            this.bImage.Size = new System.Drawing.Size(146, 140);
            this.bImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bImage.TabIndex = 48;
            this.bImage.TabStop = false;
            // 
            // pBrowse
            // 
            this.pBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pBrowse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBrowse.Image = global::CricketManagementSystem.Properties.Resources.camera_icon1;
            this.pBrowse.Location = new System.Drawing.Point(420, 231);
            this.pBrowse.Name = "pBrowse";
            this.pBrowse.Size = new System.Drawing.Size(27, 27);
            this.pBrowse.TabIndex = 53;
            this.pBrowse.TabStop = false;
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
            // bCountry
            // 
            this.bCountry.FormattingEnabled = true;
            this.bCountry.ItemHeight = 23;
            this.bCountry.Items.AddRange(new object[] {
            "030",
            "031",
            "032",
            "033",
            "034",
            "035",
            "036"});
            this.bCountry.Location = new System.Drawing.Point(157, 176);
            this.bCountry.Name = "bCountry";
            this.bCountry.Size = new System.Drawing.Size(216, 29);
            this.bCountry.TabIndex = 55;
            // 
            // sError
            // 
            this.sError.AutoSize = true;
            this.sError.Location = new System.Drawing.Point(16, 245);
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
            // AddBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 439);
            this.Controls.Add(this.pBack);
            this.Controls.Add(this.sError);
            this.Controls.Add(this.bCountry);
            this.Controls.Add(this.pBrowse);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.bImage);
            this.Controls.Add(this.bChairman);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.bName);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel7);
            this.MaximizeBox = false;
            this.Name = "AddBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Board";
            this.Load += new System.EventHandler(this.AddBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField bName;
        private MaterialSkin.Controls.MaterialSingleLineTextField bChairman;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox bImage;
        private System.Windows.Forms.PictureBox pBrowse;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MetroFramework.Controls.MetroComboBox bCountry;
        private System.Windows.Forms.Label sError;
        private System.Windows.Forms.PictureBox pBack;
    }
}