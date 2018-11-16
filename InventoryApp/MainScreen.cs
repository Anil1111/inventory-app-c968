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
            Inventory inv = new Inventory();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
        }

        private void partsAdd_Click(object sender, EventArgs e)
        {
            PartForm newPart = new PartForm();
            newPart.ShowDialog();
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void partsModify_Click(object sender, EventArgs e)
        {
            PartForm modifyPart = new PartForm();
            modifyPart.partGroupBox.Text = "Modify Part";
            modifyPart.ShowDialog();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            ProductForm newProduct = new ProductForm();
            newProduct.ShowDialog();
        }

        private void modifyProduct_Click(object sender, EventArgs e)
        {
            ProductForm modifyProduct = new ProductForm();
            modifyProduct.ShowDialog();
        }
    }
}
