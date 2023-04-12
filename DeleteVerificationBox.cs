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
    public partial class DeleteVerificationBox : Form
    {
        public bool deleteVerified = false;
        public DeleteVerificationBox()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            deleteVerified = true;
            this.Hide();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            deleteVerified = false;
            this.Hide();
        }

        private void DeleteVerificationBox_Load(object sender, EventArgs e)
        {

        }
    }
}
