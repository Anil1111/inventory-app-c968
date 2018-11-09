using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void partAdd_Click(object sender, EventArgs e) => MessageBox.Show("Add in the Parts section was clicked");

        private void partsModify_Click(object sender, EventArgs e)
        {

        }

        private void partsDelete_Click(object sender, EventArgs e)
        {

        }

        private void mainExit_Click(object sender, EventArgs e)
        {

        }

        private void partsSearch_Click(object sender, EventArgs e)
        {

        }

        private void partsSearchText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
