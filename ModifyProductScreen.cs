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
    public partial class ModifyProductScreen : Form
    {
        private BindingList<Part> tempPartsList;
        public ModifyProductScreen(Product product)
        {
            InitializeComponent();
            tempPartsList = product.AssociatedParts;
            dgvProductParts.DataSource = product.AssociatedParts;
            productIDTextBox.Text = product.ProductID.ToString();
            productNameTextBox.Text = product.Name;
            productInventoryTextBox.Text = product.InStock.ToString();
            productPriceTextBox.Text = product.Price.ToString();
            productMinTextBox.Text = product.Min.ToString();
            productMaxTextBox.Text = product.Max.ToString();

            
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            try
            {
                int tempInt = new int();
                double tempDouble = new double();
                if (!(Int32.TryParse(productMinTextBox.Text, out tempInt)) || !(Int32.TryParse(productMaxTextBox.Text, out tempInt)) || !(Int32.TryParse(productInventoryTextBox.Text, out tempInt)) || !(Double.TryParse(productPriceTextBox.Text, out tempDouble)))
                {
                    throw new Exception("Min, Max, Inventory, and Price must contain only numeric values.");

                }
                ValidateMinVsMax(Convert.ToInt32(productMinTextBox.Text),
                    Convert.ToInt32(productMaxTextBox.Text));
                ValidateInventoryBetweenMinMax(Convert.ToInt32(productInventoryTextBox.Text),
                    Convert.ToInt32(productMinTextBox.Text),
                    Convert.ToInt32(productMaxTextBox.Text));

                Product tempProduct = new Product(tempPartsList,
                    Convert.ToInt32(productIDTextBox.Text),
                    productNameTextBox.Text, Convert.ToDecimal(productPriceTextBox.Text),
                    Convert.ToInt32(productInventoryTextBox.Text),
                    Convert.ToInt32(productMinTextBox.Text),
                    Convert.ToInt32(productMaxTextBox.Text));

                Inventory.updateProduct(tempProduct.ProductID, tempProduct);
                
                this.Close();

            }
            catch (Exception exception)
            {
                ErrorMessageForm errorMessageForm = new ErrorMessageForm(exception.Message);
                errorMessageForm.Show();

            }
        }

        private void ModifyProductScreen_Load(object sender, EventArgs e)
        {
            dgvParts.DataSource = Inventory.AllParts;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            if(Inventory.AllParts.Count() > 0)
            {
                tempPartsList.Add(dgvParts.CurrentRow.DataBoundItem as Part);
            }
            
        }

        private void removePartButton_Click(object sender, EventArgs e)
        {
            if(tempPartsList.Count() > 0)
            {
                tempPartsList.Remove(dgvProductParts.CurrentRow.DataBoundItem as Part);

            }
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
