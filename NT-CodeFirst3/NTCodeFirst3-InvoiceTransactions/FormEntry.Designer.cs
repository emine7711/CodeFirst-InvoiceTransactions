namespace NTCodeFirst3_InvoiceTransactions
{
    partial class FormEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntry));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.supportTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countyDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceViewEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportTablesToolStripMenuItem,
            this.invoiceTransactionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // supportTablesToolStripMenuItem
            // 
            this.supportTablesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.supportTablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerDefinitionsToolStripMenuItem,
            this.cityDefinitionsToolStripMenuItem,
            this.countyDefinitionsToolStripMenuItem,
            this.productDefinitionsToolStripMenuItem,
            this.unitDefinitionsToolStripMenuItem});
            this.supportTablesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supportTablesToolStripMenuItem.Name = "supportTablesToolStripMenuItem";
            this.supportTablesToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.supportTablesToolStripMenuItem.Text = "Support Tables";
            // 
            // customerDefinitionsToolStripMenuItem
            // 
            this.customerDefinitionsToolStripMenuItem.Name = "customerDefinitionsToolStripMenuItem";
            this.customerDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.customerDefinitionsToolStripMenuItem.Text = "Customer Definitions";
            this.customerDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.customerDefinitionsToolStripMenuItem_Click);
            // 
            // cityDefinitionsToolStripMenuItem
            // 
            this.cityDefinitionsToolStripMenuItem.Name = "cityDefinitionsToolStripMenuItem";
            this.cityDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cityDefinitionsToolStripMenuItem.Text = "City Definitions";
            this.cityDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.cityDefinitionsToolStripMenuItem_Click);
            // 
            // countyDefinitionsToolStripMenuItem
            // 
            this.countyDefinitionsToolStripMenuItem.Name = "countyDefinitionsToolStripMenuItem";
            this.countyDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.countyDefinitionsToolStripMenuItem.Text = "County Definitions";
            this.countyDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.countyDefinitionsToolStripMenuItem_Click);
            // 
            // productDefinitionsToolStripMenuItem
            // 
            this.productDefinitionsToolStripMenuItem.Name = "productDefinitionsToolStripMenuItem";
            this.productDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.productDefinitionsToolStripMenuItem.Text = "Product Definitions";
            this.productDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.productDefinitionsToolStripMenuItem_Click);
            // 
            // unitDefinitionsToolStripMenuItem
            // 
            this.unitDefinitionsToolStripMenuItem.Name = "unitDefinitionsToolStripMenuItem";
            this.unitDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.unitDefinitionsToolStripMenuItem.Text = "Unit Definitions";
            this.unitDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.unitDefinitionsToolStripMenuItem_Click);
            // 
            // invoiceTransactionsToolStripMenuItem
            // 
            this.invoiceTransactionsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.invoiceTransactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceViewEditToolStripMenuItem,
            this.createNewInvoiceToolStripMenuItem});
            this.invoiceTransactionsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceTransactionsToolStripMenuItem.Name = "invoiceTransactionsToolStripMenuItem";
            this.invoiceTransactionsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.invoiceTransactionsToolStripMenuItem.Text = "Invoice Transactions";
            // 
            // invoiceViewEditToolStripMenuItem
            // 
            this.invoiceViewEditToolStripMenuItem.Name = "invoiceViewEditToolStripMenuItem";
            this.invoiceViewEditToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.invoiceViewEditToolStripMenuItem.Text = "View Invoice";
            this.invoiceViewEditToolStripMenuItem.Click += new System.EventHandler(this.invoiceViewEditToolStripMenuItem_Click);
            // 
            // createNewInvoiceToolStripMenuItem
            // 
            this.createNewInvoiceToolStripMenuItem.Name = "createNewInvoiceToolStripMenuItem";
            this.createNewInvoiceToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.createNewInvoiceToolStripMenuItem.Text = "Create/Edit Invoice";
            this.createNewInvoiceToolStripMenuItem.Click += new System.EventHandler(this.createNewInvoiceToolStripMenuItem_Click);
            // 
            // FormEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(662, 435);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEntry";
            this.Text = "FormEntry";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supportTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countyDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceViewEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewInvoiceToolStripMenuItem;
    }
}