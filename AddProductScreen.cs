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
    public partial class AddProductScreen : Form
    {
        public BindingList<Part> tempListOfParts;
        
        public AddProductScreen()
        {
            InitializeComponent();
            Random random = new Random();
            productIDTextBox.Text = Convert.ToString(random.Next(1000, 9999));
            tempListOfParts = new BindingList<Part>();
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

        private void AddProductScreen_Load(object sender, EventArgs e)
        {
            dgvParts.DataSource = Inventory.AllParts;
            dgvProductParts.DataSource = tempListOfParts;
            
            saveProductButton.Enabled = false;
        }

        private void saveProductButton_Click(object sender, EventArgs e)
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
                
                ValidateMinVsMax(Convert.ToInt32(minTextBox.Text), Convert.ToInt32(maxTextBox.Text));
                ValidateInventoryBetweenMinMax(Convert.ToInt32(inventoryTextBox.Text), Convert.ToInt32(minTextBox.Text), Convert.ToInt32(maxTextBox.Text));

                Product tempProduct = new Product(tempListOfParts,
                    Convert.ToInt32(productIDTextBox.Text),
                    nameTextBox.Text, Convert.ToDecimal(priceTextBox.Text),
                    Convert.ToInt32(inventoryTextBox.Text),
                    Convert.ToInt32(minTextBox.Text),
                    Convert.ToInt32(maxTextBox.Text));

                Inventory.addProduct(tempProduct);
                this.Close();
            }
            catch (Exception exception)
            {
                ErrorMessageForm errorMessageForm = new ErrorMessageForm(exception.Message);
                errorMessageForm.Show();

            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && inventoryTextBox.Text != "" && priceTextBox.Text != "" && maxTextBox.Text != "" && minTextBox.Text != "")
            {
                saveProductButton.Enabled = true;
            }
        }

        private void inventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && inventoryTextBox.Text != "" && priceTextBox.Text != "" && maxTextBox.Text != "" && minTextBox.Text != "")
            {
                saveProductButton.Enabled = true;
            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && inventoryTextBox.Text != "" && priceTextBox.Text != "" && maxTextBox.Text != "" && minTextBox.Text != "")
            {
                saveProductButton.Enabled = true;
            }
        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && inventoryTextBox.Text != "" && priceTextBox.Text != "" && maxTextBox.Text != "" && minTextBox.Text != "")
            {
                saveProductButton.Enabled = true;
            }
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && inventoryTextBox.Text != "" && priceTextBox.Text != "" && maxTextBox.Text != "" && minTextBox.Text != "")
            {
                saveProductButton.Enabled = true;
            }
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            if(Inventory.AllParts.Count() > 0)
            {
                tempListOfParts.Add(dgvParts.CurrentRow.DataBoundItem as Part);
            }
        }

        private void removePartButton_Click(object sender, EventArgs e)
        {
            if (tempListOfParts.Count() > 0)
            {
                tempListOfParts.Remove(dgvProductParts.CurrentRow.DataBoundItem as Part);
            }
                
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void partSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (partSearchTextBox.Text != "")
            {
                BindingList<Part> partSearchResultsList = new BindingList<Part>();
                foreach (Part item in Inventory.AllParts)
                {
                    if (item.Name.Contains(partSearchTextBox.Text) || item.PartID.ToString().Contains(partSearchTextBox.Text))
                    {
                        partSearchResultsList.Add(item);
                    }
                }
                dgvParts.DataSource = partSearchResultsList;
                dgvParts.Refresh();
            }
            else
            {
                dgvParts.DataSource = Inventory.AllParts;
                dgvParts.Refresh();
            }
        }

        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            if (partSearchTextBox.Text != "")
            {
                BindingList<Part> partSearchResultsList = new BindingList<Part>();
                foreach (Part item in Inventory.AllParts)
                {
                    if (item.Name.Contains(partSearchTextBox.Text) || item.PartID.ToString().Contains(partSearchTextBox.Text))
                    {
                        partSearchResultsList.Add(item);
                    }
                }
                dgvParts.DataSource = partSearchResultsList;
                dgvParts.Refresh();
            }
            else
            {
                dgvParts.DataSource = Inventory.AllParts;
                dgvParts.Refresh();
            }
        }
    }
}
