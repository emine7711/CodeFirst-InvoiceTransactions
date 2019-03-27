using NTCodeFirst3_InvoiceTransactions.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTCodeFirst3_InvoiceTransactions
{
    public partial class FormInvoiceHeader : Form
    {
        public FormInvoiceHeader()
        {
            InitializeComponent();
        }
        INVOICECONTEXT ctx = new INVOICECONTEXT();
        //Bu formda sadece Fatura tarihi ödeme tarihi ve müşteriye göre fatura görüntüleme işlemi yapılır
        public void FillInvoiceH()
        {
            var invHList = ctx.InvoiceHeaders.Select(x => new
            {
                x.InvoiceID,
                x.InvoiceDate,
                x.PaymentDate,
                x.customers.CompanyName,
                x.DeliveryNote,
                x.TotalAmount
            }).ToList();
            dgInvoiceH.DataSource = invHList;
        }
        public void FillCustomCombo()
        {
            var custList = ctx.Customers.ToList();
            cbCustomer.DisplayMember = "CompanyName";
            cbCustomer.ValueMember = "CustomerID";
            cbCustomer.DataSource = custList;
        }

        private void FormInvoiceHeader_Load(object sender, EventArgs e)
        {
            FillInvoiceH();
            FillCustomCombo();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            try
            {
                FormInvoiceDetail fid = new FormInvoiceDetail();
                fid.Show();
                FormInvoiceHeader fih = new FormInvoiceHeader();
                fih.Close();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgInvoiceH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dtpInvoice.Value = Convert.ToDateTime(dgInvoiceH.CurrentRow.Cells[1].Value);
                dtpPayment.Value = Convert.ToDateTime(dgInvoiceH.CurrentRow.Cells[2].Value);
                txtTotalAmount.Text = dgInvoiceH.CurrentRow.Cells[3].Value.ToString();
                txtDelivery.Text = dgInvoiceH.CurrentRow.Cells[4].Value.ToString();
                cbCustomer.SelectedValue = dgInvoiceH.CurrentRow.Cells[5].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpInvoice_ValueChanged_1(object sender, EventArgs e)
        {
            var searched = ctx.InvoiceHeaders.Where(x => x.InvoiceDate >= dtpInvoice.Value &&
              x.PaymentDate <= dtpPayment.Value).Select(x => new
              {
                  x.InvoiceID,
                  x.InvoiceDate,
                  x.PaymentDate,
                  x.customers.CompanyName,
                  x.DeliveryNote,
                  x.TotalAmount
              }).ToList();
            dgInvoiceH.DataSource = searched;
        }

        private void dtpPayment_ValueChanged_1(object sender, EventArgs e)
        {
            var searched = ctx.InvoiceHeaders.Where(x => x.InvoiceDate >= dtpInvoice.Value &&
              x.PaymentDate <= dtpPayment.Value).Select(x => new
              {
                  x.InvoiceID,
                  x.InvoiceDate,
                  x.PaymentDate,
                  x.customers.CompanyName,
                  x.DeliveryNote,
                  x.TotalAmount
              }).ToList();
            dgInvoiceH.DataSource = searched;
        }

        private void cbCustomer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var searched = ctx.InvoiceHeaders.Where(x => x.InvoiceDate >= dtpInvoice.Value &&
              x.PaymentDate <= dtpPayment.Value && x.CustomerID == (int)cbCustomer.SelectedValue).Select(x => new
              {
                  x.InvoiceID,
                  x.InvoiceDate,
                  x.PaymentDate,
                  x.customers.CompanyName,
                  x.DeliveryNote,
                  x.TotalAmount
              }).ToList();
            dgInvoiceH.DataSource = searched;
        }
    }
}
