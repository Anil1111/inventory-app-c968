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

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
