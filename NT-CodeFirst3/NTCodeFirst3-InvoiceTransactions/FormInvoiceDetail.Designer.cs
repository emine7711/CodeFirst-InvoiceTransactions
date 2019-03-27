namespace NTCodeFirst3_InvoiceTransactions
{
    partial class FormInvoiceDetail
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtInvoiceAmount = new System.Windows.Forms.TextBox();
            this.dtpPayment = new System.Windows.Forms.DateTimePicker();
            this.dtpInvoice = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDelivery = new System.Windows.Forms.TextBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgInvoiceD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txtWithVAT = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnInsertID = new System.Windows.Forms.Button();
            this.btnDeleteID = new System.Windows.Forms.Button();
            this.btnUpdateID = new System.Windows.Forms.Button();
            this.btnMDeleteID = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.btnInsertPro = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoiceD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(593, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 14);
            this.label5.TabIndex = 51;
            this.label5.Text = "Delivery Note:";
            // 
            // txtInvoiceAmount
            // 
            this.txtInvoiceAmount.Location = new System.Drawing.Point(709, 38);
            this.txtInvoiceAmount.Name = "txtInvoiceAmount";
            this.txtInvoiceAmount.ReadOnly = true;
            this.txtInvoiceAmount.Size = new System.Drawing.Size(102, 24);
            this.txtInvoiceAmount.TabIndex = 50;
            // 
            // dtpPayment
            // 
            this.dtpPayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPayment.Location = new System.Drawing.Point(293, 38);
            this.dtpPayment.Name = "dtpPayment";
            this.dtpPayment.Size = new System.Drawing.Size(104, 24);
            this.dtpPayment.TabIndex = 49;
            // 
            // dtpInvoice
            // 
            this.dtpInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInvoice.Location = new System.Drawing.Point(163, 38);
            this.dtpInvoice.Name = "dtpInvoice";
            this.dtpInvoice.Size = new System.Drawing.Size(100, 24);
            this.dtpInvoice.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 14);
            this.label4.TabIndex = 47;
            this.label4.Text = "Payment Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 14);
            this.label3.TabIndex = 46;
            this.label3.Text = "Customers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(706, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 14);
            this.label2.TabIndex = 45;
            this.label2.Text = "Invoice Total Amount:";
            // 
            // txtDelivery
            // 
            this.txtDelivery.Location = new System.Drawing.Point(576, 38);
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.Size = new System.Drawing.Size(107, 24);
            this.txtDelivery.TabIndex = 44;
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(424, 37);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(123, 23);
            this.cbCustomer.TabIndex = 43;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Navy;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(536, 86);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 36);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Navy;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(688, 86);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 36);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgInvoiceD
            // 
            this.dgInvoiceD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvoiceD.Location = new System.Drawing.Point(5, 19);
            this.dgInvoiceD.Name = "dgInvoiceD";
            this.dgInvoiceD.Size = new System.Drawing.Size(472, 150);
            this.dgInvoiceD.TabIndex = 39;
            this.dgInvoiceD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInvoiceD_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 37;
            this.label1.Text = "Invoice Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnEnter);
            this.groupBox1.Controls.Add(this.txtInvoiceID);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtpInvoice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtInvoiceAmount);
            this.groupBox1.Controls.Add(this.dtpPayment);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbCustomer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDelivery);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 150);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "InvoiceHeader";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Navy;
            this.btnEnter.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(31, 86);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 36);
            this.btnEnter.TabIndex = 55;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Location = new System.Drawing.Point(31, 38);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(100, 24);
            this.txtInvoiceID.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(48, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 14);
            this.label12.TabIndex = 53;
            this.label12.Text = "InvoiceID:";
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(609, 19);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(110, 23);
            this.cbProduct.TabIndex = 52;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(609, 45);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(110, 24);
            this.txtQuantity.TabIndex = 52;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(609, 95);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(110, 24);
            this.txtUnitPrice.TabIndex = 53;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(609, 121);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(110, 24);
            this.txtVAT.TabIndex = 54;
            this.txtVAT.TextChanged += new System.EventHandler(this.txtVAT_TextChanged);
            // 
            // txtWithVAT
            // 
            this.txtWithVAT.Location = new System.Drawing.Point(609, 148);
            this.txtWithVAT.Name = "txtWithVAT";
            this.txtWithVAT.Size = new System.Drawing.Size(110, 24);
            this.txtWithVAT.TabIndex = 55;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(609, 175);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(110, 24);
            this.txtDescription.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(502, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 14);
            this.label6.TabIndex = 52;
            this.label6.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(502, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 14);
            this.label7.TabIndex = 53;
            this.label7.Text = "Unit Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(502, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 14);
            this.label8.TabIndex = 54;
            this.label8.Text = "VAT:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(502, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 55;
            this.label9.Text = "AmountWithVAT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(502, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 14);
            this.label10.TabIndex = 56;
            this.label10.Text = "Description:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(502, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 14);
            this.label11.TabIndex = 57;
            this.label11.Text = "Product:";
            // 
            // btnInsertID
            // 
            this.btnInsertID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsertID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertID.ForeColor = System.Drawing.Color.White;
            this.btnInsertID.Location = new System.Drawing.Point(643, 383);
            this.btnInsertID.Name = "btnInsertID";
            this.btnInsertID.Size = new System.Drawing.Size(88, 33);
            this.btnInsertID.TabIndex = 52;
            this.btnInsertID.Text = "Save Invoice";
            this.btnInsertID.UseVisualStyleBackColor = false;
            this.btnInsertID.Click += new System.EventHandler(this.btnInsertID_Click);
            // 
            // btnDeleteID
            // 
            this.btnDeleteID.BackColor = System.Drawing.Color.Navy;
            this.btnDeleteID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteID.ForeColor = System.Drawing.Color.White;
            this.btnDeleteID.Location = new System.Drawing.Point(746, 100);
            this.btnDeleteID.Name = "btnDeleteID";
            this.btnDeleteID.Size = new System.Drawing.Size(88, 33);
            this.btnDeleteID.TabIndex = 53;
            this.btnDeleteID.Text = "Delete";
            this.btnDeleteID.UseVisualStyleBackColor = false;
            this.btnDeleteID.Click += new System.EventHandler(this.btnDeleteID_Click);
            // 
            // btnUpdateID
            // 
            this.btnUpdateID.BackColor = System.Drawing.Color.Navy;
            this.btnUpdateID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateID.ForeColor = System.Drawing.Color.White;
            this.btnUpdateID.Location = new System.Drawing.Point(746, 58);
            this.btnUpdateID.Name = "btnUpdateID";
            this.btnUpdateID.Size = new System.Drawing.Size(88, 36);
            this.btnUpdateID.TabIndex = 54;
            this.btnUpdateID.Text = "Update";
            this.btnUpdateID.UseVisualStyleBackColor = false;
            this.btnUpdateID.Click += new System.EventHandler(this.btnUpdateID_Click);
            // 
            // btnMDeleteID
            // 
            this.btnMDeleteID.BackColor = System.Drawing.Color.Navy;
            this.btnMDeleteID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMDeleteID.ForeColor = System.Drawing.Color.White;
            this.btnMDeleteID.Location = new System.Drawing.Point(746, 139);
            this.btnMDeleteID.Name = "btnMDeleteID";
            this.btnMDeleteID.Size = new System.Drawing.Size(88, 30);
            this.btnMDeleteID.TabIndex = 55;
            this.btnMDeleteID.Text = "Multiple Delete";
            this.btnMDeleteID.UseVisualStyleBackColor = false;
            this.btnMDeleteID.Click += new System.EventHandler(this.btnMDeleteID_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cbUnit);
            this.groupBox2.Controls.Add(this.btnInsertPro);
            this.groupBox2.Controls.Add(this.dgInvoiceD);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbProduct);
            this.groupBox2.Controls.Add(this.btnUpdateID);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.btnDeleteID);
            this.groupBox2.Controls.Add(this.txtWithVAT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtVAT);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtUnitPrice);
            this.groupBox2.Controls.Add(this.btnMDeleteID);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 200);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "InvoiceDetail";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(502, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 14);
            this.label13.TabIndex = 59;
            this.label13.Text = "Unit:";
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(609, 71);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(110, 23);
            this.cbUnit.TabIndex = 58;
            // 
            // btnInsertPro
            // 
            this.btnInsertPro.BackColor = System.Drawing.Color.Navy;
            this.btnInsertPro.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertPro.ForeColor = System.Drawing.Color.White;
            this.btnInsertPro.Location = new System.Drawing.Point(746, 15);
            this.btnInsertPro.Name = "btnInsertPro";
            this.btnInsertPro.Size = new System.Drawing.Size(88, 33);
            this.btnInsertPro.TabIndex = 53;
            this.btnInsertPro.Text = "Insert";
            this.btnInsertPro.UseVisualStyleBackColor = false;
            this.btnInsertPro.Click += new System.EventHandler(this.btnInsertPro_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(753, 383);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 33);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormInvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(865, 428);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsertID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormInvoiceDetail";
            this.Text = "FormInvoiceDetail";
            this.Load += new System.EventHandler(this.FormInvoiceDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoiceD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInvoiceAmount;
        private System.Windows.Forms.DateTimePicker dtpPayment;
        private System.Windows.Forms.DateTimePicker dtpInvoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDelivery;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgInvoiceD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txtWithVAT;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnInsertID;
        private System.Windows.Forms.Button btnDeleteID;
        private System.Windows.Forms.Button btnUpdateID;
        private System.Windows.Forms.Button btnMDeleteID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Button btnInsertPro;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbUnit;
    }
}