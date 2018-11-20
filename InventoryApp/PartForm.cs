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
    public partial class PartForm : Form
    {
        private ErrorProvider errorProvider;
        private int errorCount;

        public PartForm()
        {
            InitializeComponent();
            this.errorProvider = new ErrorProvider();
        }

        // Validation
        private void partNameText_Validated(object sender, EventArgs e)
        {
            ValidateTextBox(partNameText, "This field is required");
        }

        private void partInvText_Validated(object sender, EventArgs e)
        {
            ValidateIntBox(partInvText, "This field is required, and only accepts numbers");
        }

        private void partPriceText_Validated(object sender, EventArgs e)
        {
            ValidateDoubleBox(partPriceText, "This field is required, and only accepts a decimal (1.00)");
        }

        private void partOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            this.partMachineIdLabel.Visible = false;
            this.partMachineIdText.Visible = false;
            this.partCompanyNameText.Visible = true;
            this.partCompanyNameLabel.Visible = true;
        }

        private void partInHouse_CheckedChanged(object sender, EventArgs e)
        {
            this.partMachineIdLabel.Visible = true;
            this.partMachineIdText.Visible = true;
            this.partCompanyNameText.Visible = false;
            this.partCompanyNameLabel.Visible = false;
        }

        private void partSave_Click(object sender, EventArgs e)
        {
            Part partToSave;
            int partID = Int32.Parse(this.partIDText.Text);
            double price = Double.Parse(this.partPriceText.Text);
            int inStock = Int32.Parse(this.partInvText.Text);
            int min = Int32.Parse(this.partMinText.Text);
            int max = Int32.Parse(this.partMaxText.Text);

            if (this.partInHouse.Checked)
            {
                int machineID = Int32.Parse(this.partMachineIdText.Text);

                partToSave = new InHouse(partID, this.partNameText.Text, price, inStock, min, max, machineID);
            }
            else
            {
                partToSave = new Outsourced(partID, this.partNameText.Text, price, inStock, min, max, this.partCompanyNameText.Text);
            }

            Inventory.AddPart(partToSave);
        }

        private void ValidateTextBox(Control control, string error)
        {
            if (control.Text == String.Empty)
            {
                this.errorCount++;
                DisplayError(control, error);
            }
            else
            {
                this.errorCount--;
                ResetError(control);
            }
        }

        private void ValidateIntBox(Control control, string error)
        {
            if ( control.Text == String.Empty || !Int32.TryParse(control.Text, out int result))
            {
                this.errorCount++;
                DisplayError(control, error);                
            }
            else
            {
                this.errorCount--;
                ResetError(control);
            }
        }

        private void ValidateDoubleBox(Control control, string error)
        {
            if (control.Text == String.Empty || !Double.TryParse(control.Text, out double result))
            {
                this.errorCount++;
                DisplayError(control, error);
            }
            else
            {
                this.errorCount--;
                ResetError(control);
            }
        }

        private void DisplayError(Control control, string error)
        {
            errorProvider.SetError(control, error);
            control.BackColor = Color.LightCoral;
        }

        private void ResetError(Control control)
        {
            errorProvider.SetError(control, String.Empty);
            control.BackColor = SystemColors.Window;
        }

        private bool ValidateForm()
        {
            ValidateTextBox(partNameText, "This field is required");
            ValidateIntBox(partInvText, "This field is required, and only accepts numbers");
            ValidateDoubleBox(partInvText, "This field is required, and only accepts a decimal (1.00)");

            return this.errorCount == 0;
        }
    }
}
