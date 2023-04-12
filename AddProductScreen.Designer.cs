
namespace InventoryManagementProgram
{
    partial class AddProductScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProductParts = new System.Windows.Forms.DataGridView();
            this.allPartsLabel = new System.Windows.Forms.Label();
            this.productPartsLabel = new System.Windows.Forms.Label();
            this.addPartButton = new System.Windows.Forms.Button();
            this.removePartButton = new System.Windows.Forms.Button();
            this.saveProductButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.partSearchTextBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.iDLabel = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductParts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "Add Product";
            // 
            // dgvParts
            // 
            this.dgvParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(509, 64);
            this.dgvParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvParts.MultiSelect = false;
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.RowHeadersVisible = false;
            this.dgvParts.RowHeadersWidth = 51;
            this.dgvParts.RowTemplate.Height = 24;
            this.dgvParts.Size = new System.Drawing.Size(575, 217);
            this.dgvParts.TabIndex = 49;
            // 
            // dgvProductParts
            // 
            this.dgvProductParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductParts.Location = new System.Drawing.Point(509, 370);
            this.dgvProductParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductParts.MultiSelect = false;
            this.dgvProductParts.Name = "dgvProductParts";
            this.dgvProductParts.ReadOnly = true;
            this.dgvProductParts.RowHeadersVisible = false;
            this.dgvProductParts.RowHeadersWidth = 51;
            this.dgvProductParts.RowTemplate.Height = 24;
            this.dgvProductParts.Size = new System.Drawing.Size(575, 216);
            this.dgvProductParts.TabIndex = 50;
            // 
            // allPartsLabel
            // 
            this.allPartsLabel.AutoSize = true;
            this.allPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPartsLabel.Location = new System.Drawing.Point(505, 35);
            this.allPartsLabel.Name = "allPartsLabel";
            this.allPartsLabel.Size = new System.Drawing.Size(73, 20);
            this.allPartsLabel.TabIndex = 51;
            this.allPartsLabel.Text = "All Parts";
            // 
            // productPartsLabel
            // 
            this.productPartsLabel.AutoSize = true;
            this.productPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPartsLabel.Location = new System.Drawing.Point(505, 348);
            this.productPartsLabel.Name = "productPartsLabel";
            this.productPartsLabel.Size = new System.Drawing.Size(162, 20);
            this.productPartsLabel.TabIndex = 52;
            this.productPartsLabel.Text = "This Product\'s Parts";
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(1003, 286);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(81, 49);
            this.addPartButton.TabIndex = 53;
            this.addPartButton.Text = "Add Part";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // removePartButton
            // 
            this.removePartButton.Location = new System.Drawing.Point(1003, 591);
            this.removePartButton.Name = "removePartButton";
            this.removePartButton.Size = new System.Drawing.Size(81, 49);
            this.removePartButton.TabIndex = 54;
            this.removePartButton.Text = "Remove Part";
            this.removePartButton.UseVisualStyleBackColor = true;
            this.removePartButton.Click += new System.EventHandler(this.removePartButton_Click);
            // 
            // saveProductButton
            // 
            this.saveProductButton.Location = new System.Drawing.Point(905, 668);
            this.saveProductButton.Name = "saveProductButton";
            this.saveProductButton.Size = new System.Drawing.Size(81, 49);
            this.saveProductButton.TabIndex = 55;
            this.saveProductButton.Text = "Save Product";
            this.saveProductButton.UseVisualStyleBackColor = true;
            this.saveProductButton.Click += new System.EventHandler(this.saveProductButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1003, 668);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(81, 49);
            this.exitButton.TabIndex = 56;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Location = new System.Drawing.Point(765, 32);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(81, 27);
            this.partsSearchButton.TabIndex = 58;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            this.partsSearchButton.Click += new System.EventHandler(this.partsSearchButton_Click);
            // 
            // partSearchTextBox
            // 
            this.partSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partSearchTextBox.Location = new System.Drawing.Point(852, 32);
            this.partSearchTextBox.Name = "partSearchTextBox";
            this.partSearchTextBox.Size = new System.Drawing.Size(232, 27);
            this.partSearchTextBox.TabIndex = 57;
            this.partSearchTextBox.TextChanged += new System.EventHandler(this.partSearchTextBox_TextChanged);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(218, 416);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(36, 20);
            this.minLabel.TabIndex = 70;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(72, 420);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(40, 20);
            this.maxLabel.TabIndex = 69;
            this.maxLabel.Text = "Max";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(64, 366);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 20);
            this.priceLabel.TabIndex = 68;
            this.priceLabel.Text = "Price";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(36, 318);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(76, 20);
            this.inventoryLabel.TabIndex = 67;
            this.inventoryLabel.Text = "Inventory";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(59, 278);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 20);
            this.nameLabel.TabIndex = 66;
            this.nameLabel.Text = "Name";
            // 
            // iDLabel
            // 
            this.iDLabel.AutoSize = true;
            this.iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDLabel.Location = new System.Drawing.Point(89, 230);
            this.iDLabel.Name = "iDLabel";
            this.iDLabel.Size = new System.Drawing.Size(26, 20);
            this.iDLabel.TabIndex = 65;
            this.iDLabel.Text = "ID";
            // 
            // minTextBox
            // 
            this.minTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTextBox.Location = new System.Drawing.Point(269, 413);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(84, 27);
            this.minTextBox.TabIndex = 64;
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTextBox.Location = new System.Drawing.Point(128, 413);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(78, 27);
            this.maxTextBox.TabIndex = 63;
            this.maxTextBox.TextChanged += new System.EventHandler(this.maxTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(128, 363);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(225, 27);
            this.priceTextBox.TabIndex = 62;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryTextBox.Location = new System.Drawing.Point(128, 315);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(225, 27);
            this.inventoryTextBox.TabIndex = 61;
            this.inventoryTextBox.TextChanged += new System.EventHandler(this.inventoryTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(128, 271);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(225, 27);
            this.nameTextBox.TabIndex = 60;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDTextBox.Location = new System.Drawing.Point(128, 223);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(225, 27);
            this.productIDTextBox.TabIndex = 59;
            // 
            // AddProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 729);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.iDLabel);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(this.partsSearchButton);
            this.Controls.Add(this.partSearchTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveProductButton);
            this.Controls.Add(this.removePartButton);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.productPartsLabel);
            this.Controls.Add(this.allPartsLabel);
            this.Controls.Add(this.dgvProductParts);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductScreen";
            this.Text = "Add Product Screen";
            this.Load += new System.EventHandler(this.AddProductScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProductParts;
        private System.Windows.Forms.Label allPartsLabel;
        private System.Windows.Forms.Label productPartsLabel;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button removePartButton;
        private System.Windows.Forms.Button saveProductButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.TextBox partSearchTextBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label iDLabel;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox productIDTextBox;
    }
}