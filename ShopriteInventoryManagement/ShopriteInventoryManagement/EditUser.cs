using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopriteInventoryManagement
{
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxName.Clear();
            textBoxPassword.Clear();
            textBoxPhone.Clear();
            textBoxID.Clear();
            textBoxConfirmPword.Clear();
        }
    }
}
