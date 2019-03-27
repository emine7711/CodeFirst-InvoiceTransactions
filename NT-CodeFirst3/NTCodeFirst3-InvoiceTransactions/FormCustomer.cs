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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }
        INVOICECONTEXT ctx = new INVOICECONTEXT();
        //Customers ve Counties entityleri joinlenerek müşterinin şehir bilgisi de datagride aktarılır.
        public void FillCustomer()
        {
            var cusList = ctx.Customers.Join(ctx.Counties, customer => customer.CountyID, county => county.CountyID,
                (customer,county)=> new{
                    customer.CustomerID,
                    customer.CompanyName,
                    customer.Address,
                    customer.CountyID,
                    county.CityID}).ToList();
            dgCustomer.DataSource = cusList;
        }
        public void FillCity()//City comboboxı doldurulur
        {
            var cityList = ctx.Cities.ToList();
            cbCity.DisplayMember = "Description";
            cbCity.ValueMember = "CityID";
            cbCity.DataSource = cityList;
        }
        public void FillCounty()//County combobox ını city comboboxında seçilen city ye göre doldurulur
        {
            var countyList = ctx.Counties.Where(x=>x.CityID==(int)cbCity.SelectedValue).ToList();
            cbCounty.DisplayMember = "Description";
            cbCounty.ValueMember = "CountyID";
            cbCounty.DataSource = countyList;
        }
        //County comboboxı city seçildiğinde dolar
        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCounty();
        }
        private void FormCustomer_Load(object sender, EventArgs e)//Form açıldığında comboboxların yüklenmesi sağlanır
        {
            FillCity();
            FillCustomer();
        }
        //insert butonuna basıldığında Customer classından yeni bir nesne türetilir ve nesnenin özelliklerine formdaki ilgili alanlar nesnenin özelliklerine atanır ve değişiklikler veritabanına
        private void btnInsert_Click(object sender, EventArgs e)
        { 
            try
            {
                Customer cus = new Customer();
                cus.CompanyName = txtCustomerName.Text.ToString();
                cus.CountyID = Convert.ToInt32(cbCounty.SelectedValue);
                cus.Address = txtAddress.Text;
                ctx.Customers.Add(cus);
                ctx.SaveChanges();
                FillCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static int selectedID;//birden fazla yerde kullanılabilecek static değişken tanımlanır
        //datagrid hücresine tıklandığında hücrenin bulunduğu satırdaki bilgiler ilgili alanlara doldurulur.
        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedID = Convert.ToInt32(dgCustomer.CurrentRow.Cells[0].Value);
                var cust = ctx.Customers.Find(selectedID);
                txtCustomerName.Text = dgCustomer.CurrentRow.Cells[1].Value.ToString();
                txtAddress.Text = dgCustomer.CurrentRow.Cells[2].Value.ToString();
                cbCity.SelectedValue = dgCustomer.CurrentRow.Cells[4].Value;
                cbCounty.SelectedValue = dgCustomer.CurrentRow.Cells[3].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //update butonuna basıldığında seçili olan satırdaki bilgiler alanlardaki bilgilerle güncellenir
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                selectedID = Convert.ToInt32(dgCustomer.CurrentRow.Cells[0].Value);
                var cust = ctx.Customers.Find(selectedID);
                cust.CompanyName = txtCustomerName.Text;
                cust.counties.CityID = Convert.ToInt32(cbCity.SelectedValue);
                cust.CountyID = Convert.ToInt32(cbCounty.SelectedValue);
                cust.Address = txtAddress.Text;
                ctx.SaveChanges();
                FillCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Delete butonuna basıldığında (seçili satır sayısı 1 tane ise) seçili satırdaki IDye ait bilgiler silinir
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgCustomer.SelectedRows.Count == 1)
                {
                    selectedID = Convert.ToInt32(dgCustomer.CurrentRow.Cells[0].Value);
                    var cust = ctx.Customers.Find(selectedID);
                    ctx.Customers.Remove(cust);
                    ctx.SaveChanges();
                    FillCustomer();
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
        //MultipleDelete butonuna basıldığında (seçili satır sayısı 1den fazla ise) seçili satırlardaki IDlere ait bilgiler silinir
        private void btnMultipleDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgCustomer.SelectedRows.Count > 1)
                {
                    foreach (DataGridViewRow item in dgCustomer.SelectedRows)
                    {
                        selectedID = Convert.ToInt32(item.Cells[0].Value);
                        var custList = ctx.Customers.Find(selectedID);
                        ctx.Customers.Remove(custList);
                    }
                    ctx.SaveChanges();
                    FillCustomer();
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
