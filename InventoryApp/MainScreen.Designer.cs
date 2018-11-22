namespace InventoryApp
{
    partial class MainScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainExit = new System.Windows.Forms.Button();
            this.partsSearchText = new System.Windows.Forms.TextBox();
            this.partsSearch = new System.Windows.Forms.Button();
            this.partsControls = new System.Windows.Forms.GroupBox();
            this.mainParts = new System.Windows.Forms.DataGridView();
            this.partsAdd = new System.Windows.Forms.Button();
            this.partsDelete = new System.Windows.Forms.Button();
            this.partsModify = new System.Windows.Forms.Button();
            this.productsControls = new System.Windows.Forms.GroupBox();
            this.mainProducts = new System.Windows.Forms.DataGridView();
            this.productsSearchText = new System.Windows.Forms.TextBox();
            this.productsSearchButton = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.modifyProduct = new System.Windows.Forms.Button();
            this.partsControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainParts)).BeginInit();
            this.productsControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // mainExit
            // 
            this.mainExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mainExit.Location = new System.Drawing.Point(950, 456);
            this.mainExit.Name = "mainExit";
            this.mainExit.Size = new System.Drawing.Size(106, 39);
            this.mainExit.TabIndex = 8;
            this.mainExit.Text = "Exit";
            this.mainExit.UseVisualStyleBackColor = true;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // partsSearchText
            // 
            this.partsSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partsSearchText.Location = new System.Drawing.Point(19, 35);
            this.partsSearchText.Name = "partsSearchText";
            this.partsSearchText.Size = new System.Drawing.Size(352, 23);
            this.partsSearchText.TabIndex = 9;
            // 
            // partsSearch
            // 
            this.partsSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.partsSearch.Location = new System.Drawing.Point(377, 34);
            this.partsSearch.Name = "partsSearch";
            this.partsSearch.Size = new System.Drawing.Size(87, 24);
            this.partsSearch.TabIndex = 3;
            this.partsSearch.Text = "Search";
            this.partsSearch.UseVisualStyleBackColor = true;
            // 
            // partsControls
            // 
            this.partsControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.partsControls.Controls.Add(this.mainParts);
            this.partsControls.Controls.Add(this.partsSearchText);
            this.partsControls.Controls.Add(this.partsSearch);
            this.partsControls.Controls.Add(this.partsAdd);
            this.partsControls.Controls.Add(this.partsDelete);
            this.partsControls.Controls.Add(this.partsModify);
            this.partsControls.Location = new System.Drawing.Point(12, 12);
            this.partsControls.Name = "partsControls";
            this.partsControls.Size = new System.Drawing.Size(486, 409);
            this.partsControls.TabIndex = 15;
            this.partsControls.TabStop = false;
            this.partsControls.Text = "Parts";
            // 
            // mainParts
            // 
            this.mainParts.AllowUserToAddRows = false;
            this.mainParts.AllowUserToDeleteRows = false;
            this.mainParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mainParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainParts.Location = new System.Drawing.Point(19, 65);
            this.mainParts.Name = "mainParts";
            this.mainParts.ReadOnly = true;
            this.mainParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainParts.Size = new System.Drawing.Size(445, 271);
            this.mainParts.TabIndex = 10;
            this.mainParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainParts_CellContentClick);
            // 
            // partsAdd
            // 
            this.partsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.partsAdd.Location = new System.Drawing.Point(19, 360);
            this.partsAdd.Name = "partsAdd";
            this.partsAdd.Size = new System.Drawing.Size(105, 43);
            this.partsAdd.TabIndex = 0;
            this.partsAdd.Text = "Add";
            this.partsAdd.UseVisualStyleBackColor = true;
            this.partsAdd.Click += new System.EventHandler(this.partsAdd_Click);
            // 
            // partsDelete
            // 
            this.partsDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.partsDelete.Location = new System.Drawing.Point(361, 360);
            this.partsDelete.Name = "partsDelete";
            this.partsDelete.Size = new System.Drawing.Size(105, 43);
            this.partsDelete.TabIndex = 2;
            this.partsDelete.Text = "Delete";
            this.partsDelete.UseVisualStyleBackColor = true;
            // 
            // partsModify
            // 
            this.partsModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.partsModify.Location = new System.Drawing.Point(191, 360);
            this.partsModify.Name = "partsModify";
            this.partsModify.Size = new System.Drawing.Size(105, 43);
            this.partsModify.TabIndex = 1;
            this.partsModify.Text = "Modify";
            this.partsModify.UseVisualStyleBackColor = true;
            this.partsModify.Click += new System.EventHandler(this.partsModify_Click);
            // 
            // productsControls
            // 
            this.productsControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.productsControls.Controls.Add(this.mainProducts);
            this.productsControls.Controls.Add(this.productsSearchText);
            this.productsControls.Controls.Add(this.productsSearchButton);
            this.productsControls.Controls.Add(this.addProduct);
            this.productsControls.Controls.Add(this.deleteProduct);
            this.productsControls.Controls.Add(this.modifyProduct);
            this.productsControls.Location = new System.Drawing.Point(570, 12);
            this.productsControls.Name = "productsControls";
            this.productsControls.Size = new System.Drawing.Size(486, 409);
            this.productsControls.TabIndex = 16;
            this.productsControls.TabStop = false;
            this.productsControls.Text = "Products";
            // 
            // mainProducts
            // 
            this.mainProducts.AllowUserToResizeColumns = false;
            this.mainProducts.AllowUserToResizeRows = false;
            this.mainProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.mainProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mainProducts.Location = new System.Drawing.Point(19, 64);
            this.mainProducts.MultiSelect = false;
            this.mainProducts.Name = "mainProducts";
            this.mainProducts.ReadOnly = true;
            this.mainProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainProducts.Size = new System.Drawing.Size(447, 272);
            this.mainProducts.TabIndex = 10;
            // 
            // productsSearchText
            // 
            this.productsSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productsSearchText.Location = new System.Drawing.Point(19, 35);
            this.productsSearchText.Name = "productsSearchText";
            this.productsSearchText.Size = new System.Drawing.Size(352, 23);
            this.productsSearchText.TabIndex = 9;
            // 
            // productsSearchButton
            // 
            this.productsSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.productsSearchButton.Location = new System.Drawing.Point(377, 34);
            this.productsSearchButton.Name = "productsSearchButton";
            this.productsSearchButton.Size = new System.Drawing.Size(87, 24);
            this.productsSearchButton.TabIndex = 3;
            this.productsSearchButton.Text = "Search";
            this.productsSearchButton.UseVisualStyleBackColor = true;
            // 
            // addProduct
            // 
            this.addProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addProduct.Location = new System.Drawing.Point(19, 360);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(105, 43);
            this.addProduct.TabIndex = 0;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProduct.Location = new System.Drawing.Point(361, 360);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(105, 43);
            this.deleteProduct.TabIndex = 2;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            // 
            // modifyProduct
            // 
            this.modifyProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.modifyProduct.Location = new System.Drawing.Point(191, 360);
            this.modifyProduct.Name = "modifyProduct";
            this.modifyProduct.Size = new System.Drawing.Size(105, 43);
            this.modifyProduct.TabIndex = 1;
            this.modifyProduct.Text = "Modify";
            this.modifyProduct.UseVisualStyleBackColor = true;
            this.modifyProduct.Click += new System.EventHandler(this.modifyProduct_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 509);
            this.Controls.Add(this.productsControls);
            this.Controls.Add(this.partsControls);
            this.Controls.Add(this.mainExit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainScreen";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.partsControls.ResumeLayout(false);
            this.partsControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainParts)).EndInit();
            this.productsControls.ResumeLayout(false);
            this.productsControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button mainExit;
        private System.Windows.Forms.TextBox partsSearchText;
        private System.Windows.Forms.Button partsSearch;
        private System.Windows.Forms.GroupBox partsControls;
        private System.Windows.Forms.Button partsAdd;
        private System.Windows.Forms.Button partsDelete;
        private System.Windows.Forms.Button partsModify;
        private System.Windows.Forms.GroupBox productsControls;
        private System.Windows.Forms.DataGridView mainProducts;
        private System.Windows.Forms.TextBox productsSearchText;
        private System.Windows.Forms.Button productsSearchButton;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button modifyProduct;
        private System.Windows.Forms.DataGridView mainParts;
    }
}

