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
    public partial class ModifyPartScreen : Form
    {
        
        public ModifyPartScreen(Part part)
        {
            InitializeComponent();

            iDTextBox.Text = part.PartID.ToString();
            nameTextBox.Text = part.Name;
            inventoryTextBox.Text = part.InStock.ToString();
            priceTextBox.Text = part.Price.ToString();
            minTextBox.Text = part.Min.ToString();
            maxTextBox.Text = part.Max.ToString();

            if (part is InHouse)
            {
                inHouseRadioButton.Checked = true;
                InHouse tempInHouse = part as InHouse;
                companyNameMachineTextBox.Text = tempInHouse.MachineID.ToString();
            }
            else
            {
                outSourcedRadioButton.Checked = true;
                Outsourced tempOutsourced = part as Outsourced;
                companyNameMachineTextBox.Text = tempOutsourced.CompanyName;
            }
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            companyNameLabel.Hide();
            machineIDLabel.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            machineIDLabel.Hide();
            companyNameLabel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
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
                    if (!Int32.TryParse(companyNameMachineTextBox.Text, out tempInt))
                    {
                        throw new Exception("For inhouse parts, Machine ID must contain a numeric value.");
                    }

                }
                ValidateMinVsMax(Convert.ToInt32(minTextBox.Text), Convert.ToInt32(maxTextBox.Text));
                ValidateInventoryBetweenMinMax(Convert.ToInt32(inventoryTextBox.Text), Convert.ToInt32(minTextBox.Text), Convert.ToInt32(maxTextBox.Text));
                if (inHouseRadioButton.Checked)
                {
                    //create a temporary InHouse part object
                    InHouse tempInHouse = new InHouse(Convert.ToInt32(iDTextBox.Text), nameTextBox.Text, Convert.ToDecimal(priceTextBox.Text), Convert.ToInt32(inventoryTextBox.Text), Convert.ToInt32(minTextBox.Text), Convert.ToInt32(maxTextBox.Text), Convert.ToInt32(companyNameMachineTextBox.Text));
                    //update the part in Inventory.AllParts
                    Inventory.updatePart(Convert.ToInt32(iDTextBox.Text), tempInHouse);
                    this.Close();
                }
                else
                {
                    //create a temporary Outsourced part object
                    Outsourced tempOutSourced = new Outsourced(Convert.ToInt32(iDTextBox.Text), nameTextBox.Text, Convert.ToDecimal(priceTextBox.Text), Convert.ToInt32(inventoryTextBox.Text), Convert.ToInt32(minTextBox.Text), Convert.ToInt32(maxTextBox.Text), companyNameMachineTextBox.Text);
                    //update the part in Inventory.AllParts
                    Inventory.updatePart(Convert.ToInt32(iDTextBox.Text), tempOutSourced);
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                ErrorMessageForm errorMessageForm = new ErrorMessageForm(exception.Message);
                errorMessageForm.Show();

            }
        }

        private void ModifyPartScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
