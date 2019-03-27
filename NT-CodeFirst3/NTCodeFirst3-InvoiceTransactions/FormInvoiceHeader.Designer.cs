namespace NTCodeFirst3_InvoiceTransactions
{
    partial class FormInvoiceHeader
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDelivery = new System.Windows.Forms.TextBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.dgInvoiceH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInvoice = new System.Windows.Forms.DateTimePicker();
            this.dtpPayment = new System.Windows.Forms.DateTimePicker();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoiceH)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Payment Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Customers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Total Amount:";
            // 
            // txtDelivery
            // 
            this.txtDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelivery.Location = new System.Drawing.Point(128, 138);
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.Size = new System.Drawing.Size(140, 20);
            this.txtDelivery.TabIndex = 29;
            // 
            // cbCustomer
            // 
            this.cbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(128, 102);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(140, 21);
            this.cbCustomer.TabIndex = 28;
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged_1);
            // 
            // dgInvoiceH
            // 
            this.dgInvoiceH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInvoiceH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvoiceH.Location = new System.Drawing.Point(30, 234);
            this.dgInvoiceH.Name = "dgInvoiceH";
            this.dgInvoiceH.Size = new System.Drawing.Size(586, 150);
            this.dgInvoiceH.TabIndex = 23;
            this.dgInvoiceH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInvoiceH_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Invoice Date:";
            // 
            // dtpInvoice
            // 
            this.dtpInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInvoice.Location = new System.Drawing.Point(128, 28);
            this.dtpInvoice.Name = "dtpInvoice";
            this.dtpInvoice.Size = new System.Drawing.Size(140, 20);
            this.dtpInvoice.TabIndex = 33;
            this.dtpInvoice.ValueChanged += new System.EventHandler(this.dtpInvoice_ValueChanged_1);
            // 
            // dtpPayment
            // 
            this.dtpPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPayment.Location = new System.Drawing.Point(128, 61);
            this.dtpPayment.Name = "dtpPayment";
            this.dtpPayment.Size = new System.Drawing.Size(140, 20);
            this.dtpPayment.TabIndex = 34;
            this.dtpPayment.ValueChanged += new System.EventHandler(this.dtpPayment_ValueChanged_1);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(128, 175);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(140, 20);
            this.txtTotalAmount.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Delivery Note:";
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDetail.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.Location = new System.Drawing.Point(377, 93);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(170, 36);
            this.btnDetail.TabIndex = 25;
            this.btnDetail.Text = "Invoice Detail>>";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // FormInvoiceHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.dtpPayment);
            this.Controls.Add(this.dtpInvoice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDelivery);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.dgInvoiceH);
            this.Controls.Add(this.label1);
            this.Name = "FormInvoiceHeader";
            this.Text = "FormInvoiceHeader";
            this.Load += new System.EventHandler(this.FormInvoiceHeader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoiceH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDelivery;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.DataGridView dgInvoiceH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInvoice;
        private System.Windows.Forms.DateTimePicker dtpPayment;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDetail;
    }
}