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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }
        INVOICECONTEXT ctx = new INVOICECONTEXT();

        public void FillProduct()//datagridi doldurur
        {
            var proList = ctx.Products.Select(x=>new {x.ProductID,x.ProductCode,x.ProductName,x.units.UnitName,
                x.UnitPrice }).ToList();
            dgProduct.DataSource = proList;
        }
        public void FillUnitCombo()//Birim comboboxını doldurur
        {
            var unitList = ctx.Units.ToList();
            cbUnit.DisplayMember = "UnitName";
            cbUnit.ValueMember = "UnitID";
            cbUnit.DataSource = unitList;
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            FillProduct();
            FillUnitCombo();
        }

        private void btnInsert_Click(object sender, EventArgs e)//Alanlardaki bilgilerle yeni ürün ekler,diğer işlemler de önceki formlarda olduğu gibi update delete işlemleridir
        {
            try
            {
                Product pro = new Product();
                pro.ProductCode = txtProductCode.Text.ToString();
                pro.ProductName = txtProductName.Text.ToString(); ;
                pro.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                pro.UnitID = Convert.ToInt32(cbUnit.SelectedValue);
                ctx.Products.Add(pro);
                ctx.SaveChanges();
                FillProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static int selectedID;
        private void dgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedID = Convert.ToInt32(dgProduct.CurrentRow.Cells[0].Value);
                var pro = ctx.Products.Find(selectedID);
                txtProductName.Text = dgProduct.CurrentRow.Cells[1].Value.ToString();
                txtProductCode.Text = dgProduct.CurrentRow.Cells[2].Value.ToString();
                cbUnit.SelectedValue = dgProduct.CurrentRow.Cells[4].Value;
                txtUnitPrice.Text = dgProduct.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                selectedID = Convert.ToInt32(dgProduct.CurrentRow.Cells[0].Value);
                var pro = ctx.Products.Find(selectedID);
                pro.ProductCode = txtProductCode.Text.ToString();
                pro.ProductName = txtProductName.Text.ToString(); ;
                pro.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                pro.UnitID = Convert.ToInt32(cbUnit.SelectedValue);
                ctx.SaveChanges();
                FillProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgProduct.SelectedRows.Count == 1)
                {
                    selectedID = Convert.ToInt32(dgProduct.CurrentRow.Cells[0].Value);
                    var pro = ctx.Products.Find(selectedID);
                    ctx.Products.Remove(pro);
                    ctx.SaveChanges();
                    FillProduct();
                }
                else
                {
                    MessageBox.Show("Please, choose only one row or click the multiple delete!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMultipleDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgProduct.SelectedRows.Count > 1)
                {
                    foreach (DataGridViewRow item in dgProduct.SelectedRows)
                    {
                        selectedID = Convert.ToInt32(item.Cells[0].Value);
                        var proList = ctx.Products.Find(selectedID);
                        ctx.Products.Remove(proList);
                    }
                    ctx.SaveChanges();
                    FillProduct();
                }
                else
                {
                    MessageBox.Show("Please, choose more than one rows or click the delete!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
