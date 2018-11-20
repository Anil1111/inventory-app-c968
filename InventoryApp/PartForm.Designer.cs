namespace InventoryApp
{
    partial class PartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.partGroupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.partInHouse = new System.Windows.Forms.RadioButton();
            this.partOutsourced = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.partMachineIdText = new System.Windows.Forms.TextBox();
            this.partMinText = new System.Windows.Forms.TextBox();
            this.partMaxText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.partPriceText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.partInvText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.partNameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.partIDText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.partMachineIdLabel = new System.Windows.Forms.Label();
            this.partCompanyNameLabel = new System.Windows.Forms.Label();
            this.partCompanyNameText = new System.Windows.Forms.TextBox();
            this.partCancel = new System.Windows.Forms.Button();
            this.partSave = new System.Windows.Forms.Button();
            this.partGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // partGroupBox
            // 
            this.partGroupBox.Controls.Add(this.panel2);
            this.partGroupBox.Controls.Add(this.panel1);
            this.partGroupBox.Location = new System.Drawing.Point(12, 12);
            this.partGroupBox.Name = "partGroupBox";
            this.partGroupBox.Size = new System.Drawing.Size(460, 415);
            this.partGroupBox.TabIndex = 0;
            this.partGroupBox.TabStop = false;
            this.partGroupBox.Text = "Add Part";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.partInHouse);
            this.panel2.Controls.Add(this.partOutsourced);
            this.panel2.Location = new System.Drawing.Point(16, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 27);
            this.panel2.TabIndex = 1;
            // 
            // partInHouse
            // 
            this.partInHouse.AutoSize = true;
            this.partInHouse.Checked = true;
            this.partInHouse.Location = new System.Drawing.Point(33, 4);
            this.partInHouse.Name = "partInHouse";
            this.partInHouse.Size = new System.Drawing.Size(74, 19);
            this.partInHouse.TabIndex = 1;
            this.partInHouse.TabStop = true;
            this.partInHouse.Text = "In-House";
            this.partInHouse.UseVisualStyleBackColor = true;
            this.partInHouse.CheckedChanged += new System.EventHandler(this.partInHouse_CheckedChanged);
            // 
            // partOutsourced
            // 
            this.partOutsourced.AutoSize = true;
            this.partOutsourced.Location = new System.Drawing.Point(281, 4);
            this.partOutsourced.Name = "partOutsourced";
            this.partOutsourced.Size = new System.Drawing.Size(87, 19);
            this.partOutsourced.TabIndex = 2;
            this.partOutsourced.Text = "Outsourced";
            this.partOutsourced.UseVisualStyleBackColor = true;
            this.partOutsourced.CheckedChanged += new System.EventHandler(this.partOutsourced_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.partMachineIdText);
            this.panel1.Controls.Add(this.partMinText);
            this.panel1.Controls.Add(this.partMaxText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.partPriceText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.partInvText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.partNameText);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.partIDText);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.partMachineIdLabel);
            this.panel1.Controls.Add(this.partCompanyNameLabel);
            this.panel1.Controls.Add(this.partCompanyNameText);
            this.panel1.Location = new System.Drawing.Point(16, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 330);
            this.panel1.TabIndex = 15;
            // 
            // partMachineIdText
            // 
            this.partMachineIdText.Location = new System.Drawing.Point(140, 282);
            this.partMachineIdText.Name = "partMachineIdText";
            this.partMachineIdText.Size = new System.Drawing.Size(100, 23);
            this.partMachineIdText.TabIndex = 17;
            // 
            // partMinText
            // 
            this.partMinText.Location = new System.Drawing.Point(292, 234);
            this.partMinText.Name = "partMinText";
            this.partMinText.Size = new System.Drawing.Size(100, 23);
            this.partMinText.TabIndex = 8;
            // 
            // partMaxText
            // 
            this.partMaxText.Location = new System.Drawing.Point(140, 234);
            this.partMaxText.Name = "partMaxText";
            this.partMaxText.Size = new System.Drawing.Size(100, 23);
            this.partMaxText.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // partPriceText
            // 
            this.partPriceText.Location = new System.Drawing.Point(140, 186);
            this.partPriceText.Name = "partPriceText";
            this.partPriceText.Size = new System.Drawing.Size(100, 23);
            this.partPriceText.TabIndex = 6;
            this.partPriceText.Validated += new System.EventHandler(this.partPriceText_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // partInvText
            // 
            this.partInvText.Location = new System.Drawing.Point(140, 131);
            this.partInvText.Name = "partInvText";
            this.partInvText.Size = new System.Drawing.Size(100, 23);
            this.partInvText.TabIndex = 5;
            this.partInvText.Validated += new System.EventHandler(this.partInvText_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inv";
            // 
            // partNameText
            // 
            this.partNameText.Location = new System.Drawing.Point(140, 79);
            this.partNameText.Name = "partNameText";
            this.partNameText.Size = new System.Drawing.Size(100, 23);
            this.partNameText.TabIndex = 4;
            this.partNameText.Validated += new System.EventHandler(this.partNameText_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price/Cost";
            // 
            // partIDText
            // 
            this.partIDText.Location = new System.Drawing.Point(140, 35);
            this.partIDText.Name = "partIDText";
            this.partIDText.Size = new System.Drawing.Size(100, 23);
            this.partIDText.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Min";
            // 
            // partMachineIdLabel
            // 
            this.partMachineIdLabel.AutoSize = true;
            this.partMachineIdLabel.Location = new System.Drawing.Point(32, 285);
            this.partMachineIdLabel.Name = "partMachineIdLabel";
            this.partMachineIdLabel.Size = new System.Drawing.Size(67, 15);
            this.partMachineIdLabel.TabIndex = 8;
            this.partMachineIdLabel.Text = "Machine ID";
            // 
            // partCompanyNameLabel
            // 
            this.partCompanyNameLabel.AutoSize = true;
            this.partCompanyNameLabel.Location = new System.Drawing.Point(32, 285);
            this.partCompanyNameLabel.Name = "partCompanyNameLabel";
            this.partCompanyNameLabel.Size = new System.Drawing.Size(94, 15);
            this.partCompanyNameLabel.TabIndex = 18;
            this.partCompanyNameLabel.Text = "Company Name";
            this.partCompanyNameLabel.Visible = false;
            // 
            // partCompanyNameText
            // 
            this.partCompanyNameText.Location = new System.Drawing.Point(140, 282);
            this.partCompanyNameText.Name = "partCompanyNameText";
            this.partCompanyNameText.Size = new System.Drawing.Size(100, 23);
            this.partCompanyNameText.TabIndex = 9;
            this.partCompanyNameText.Visible = false;
            // 
            // partCancel
            // 
            this.partCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.partCancel.Location = new System.Drawing.Point(28, 433);
            this.partCancel.Name = "partCancel";
            this.partCancel.Size = new System.Drawing.Size(83, 35);
            this.partCancel.TabIndex = 11;
            this.partCancel.Text = "Cancel";
            this.partCancel.UseVisualStyleBackColor = true;
            // 
            // partSave
            // 
            this.partSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.partSave.Location = new System.Drawing.Point(371, 433);
            this.partSave.Name = "partSave";
            this.partSave.Size = new System.Drawing.Size(86, 35);
            this.partSave.TabIndex = 10;
            this.partSave.Text = "Save";
            this.partSave.UseVisualStyleBackColor = true;
            this.partSave.Click += new System.EventHandler(this.partSave_Click);
            // 
            // PartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 490);
            this.Controls.Add(this.partGroupBox);
            this.Controls.Add(this.partCancel);
            this.Controls.Add(this.partSave);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PartForm";
            this.Text = "Add/Modify Part";
            this.partGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox partGroupBox;
        private System.Windows.Forms.RadioButton partOutsourced;
        private System.Windows.Forms.RadioButton partInHouse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label partMachineIdLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button partCancel;
        private System.Windows.Forms.Button partSave;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox partCompanyNameText;
        private System.Windows.Forms.Label partCompanyNameLabel;
        public System.Windows.Forms.TextBox partMachineIdText;
        public System.Windows.Forms.TextBox partMinText;
        public System.Windows.Forms.TextBox partMaxText;
        public System.Windows.Forms.TextBox partPriceText;
        public System.Windows.Forms.TextBox partInvText;
        public System.Windows.Forms.TextBox partNameText;
        public System.Windows.Forms.TextBox partIDText;
        private System.Windows.Forms.Panel panel2;
    }
}