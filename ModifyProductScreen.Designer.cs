
namespace InventoryManagementProgram
{
    partial class ModifyProductScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyProductScreen));
            this.exitButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.iDLabel = new System.Windows.Forms.Label();
            this.productMinTextBox = new System.Windows.Forms.TextBox();
            this.productMaxTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.productInventoryTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.partSearchTextBox = new System.Windows.Forms.TextBox();
            this.removePartButton = new System.Windows.Forms.Button();
            this.addPartButton = new System.Windows.Forms.Button();
            this.productPartsLabel = new System.Windows.Forms.Label();
            this.allPartsLabel = new System.Windows.Forms.Label();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProductParts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductParts)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1013, 669);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(81, 49);
            this.exitButton.TabIndex = 79;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(915, 669);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(81, 49);
            this.saveChangesButton.TabIndex = 78;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(20, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(173, 29);
            this.titleLabel.TabIndex = 71;
            this.titleLabel.Text = "Modify Product";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(213, 413);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(36, 20);
            this.minLabel.TabIndex = 99;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(67, 417);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(40, 20);
            this.maxLabel.TabIndex = 98;
            this.maxLabel.Text = "Max";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(59, 363);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 20);
            this.priceLabel.TabIndex = 97;
            this.priceLabel.Text = "Price";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(31, 315);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(76, 20);
            this.inventoryLabel.TabIndex = 96;
            this.inventoryLabel.Text = "Inventory";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(54, 275);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 20);
            this.nameLabel.TabIndex = 95;
            this.nameLabel.Text = "Name";
            // 
            // iDLabel
            // 
            this.iDLabel.AutoSize = true;
            this.iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDLabel.Location = new System.Drawing.Point(84, 227);
            this.iDLabel.Name = "iDLabel";
            this.iDLabel.Size = new System.Drawing.Size(26, 20);
            this.iDLabel.TabIndex = 94;
            this.iDLabel.Text = "ID";
            // 
            // productMinTextBox
            // 
            this.productMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMinTextBox.Location = new System.Drawing.Point(264, 410);
            this.productMinTextBox.Name = "productMinTextBox";
            this.productMinTextBox.Size = new System.Drawing.Size(84, 27);
            this.productMinTextBox.TabIndex = 93;
            // 
            // productMaxTextBox
            // 
            this.productMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMaxTextBox.Location = new System.Drawing.Point(123, 410);
            this.productMaxTextBox.Name = "productMaxTextBox";
            this.productMaxTextBox.Size = new System.Drawing.Size(78, 27);
            this.productMaxTextBox.TabIndex = 92;
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceTextBox.Location = new System.Drawing.Point(123, 360);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(225, 27);
            this.productPriceTextBox.TabIndex = 91;
            // 
            // productInventoryTextBox
            // 
            this.productInventoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInventoryTextBox.Location = new System.Drawing.Point(123, 312);
            this.productInventoryTextBox.Name = "productInventoryTextBox";
            this.productInventoryTextBox.Size = new System.Drawing.Size(225, 27);
            this.productInventoryTextBox.TabIndex = 90;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTextBox.Location = new System.Drawing.Point(123, 268);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(225, 27);
            this.productNameTextBox.TabIndex = 89;
            this.productNameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDTextBox.Location = new System.Drawing.Point(123, 220);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(225, 27);
            this.productIDTextBox.TabIndex = 88;
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Location = new System.Drawing.Point(760, 29);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(81, 27);
            this.partsSearchButton.TabIndex = 87;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            this.partsSearchButton.Click += new System.EventHandler(this.partsSearchButton_Click);
            // 
            // partSearchTextBox
            // 
            this.partSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partSearchTextBox.Location = new System.Drawing.Point(847, 29);
            this.partSearchTextBox.Name = "partSearchTextBox";
            this.partSearchTextBox.Size = new System.Drawing.Size(232, 27);
            this.partSearchTextBox.TabIndex = 86;
            this.partSearchTextBox.TextChanged += new System.EventHandler(this.partSearchTextBox_TextChanged);
            // 
            // removePartButton
            // 
            this.removePartButton.Location = new System.Drawing.Point(998, 588);
            this.removePartButton.Name = "removePartButton";
            this.removePartButton.Size = new System.Drawing.Size(81, 49);
            this.removePartButton.TabIndex = 85;
            this.removePartButton.Text = "Remove Part";
            this.removePartButton.UseVisualStyleBackColor = true;
            this.removePartButton.Click += new System.EventHandler(this.removePartButton_Click);
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(998, 283);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(81, 49);
            this.addPartButton.TabIndex = 84;
            this.addPartButton.Text = "Add Part";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // productPartsLabel
            // 
            this.productPartsLabel.AutoSize = true;
            this.productPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPartsLabel.Location = new System.Drawing.Point(500, 345);
            this.productPartsLabel.Name = "productPartsLabel";
            this.productPartsLabel.Size = new System.Drawing.Size(162, 20);
            this.productPartsLabel.TabIndex = 83;
            this.productPartsLabel.Text = "This Product\'s Parts";
            // 
            // allPartsLabel
            // 
            this.allPartsLabel.AutoSize = true;
            this.allPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPartsLabel.Location = new System.Drawing.Point(500, 32);
            this.allPartsLabel.Name = "allPartsLabel";
            this.allPartsLabel.Size = new System.Drawing.Size(73, 20);
            this.allPartsLabel.TabIndex = 82;
            this.allPartsLabel.Text = "All Parts";
            // 
            // dgvParts
            // 
            this.dgvParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(504, 61);
            this.dgvParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvParts.MultiSelect = false;
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.RowHeadersVisible = false;
            this.dgvParts.RowHeadersWidth = 51;
            this.dgvParts.RowTemplate.Height = 24;
            this.dgvParts.Size = new System.Drawing.Size(575, 217);
            this.dgvParts.TabIndex = 100;
            // 
            // dgvProductParts
            // 
            this.dgvProductParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductParts.Location = new System.Drawing.Point(504, 367);
            this.dgvProductParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductParts.MultiSelect = false;
            this.dgvProductParts.Name = "dgvProductParts";
            this.dgvProductParts.ReadOnly = true;
            this.dgvProductParts.RowHeadersVisible = false;
            this.dgvProductParts.RowHeadersWidth = 51;
            this.dgvProductParts.RowTemplate.Height = 24;
            this.dgvProductParts.Size = new System.Drawing.Size(575, 216);
            this.dgvProductParts.TabIndex = 101;
            // 
            // ModifyProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 729);
            this.Controls.Add(this.dgvProductParts);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.iDLabel);
            this.Controls.Add(this.productMinTextBox);
            this.Controls.Add(this.productMaxTextBox);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(this.productInventoryTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(this.partsSearchButton);
            this.Controls.Add(this.partSearchTextBox);
            this.Controls.Add(this.removePartButton);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.productPartsLabel);
            this.Controls.Add(this.allPartsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyProductScreen";
            this.Text = "Modify Product Screen";
            this.Load += new System.EventHandler(this.ModifyProductScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label iDLabel;
        private System.Windows.Forms.TextBox productMinTextBox;
        private System.Windows.Forms.TextBox productMaxTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.TextBox productInventoryTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.TextBox partSearchTextBox;
        private System.Windows.Forms.Button removePartButton;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Label productPartsLabel;
        private System.Windows.Forms.Label allPartsLabel;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProductParts;
    }
}