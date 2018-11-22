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
            Inventory.AddPart(new InHouse(1, "asdf", 1.00, 1, 1, 4, 1123));
            Inventory.AddPart(new InHouse(2, "asdf", 1.01, 1, 1, 4, 1124));
            Inventory.AddPart(new InHouse(3, "asdf", 1.02, 1, 1, 4, 1125));
            mainParts.DataSource = Inventory.allParts;
            mainParts.Columns["Max"].Visible = false;
            mainParts.Columns["Min"].Visible = false;
            mainParts.Columns["Price"].DisplayIndex = 3;
            mainParts.Columns["Price"].HeaderCell.Value = "Price/Cost per Unit";
            mainParts.Columns["PartID"].HeaderCell.Value = "Part ID";
            mainParts.Columns["InStock"].HeaderCell.Value = "Inventory Level";
            mainParts.Columns["Name"].HeaderCell.Value = "Part Name";
            mainParts.RowHeadersVisible = false;
            mainParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            Part rowData = Inventory.allParts[mainParts.SelectedRows[0].Index];
            PartForm modifyPart = new PartForm();
            modifyPart.partIDText.Text = rowData.PartID.ToString();
            modifyPart.partNameText.Text = rowData.Name.ToString();
            modifyPart.partInvText.Text = rowData.InStock.ToString();
            modifyPart.partPriceText.Text = rowData.Price.ToString();
            modifyPart.partMaxText.Text = rowData.Max.ToString();
            modifyPart.partMinText.Text = rowData.Min.ToString();
            //InHouse or Outsourced
            modifyPart.partMachineIdText.Text = rowData.GetMagicVar();

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

        private void mainParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
