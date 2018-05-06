namespace CricketManagementSystem
{
    partial class AddSquad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.sLoadBoard = new MetroFramework.Controls.MetroComboBox();
            this.sError = new System.Windows.Forms.Label();
            this.pBack = new System.Windows.Forms.PictureBox();
            this.sBoard = new MaterialSkin.Controls.MaterialLabel();
            this.sCountry = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bPlayerID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bPlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPlayerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(15, 208);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(99, 19);
            this.materialLabel10.TabIndex = 34;
            this.materialLabel10.Text = "Squad Name:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(15, 178);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(109, 19);
            this.materialLabel9.TabIndex = 33;
            this.materialLabel9.Text = "Country Name:";
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
            this.materialLabel7.Size = new System.Drawing.Size(89, 19);
            this.materialLabel7.TabIndex = 31;
            this.materialLabel7.Text = "Load Board:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(15, 152);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(96, 19);
            this.materialLabel1.TabIndex = 40;
            this.materialLabel1.Text = "Board Name:";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            // sLoadBoard
            // 
            this.sLoadBoard.FormattingEnabled = true;
            this.sLoadBoard.ItemHeight = 23;
            this.sLoadBoard.Items.AddRange(new object[] {
            "030",
            "031",
            "032",
            "033",
            "034",
            "035",
            "036"});
            this.sLoadBoard.Location = new System.Drawing.Point(157, 114);
            this.sLoadBoard.Name = "sLoadBoard";
            this.sLoadBoard.Size = new System.Drawing.Size(216, 29);
            this.sLoadBoard.TabIndex = 55;
            // 
            // sError
            // 
            this.sError.AutoSize = true;
            this.sError.Location = new System.Drawing.Point(16, 386);
            this.sError.Name = "sError";
            this.sError.Size = new System.Drawing.Size(35, 13);
            this.sError.TabIndex = 58;
            this.sError.Text = "label3";
            this.sError.Visible = false;
            // 
            // pBack
            // 
            this.pBack.BackColor = System.Drawing.Color.Transparent;
            this.pBack.Image = global::CricketManagementSystem.Properties.Resources.camera_icon1;
            this.pBack.Location = new System.Drawing.Point(532, 24);
            this.pBack.Name = "pBack";
            this.pBack.Size = new System.Drawing.Size(47, 40);
            this.pBack.TabIndex = 59;
            this.pBack.TabStop = false;
            // 
            // sBoard
            // 
            this.sBoard.AutoSize = true;
            this.sBoard.BackColor = System.Drawing.Color.Transparent;
            this.sBoard.Depth = 0;
            this.sBoard.Font = new System.Drawing.Font("Roboto", 11F);
            this.sBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sBoard.Location = new System.Drawing.Point(153, 152);
            this.sBoard.MouseState = MaterialSkin.MouseState.HOVER;
            this.sBoard.Name = "sBoard";
            this.sBoard.Size = new System.Drawing.Size(96, 19);
            this.sBoard.TabIndex = 63;
            this.sBoard.Text = "Board Name:";
            this.sBoard.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.sBoard.Visible = false;
            // 
            // sCountry
            // 
            this.sCountry.AutoSize = true;
            this.sCountry.BackColor = System.Drawing.Color.Transparent;
            this.sCountry.Depth = 0;
            this.sCountry.Font = new System.Drawing.Font("Roboto", 11F);
            this.sCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sCountry.Location = new System.Drawing.Point(153, 178);
            this.sCountry.MouseState = MaterialSkin.MouseState.HOVER;
            this.sCountry.Name = "sCountry";
            this.sCountry.Size = new System.Drawing.Size(96, 19);
            this.sCountry.TabIndex = 64;
            this.sCountry.Text = "Board Name:";
            this.sCountry.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.sCountry.Visible = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(157, 204);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(216, 23);
            this.materialSingleLineTextField1.TabIndex = 65;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(19, 262);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(547, 1);
            this.materialDivider1.TabIndex = 66;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bPlayerID,
            this.bPlayerName,
            this.bPlayerType});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(19, 269);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(547, 111);
            this.bunifuCustomDataGrid1.TabIndex = 67;
            // 
            // bPlayerID
            // 
            this.bPlayerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bPlayerID.HeaderText = "Player ID";
            this.bPlayerID.Name = "bPlayerID";
            // 
            // bPlayerName
            // 
            this.bPlayerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bPlayerName.HeaderText = "PlayerName";
            this.bPlayerName.Name = "bPlayerName";
            this.bPlayerName.ReadOnly = true;
            this.bPlayerName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bPlayerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bPlayerType
            // 
            this.bPlayerType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bPlayerType.HeaderText = "PlayerType";
            this.bPlayerType.Name = "bPlayerType";
            this.bPlayerType.ReadOnly = true;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(157, 233);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(216, 23);
            this.materialSingleLineTextField2.TabIndex = 68;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(15, 237);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(138, 19);
            this.materialLabel2.TabIndex = 69;
            this.materialLabel2.Text = "Number Of Players:";
            // 
            // AddSquad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 439);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.sCountry);
            this.Controls.Add(this.sBoard);
            this.Controls.Add(this.pBack);
            this.Controls.Add(this.sError);
            this.Controls.Add(this.sLoadBoard);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel7);
            this.MaximizeBox = false;
            this.Name = "AddSquad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Squad";
            this.Load += new System.EventHandler(this.AddSquad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MetroFramework.Controls.MetroComboBox sLoadBoard;
        private System.Windows.Forms.Label sError;
        private System.Windows.Forms.PictureBox pBack;
        private MaterialSkin.Controls.MaterialLabel sBoard;
        private MaterialSkin.Controls.MaterialLabel sCountry;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewComboBoxColumn bPlayerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPlayerType;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}