using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementProgram
{
    public partial class AddPartScreen : Form
    {
        public AddPartScreen()
        {
            InitializeComponent();
            Random random = new Random();
            partIDTextBox.Text = Convert.ToString(random.Next(1000,9999));
        }
        private static void ValidateMinVsMax(int min, int max)

        {
            if (min > max)
            {
                throw new Exception("Max must be greater than Min.");
            }

        }
        private static void ValidateInventoryBetweenMinMax(int inv, int min, int max)

        {

            if (inv < min || inv > max)

            {
                throw new Exception("Inventory must be between Min and Max");
            }

        }

        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            machineIDLabel.Visible = false;
            companyNameLabel.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            machineIDLabel.Visible = true;
            companyNameLabel.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                //verify that the value of numeric text boxes is in fact numeric
                int tempInt = new int();
                double tempDouble = new double();
                if (!(Int32.TryParse(minTextBox.Text, out tempInt)) || !(Int32.TryParse(maxTextBox.Text, out tempInt)) || !(Int32.TryParse(inventoryTextBox.Text, out tempInt)) || !(Double.TryParse(priceTextBox.Text, out tempDouble)))
                {
                    throw new Exception("Min, Max, Inventory, and Price must contain only numeric values.");
                    
                }
                if (inHouseRadioButton.Checked)
                {
                    if (!Int32.TryParse(companyNameMachineIDTextBox.Text, out tempInt))
                    {
                        throw new Exception("For inhouse parts, Machine ID must contain a numeric value.");
                    }

                }
                //verify whether Min is less than Max and verify that Inventory is between Min and Max
                ValidateMinVsMax(Convert.ToInt32(minTextBox.Text), Convert.ToInt32(maxTextBox.Text));
                ValidateInventoryBetweenMinMax(Convert.ToInt32(inventoryTextBox.Text), Convert.ToInt32(minTextBox.Text), Convert.ToInt32(maxTextBox.Text));
                
                if (inHouseRadioButton.Checked)
                {
                    //create a temporary InHouse part object
                    InHouse tempInHouse = new InHouse(Convert.ToInt32(partIDTextBox.Text),
                        nameTextBox.Text,
                        Convert.ToDecimal(priceTextBox.Text),
                        Convert.ToInt32(inventoryTextBox.Text),
                        Convert.ToInt32(minTextBox.Text),
                        Convert.ToInt32(maxTextBox.Text),
                        Convert.ToInt32(companyNameMachineIDTextBox.Text));
                    Inventory.addPart(tempInHouse);
                    
                    this.Close();
                }
                else
                {
                    //create a temporary Outsourced part object
                    Outsourced tempOutSourced = new Outsourced(Convert.ToInt32(partIDTextBox.Text),
                        nameTextBox.Text,
                        Convert.ToDecimal(priceTextBox.Text),
                        Convert.ToInt32(inventoryTextBox.Text),
                        Convert.ToInt32(minTextBox.Text),
                        Convert.ToInt32(maxTextBox.Text),
                        companyNameMachineIDTextBox.Text);
                    Inventory.addPart(tempOutSourced);
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                ErrorMessageForm errorMessageForm = new ErrorMessageForm(exception.Message);
                errorMessageForm.Show();
                
            }
        }

        private void AddPartScreen_Load(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && inventoryTextBox.Text != "" && priceTextBox.Text != "" && maxTextBox.Text != "" && minTextBox.Text!= "" && companyNameMachineIDTextBox.Text != "")
            {
                saveButton.Enabled = true;
            }
        }

        private void inventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && inventoryTextBox.Text != "" && priceTextBox.Text != "" && maxTextBox.Text != "" && minTextBox.Text != "" && companyNameMachineIDTextBox.Text != "")
            {
                saveButton.Enabled = true;
            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && inventoryTextBox.Text != "" && priceTextBox.Text != "" && maxTextBox.Text != "" && minTextBox.Text != "" && companyNameMachineIDTextBox.Text != "")
            {
                saveButton.Enabled = true;
            }
        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && inventoryTextBox.Text != "" && priceTextBox.Text != "" && maxTextBox.Text != "" && minTextBox.Text != "" && companyNameMachineIDTextBox.Text != "")
            {
                saveButton.Enabled = true;
            }
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && inventoryTextBox.Text != "" && priceTextBox.Text != "" && maxTextBox.Text != "" && minTextBox.Text != "" && companyNameMachineIDTextBox.Text != "")
            {
                saveButton.Enabled = true;
            }
        }

        private void companyNameMachineIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && inventoryTextBox.Text != "" && priceTextBox.Text != "" && maxTextBox.Text != "" && minTextBox.Text != "" && companyNameMachineIDTextBox.Text != "")
            {
                saveButton.Enabled = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
