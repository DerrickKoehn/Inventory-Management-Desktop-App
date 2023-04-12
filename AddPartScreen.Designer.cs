
namespace InventoryManagementProgram
{
    partial class AddPartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPartScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.inHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.outsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.partIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.companyNameMachineIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.machineIDLabel = new System.Windows.Forms.Label();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // inHouseRadioButton
            // 
            this.inHouseRadioButton.AutoSize = true;
            this.inHouseRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inHouseRadioButton.Location = new System.Drawing.Point(161, 8);
            this.inHouseRadioButton.Name = "inHouseRadioButton";
            this.inHouseRadioButton.Size = new System.Drawing.Size(98, 24);
            this.inHouseRadioButton.TabIndex = 1;
            this.inHouseRadioButton.TabStop = true;
            this.inHouseRadioButton.Text = "In-House";
            this.inHouseRadioButton.UseVisualStyleBackColor = true;
            this.inHouseRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // outsourcedRadioButton
            // 
            this.outsourcedRadioButton.AutoSize = true;
            this.outsourcedRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outsourcedRadioButton.Location = new System.Drawing.Point(269, 8);
            this.outsourcedRadioButton.Name = "outsourcedRadioButton";
            this.outsourcedRadioButton.Size = new System.Drawing.Size(117, 24);
            this.outsourcedRadioButton.TabIndex = 2;
            this.outsourcedRadioButton.TabStop = true;
            this.outsourcedRadioButton.Text = "Outsourced";
            this.outsourcedRadioButton.UseVisualStyleBackColor = true;
            this.outsourcedRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // partIDTextBox
            // 
            this.partIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partIDTextBox.Location = new System.Drawing.Point(161, 75);
            this.partIDTextBox.Name = "partIDTextBox";
            this.partIDTextBox.ReadOnly = true;
            this.partIDTextBox.Size = new System.Drawing.Size(225, 27);
            this.partIDTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(161, 123);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(225, 27);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryTextBox.Location = new System.Drawing.Point(161, 167);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(225, 27);
            this.inventoryTextBox.TabIndex = 5;
            this.inventoryTextBox.TextChanged += new System.EventHandler(this.inventoryTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(161, 215);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(225, 27);
            this.priceTextBox.TabIndex = 6;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTextBox.Location = new System.Drawing.Point(161, 265);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(78, 27);
            this.maxTextBox.TabIndex = 7;
            this.maxTextBox.TextChanged += new System.EventHandler(this.maxTextBox_TextChanged);
            // 
            // minTextBox
            // 
            this.minTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTextBox.Location = new System.Drawing.Point(302, 265);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(84, 27);
            this.minTextBox.TabIndex = 8;
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // companyNameMachineIDTextBox
            // 
            this.companyNameMachineIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameMachineIDTextBox.Location = new System.Drawing.Point(161, 316);
            this.companyNameMachineIDTextBox.Name = "companyNameMachineIDTextBox";
            this.companyNameMachineIDTextBox.Size = new System.Drawing.Size(225, 27);
            this.companyNameMachineIDTextBox.TabIndex = 9;
            this.companyNameMachineIDTextBox.TextChanged += new System.EventHandler(this.companyNameMachineIDTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Min";
            // 
            // machineIDLabel
            // 
            this.machineIDLabel.AutoSize = true;
            this.machineIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineIDLabel.Location = new System.Drawing.Point(51, 319);
            this.machineIDLabel.Name = "machineIDLabel";
            this.machineIDLabel.Size = new System.Drawing.Size(94, 20);
            this.machineIDLabel.TabIndex = 16;
            this.machineIDLabel.Text = "Machine ID";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.Location = new System.Drawing.Point(12, 319);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(128, 20);
            this.companyNameLabel.TabIndex = 17;
            this.companyNameLabel.Text = "Company Name";
            this.companyNameLabel.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(225, 370);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(81, 49);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(401, 370);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(81, 49);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AddPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.machineIDLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companyNameMachineIDTextBox);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.partIDTextBox);
            this.Controls.Add(this.outsourcedRadioButton);
            this.Controls.Add(this.inHouseRadioButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPartScreen";
            this.Text = "Add Part Screen";
            this.Load += new System.EventHandler(this.AddPartScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton inHouseRadioButton;
        private System.Windows.Forms.RadioButton outsourcedRadioButton;
        private System.Windows.Forms.TextBox partIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox companyNameMachineIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label machineIDLabel;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
    }
}