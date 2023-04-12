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
    public partial class MainScreen : Form
    {
        
        public MainScreen()
        {
            InitializeComponent();
            dgvParts.DataSource = Inventory.AllParts;
            dgvProducts.DataSource = Inventory.Products;
            
        }


        private void deletePartButton_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteVerificationBox deleteVerificationBox = new DeleteVerificationBox();
                deleteVerificationBox.ShowDialog();
                if (deleteVerificationBox.deleteVerified == true && Inventory.AllParts.Count() > 0)
                {

                    Inventory.deletePart(dgvParts.CurrentRow.DataBoundItem as Part);

                }
                deleteVerificationBox.Close();
            }
            catch (Exception exception)
            {
                ErrorMessageForm errorMessageForm = new ErrorMessageForm(exception.Message);
                errorMessageForm.Show();

            }
        }    

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteVerificationBox deleteVerificationBox = new DeleteVerificationBox();
                deleteVerificationBox.ShowDialog();
                if (deleteVerificationBox.deleteVerified == true && Inventory.Products.Count() > 0)
                {
                    Product tempProduct = dgvProducts.CurrentRow.DataBoundItem as Product;
                    if(tempProduct.AssociatedParts.Count() > 0)
                    {
                        throw new Exception(" Unable to delete product. \x0A Please remove associated parts and try again. ");
                        
                    }
                    else
                    {
                        Inventory.removeProduct(tempProduct.ProductID);
                    }

                }
                
                deleteVerificationBox.Close();
            }
            catch (Exception exception)
            {
                ErrorMessageForm errorMessageForm = new ErrorMessageForm(exception.Message);
                errorMessageForm.Show();

            }
            
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            //initially disables modify and delete buttons
            modifyPartButton.Enabled = false;
            modifyProductButton.Enabled = false;
            deletePartButton.Enabled = false;
            deleteProductButton.Enabled = false;

        }

        private void modifyPartButton_Click(object sender, EventArgs e)
        {
            if(Inventory.AllParts.Count > 0)
            {
                ModifyPartScreen modifyPartScreen1 = new ModifyPartScreen(dgvParts.CurrentRow.DataBoundItem as Part);

                modifyPartScreen1.ShowDialog();
                dgvParts.Refresh();
            }
            
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if(Inventory.Products.Count > 0)
            {
                ModifyProductScreen modifyProductScreen1 = new ModifyProductScreen(dgvProducts.CurrentRow.DataBoundItem as Product);
                modifyProductScreen1.ShowDialog();
                dgvProducts.Refresh();
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            AddPartScreen addPartScreen1 = new AddPartScreen();
            addPartScreen1.ShowDialog();
            dgvParts.Refresh();
            modifyPartButton.Enabled = true;
            deletePartButton.Enabled = true;
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProductScreen addProductScreen1 = new AddProductScreen();
            addProductScreen1.ShowDialog();
            dgvProducts.Refresh();
            modifyProductButton.Enabled = true;
            deleteProductButton.Enabled = true;
        }

        private void partSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if(partSearchTextBox.Text != "")
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

        private void partSearchButton_Click(object sender, EventArgs e)
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

        private void productSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (productSearchTextBox.Text != "")
            {
                BindingList<Product> productSearchResultsList = new BindingList<Product>();
                foreach (Product item in Inventory.Products)
                {
                    if (item.Name.Contains(productSearchTextBox.Text) || item.ProductID.ToString().Contains(productSearchTextBox.Text))
                    {
                        productSearchResultsList.Add(item);
                    }
                }
                dgvProducts.DataSource = productSearchResultsList;
                dgvProducts.Refresh();
            }
            else
            {
                dgvProducts.DataSource = Inventory.Products;
                dgvProducts.Refresh();
            }
        }
    }
}
