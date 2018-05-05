namespace CricketManagementSystem
{
    partial class AddPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.ItemName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Rate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Quantity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Category = new MetroFramework.Controls.MetroComboBox();
            this.itemType = new MetroFramework.Controls.MetroComboBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 100);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(87, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Item Name:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 223);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(73, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Category:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 158);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(65, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Rate/kg:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 286);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(111, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Stock Quantity:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(263, 223);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(79, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Item Type:";
            // 
            // ItemName
            // 
            this.ItemName.Depth = 0;
            this.ItemName.Hint = "";
            this.ItemName.Location = new System.Drawing.Point(129, 100);
            this.ItemName.MouseState = MaterialSkin.MouseState.HOVER;
            this.ItemName.Name = "ItemName";
            this.ItemName.PasswordChar = '\0';
            this.ItemName.SelectedText = "";
            this.ItemName.SelectionLength = 0;
            this.ItemName.SelectionStart = 0;
            this.ItemName.Size = new System.Drawing.Size(117, 23);
            this.ItemName.TabIndex = 33;
            this.ItemName.UseSystemPasswordChar = false;
            // 
            // Rate
            // 
            this.Rate.Depth = 0;
            this.Rate.Hint = "";
            this.Rate.Location = new System.Drawing.Point(129, 154);
            this.Rate.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rate.Name = "Rate";
            this.Rate.PasswordChar = '\0';
            this.Rate.SelectedText = "";
            this.Rate.SelectionLength = 0;
            this.Rate.SelectionStart = 0;
            this.Rate.Size = new System.Drawing.Size(117, 23);
            this.Rate.TabIndex = 34;
            this.Rate.UseSystemPasswordChar = false;
            // 
            // Quantity
            // 
            this.Quantity.Depth = 0;
            this.Quantity.Hint = "";
            this.Quantity.Location = new System.Drawing.Point(129, 286);
            this.Quantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.Quantity.Name = "Quantity";
            this.Quantity.PasswordChar = '\0';
            this.Quantity.SelectedText = "";
            this.Quantity.SelectionLength = 0;
            this.Quantity.SelectionStart = 0;
            this.Quantity.Size = new System.Drawing.Size(117, 23);
            this.Quantity.TabIndex = 35;
            this.Quantity.UseSystemPasswordChar = false;
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.ItemHeight = 23;
            this.Category.Items.AddRange(new object[] {
            "Daal",
            "Rice"});
            this.Category.Location = new System.Drawing.Point(125, 219);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(121, 29);
            this.Category.TabIndex = 36;
            // 
            // itemType
            // 
            this.itemType.FormattingEnabled = true;
            this.itemType.ItemHeight = 23;
            this.itemType.Items.AddRange(new object[] {
            "Select Category first"});
            this.itemType.Location = new System.Drawing.Point(348, 216);
            this.itemType.Name = "itemType";
            this.itemType.Size = new System.Drawing.Size(188, 29);
            this.itemType.TabIndex = 37;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(472, 320);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(64, 36);
            this.materialFlatButton1.TabIndex = 39;
            this.materialFlatButton1.Text = "Cancel";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(336, 319);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(64, 36);
            this.materialRaisedButton2.TabIndex = 38;
            this.materialRaisedButton2.Text = "Save";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(391, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(390, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.Transparent;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(13, 343);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(14, 13);
            this.error.TabIndex = 41;
            this.error.Text = "#";
            this.error.Visible = false;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 385);
            this.Controls.Add(this.error);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.itemType);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Item";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField ItemName;
        private MaterialSkin.Controls.MaterialSingleLineTextField Rate;
        private MaterialSkin.Controls.MaterialSingleLineTextField Quantity;
        private MetroFramework.Controls.MetroComboBox Category;
        private MetroFramework.Controls.MetroComboBox itemType;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label error;
    }
}