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
    public partial class ErrorMessageForm : Form
    {
        public ErrorMessageForm(string errorMessage)
        {
            InitializeComponent();
            errorMessageLabel.Text = errorMessage;
        }

        private void ErrorMessageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
