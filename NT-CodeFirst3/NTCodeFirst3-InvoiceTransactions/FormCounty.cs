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
    public partial class FormCounty : Form
    {
        public FormCounty()
        {
            InitializeComponent();
        }
        //FormCity classındaki işlemler aynen uygulanır
        INVOICECONTEXT ctx = new INVOICECONTEXT();
        public void FillCounty()
        {
            var countyList = ctx.Counties.Select(x=>new {x.CountyID,x.Description,x.cities.CityID}).ToList();
            dgCounty.DataSource = countyList;
        }
        public void FillCity()
        {
            var cityList = ctx.Cities.ToList();
            cbCity.DisplayMember = "Description";
            cbCity.ValueMember = "CityID";
            cbCity.DataSource = cityList;
        }
        private void FormCounty_Load(object sender, EventArgs e)
        {
            FillCounty();
            FillCity();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                County county = new County();
                county.Description = txtCountyName.Text.ToString();
                county.CityID = Convert.ToInt32(cbCity.SelectedValue);
                ctx.Counties.Add(county);
                ctx.SaveChanges();
                FillCounty();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public static int selectedID;
        private void dgCounty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedID = Convert.ToInt32(dgCounty.CurrentRow.Cells[0].Value);
            var county = ctx.Counties.Find(selectedID);
            txtCountyName.Text = dgCounty.CurrentRow.Cells[1].Value.ToString();
            cbCity.SelectedValue = dgCounty.CurrentRow.Cells[2].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                selectedID = Convert.ToInt32(dgCounty.CurrentRow.Cells[0].Value);
                var county = ctx.Counties.Find(selectedID);
                county.Description = txtCountyName.Text;
                county.CityID = Convert.ToInt32(cbCity.SelectedValue);
                ctx.SaveChanges();
                FillCounty();
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
                if (dgCounty.SelectedRows.Count == 1)
                {
                    selectedID = Convert.ToInt32(dgCounty.CurrentRow.Cells[0].Value);
                    var county = ctx.Counties.Find(selectedID);
                    ctx.Counties.Remove(county);
                    ctx.SaveChanges();
                    FillCounty();
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
                if (dgCounty.SelectedRows.Count > 1)
                {
                    foreach (DataGridViewRow item in dgCounty.SelectedRows)
                    {
                        selectedID = Convert.ToInt32(item.Cells[0].Value);
                        var countyList = ctx.Counties.Find(selectedID);
                        ctx.Counties.Remove(countyList);
                    }
                    ctx.SaveChanges();
                    FillCity();
                }
                else
                {
                    MessageBox.Show("Please, choose more than one rows or click the delete!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message) ;
            }
            
        }
    }
}
