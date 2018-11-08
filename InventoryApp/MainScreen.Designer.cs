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
            this.button9 = new System.Windows.Forms.Button();
            this.partsSearchText = new System.Windows.Forms.TextBox();
            this.partsSearch = new System.Windows.Forms.Button();
            this.partsTable = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.partsModify = new System.Windows.Forms.Button();
            this.partsDelete = new System.Windows.Forms.Button();
            this.partsAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Location = new System.Drawing.Point(712, 456);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(106, 39);
            this.button9.TabIndex = 8;
            this.button9.Text = "Exit";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // partsSearchText
            // 
            this.partsSearchText.Location = new System.Drawing.Point(114, 38);
            this.partsSearchText.Name = "partsSearchText";
            this.partsSearchText.Size = new System.Drawing.Size(249, 23);
            this.partsSearchText.TabIndex = 9;
            // 
            // partsSearch
            // 
            this.partsSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.partsSearch.Location = new System.Drawing.Point(19, 35);
            this.partsSearch.Name = "partsSearch";
            this.partsSearch.Size = new System.Drawing.Size(87, 27);
            this.partsSearch.TabIndex = 3;
            this.partsSearch.Text = "Search";
            this.partsSearch.UseVisualStyleBackColor = true;
            // 
            // partsTable
            // 
            this.partsTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.partsTable.ColumnCount = 4;
            this.partsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.partsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.partsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.partsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.partsTable.Location = new System.Drawing.Point(19, 73);
            this.partsTable.Name = "partsTable";
            this.partsTable.RowCount = 2;
            this.partsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.partsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.partsTable.Size = new System.Drawing.Size(344, 222);
            this.partsTable.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.partsSearchText);
            this.groupBox1.Controls.Add(this.partsSearch);
            this.groupBox1.Controls.Add(this.partsTable);
            this.groupBox1.Controls.Add(this.partsAdd);
            this.groupBox1.Controls.Add(this.partsDelete);
            this.groupBox1.Controls.Add(this.partsModify);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 365);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parts";
            // 
            // partsModify
            // 
            this.partsModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.partsModify.Location = new System.Drawing.Point(139, 316);
            this.partsModify.Name = "partsModify";
            this.partsModify.Size = new System.Drawing.Size(105, 43);
            this.partsModify.TabIndex = 1;
            this.partsModify.Text = "Modify";
            this.partsModify.UseVisualStyleBackColor = true;
            // 
            // partsDelete
            // 
            this.partsDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.partsDelete.Location = new System.Drawing.Point(258, 316);
            this.partsDelete.Name = "partsDelete";
            this.partsDelete.Size = new System.Drawing.Size(105, 43);
            this.partsDelete.TabIndex = 2;
            this.partsDelete.Text = "Delete";
            this.partsDelete.UseVisualStyleBackColor = true;
            // 
            // partsAdd
            // 
            this.partsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.partsAdd.Location = new System.Drawing.Point(19, 316);
            this.partsAdd.Name = "partsAdd";
            this.partsAdd.Size = new System.Drawing.Size(105, 43);
            this.partsAdd.TabIndex = 0;
            this.partsAdd.Text = "Add";
            this.partsAdd.UseVisualStyleBackColor = true;
            this.partsAdd.Click += new System.EventHandler(this.partAdd_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button9);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainScreen";
            this.Text = "Inventory Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox partsSearchText;
        private System.Windows.Forms.Button partsSearch;
        private System.Windows.Forms.TableLayoutPanel partsTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button partsAdd;
        private System.Windows.Forms.Button partsDelete;
        private System.Windows.Forms.Button partsModify;
    }
}

