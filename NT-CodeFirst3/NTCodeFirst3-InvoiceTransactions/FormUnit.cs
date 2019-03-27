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
    public partial class FormUnit : Form
    {
        public FormUnit()
        {
            InitializeComponent();
        }
        INVOICECONTEXT ctx = new INVOICECONTEXT();
        //Unit ekleme güncelleme silme ve çoklu silme işlemleri yapılır.
        public void FillUnit()
        {
            var unitList = ctx.Units.Select(x=>new {x.UnitID,x.UnitName }).ToList();
            dgUnit.DataSource = unitList;
        }

        private void FormUnit_Load(object sender, EventArgs e)
        {
            FillUnit();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Unit unit = new Unit();
                unit.UnitName = txtUnitName.Text.ToString();
                ctx.Units.Add(unit);
                ctx.SaveChanges();
                FillUnit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public static int selectedID;
        private void dgUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedID = Convert.ToInt32(dgUnit.CurrentRow.Cells[0].Value);
            var unit = ctx.Units.Find(selectedID);
            txtUnitName.Text = dgUnit.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                selectedID = Convert.ToInt32(dgUnit.CurrentRow.Cells[0].Value);
                var unit = ctx.Units.Find(selectedID);
                unit.UnitName = txtUnitName.Text;
                ctx.SaveChanges();
                FillUnit();
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
                if (dgUnit.SelectedRows.Count == 1)
                {
                    selectedID = Convert.ToInt32(dgUnit.CurrentRow.Cells[0].Value);
                    var unit = ctx.Units.Find(selectedID);
                    ctx.Units.Remove(unit);
                    ctx.SaveChanges();
                    FillUnit();
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
                if (dgUnit.SelectedRows.Count > 1)
                {
                    foreach (DataGridViewRow item in dgUnit.SelectedRows)
                    {
                        selectedID = Convert.ToInt32(item.Cells[0].Value);
                        var unitList = ctx.Units.Find(selectedID);
                        ctx.Units.Remove(unitList);
                    }
                    ctx.SaveChanges();
                    FillUnit();
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
