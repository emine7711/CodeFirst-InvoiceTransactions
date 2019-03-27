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
    public partial class FormEntry : Form
    {
        public FormEntry()
        {
            InitializeComponent();
        }

        private void customerDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer fc = new FormCustomer();
            fc.Show();
        }

        private void cityDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCity fcity = new FormCity();
            fcity.Show();
        }

        private void countyDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCounty fcounty = new FormCounty();
            fcounty.Show();
        }

        private void productDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduct fp = new FormProduct();
            fp.Show();
        }

        private void unitDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUnit fu = new FormUnit();
            fu.Show();
        }

        private void invoiceViewEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInvoiceHeader fih = new FormInvoiceHeader();
            fih.Show();
        }

        private void createNewInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInvoiceDetail fid = new FormInvoiceDetail();
            fid.Show();
        }
    }
}
