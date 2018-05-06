namespace CricketManagementSystem
{
    partial class AddEvent
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
            this.eName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.eGroups = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dImage = new System.Windows.Forms.PictureBox();
            this.pBrowse = new System.Windows.Forms.PictureBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.eType = new MetroFramework.Controls.MetroComboBox();
            this.sError = new System.Windows.Forms.Label();
            this.pBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dImage)).BeginInit();
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
            this.materialLabel9.Location = new System.Drawing.Point(15, 152);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(86, 19);
            this.materialLabel9.TabIndex = 33;
            this.materialLabel9.Text = "Event Type:";
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
            this.materialLabel7.Size = new System.Drawing.Size(94, 19);
            this.materialLabel7.TabIndex = 31;
            this.materialLabel7.Text = "Event Name:";
            // 
            // eName
            // 
            this.eName.Depth = 0;
            this.eName.Hint = "";
            this.eName.Location = new System.Drawing.Point(157, 118);
            this.eName.MouseState = MaterialSkin.MouseState.HOVER;
            this.eName.Name = "eName";
            this.eName.PasswordChar = '\0';
            this.eName.SelectedText = "";
            this.eName.SelectionLength = 0;
            this.eName.SelectionStart = 0;
            this.eName.Size = new System.Drawing.Size(216, 23);
            this.eName.TabIndex = 39;
            this.eName.UseSystemPasswordChar = false;
            // 
            // eGroups
            // 
            this.eGroups.Depth = 0;
            this.eGroups.Hint = "";
            this.eGroups.Location = new System.Drawing.Point(157, 182);
            this.eGroups.MouseState = MaterialSkin.MouseState.HOVER;
            this.eGroups.Name = "eGroups";
            this.eGroups.PasswordChar = '\0';
            this.eGroups.SelectedText = "";
            this.eGroups.SelectionLength = 0;
            this.eGroups.SelectionStart = 0;
            this.eGroups.Size = new System.Drawing.Size(216, 23);
            this.eGroups.TabIndex = 41;
            this.eGroups.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(15, 182);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(137, 19);
            this.materialLabel1.TabIndex = 40;
            this.materialLabel1.Text = "Number Of Groups:";
            // 
            // dImage
            // 
            this.dImage.BackColor = System.Drawing.Color.LightGray;
            this.dImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dImage.Location = new System.Drawing.Point(420, 118);
            this.dImage.Name = "dImage";
            this.dImage.Size = new System.Drawing.Size(146, 140);
            this.dImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dImage.TabIndex = 48;
            this.dImage.TabStop = false;
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
            // eType
            // 
            this.eType.FormattingEnabled = true;
            this.eType.ItemHeight = 23;
            this.eType.Items.AddRange(new object[] {
            "030",
            "031",
            "032",
            "033",
            "034",
            "035",
            "036"});
            this.eType.Location = new System.Drawing.Point(157, 147);
            this.eType.Name = "eType";
            this.eType.Size = new System.Drawing.Size(216, 29);
            this.eType.TabIndex = 55;
            // 
            // sError
            // 
            this.sError.AutoSize = true;
            this.sError.Location = new System.Drawing.Point(16, 283);
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
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 439);
            this.Controls.Add(this.pBack);
            this.Controls.Add(this.sError);
            this.Controls.Add(this.eType);
            this.Controls.Add(this.pBrowse);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.dImage);
            this.Controls.Add(this.eGroups);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.eName);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel7);
            this.MaximizeBox = false;
            this.Name = "AddEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Event";
            ((System.ComponentModel.ISupportInitialize)(this.dImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField eName;
        private MaterialSkin.Controls.MaterialSingleLineTextField eGroups;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox dImage;
        private System.Windows.Forms.PictureBox pBrowse;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MetroFramework.Controls.MetroComboBox eType;
        private System.Windows.Forms.Label sError;
        private System.Windows.Forms.PictureBox pBack;
    }
}