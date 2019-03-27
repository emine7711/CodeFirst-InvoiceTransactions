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
    public partial class FormCity : Form
    {
        public FormCity()
        {
            InitializeComponent();
        }
        INVOICECONTEXT ctx = new INVOICECONTEXT();
        
        public void FillCity()
        {
            var cityList = ctx.Cities.Select(x=>new {x.CityID,x.Description}).ToList();   //Cities entitysinin tamamıyla
            dgCity.DataSource = cityList;         //datagridview  doldurulur
        }
        
        private void FormCity_Load(object sender, EventArgs e)
        {
            FillCity();                           //Bu doldurma işlemi form açıldığı anda olur.
        }
         
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                City city = new City();         //City tipinde yeni bir nesne oluşturulur
                city.Description = txtCityName.Text.ToString(); //ve bu nesnenin özellikleri belirtilerek
                ctx.Cities.Add(city);   //cities entitysine eklenir
                ctx.SaveChanges();      //ve değişiklikler veritabanına kaydedilir
                FillCity();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        
        private void dgCity_CellClick(object sender, DataGridViewCellEventArgs e)
        {    
            txtCityName.Text = dgCity.CurrentRow.Cells[1].Value.ToString();//seçili satırın 1.hücre değeri ilgili text box alanına getirilir.
        }

        public static int selectedID;   //birkaç yerde kullanılacağı için static bir ID değişkeni tanımlanır.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                selectedID = Convert.ToInt32(dgCity.CurrentRow.Cells[0].Value);//seçili satırın ilk hücresi bu ID değişkenine atanır
                var city = ctx.Cities.Find(selectedID);//Cities entitysi içinde bu IDye sahip veriler bulunur ve city nesnesine atanır
                city.Description = txtCityName.Text;//city nesnesinin özellikleri ilgili alanlardaki bilgilerle güncellenir
                ctx.SaveChanges();//değişiklikler veritabanına kaydedilir
                FillCity();//datagrid yeniden doldurulur
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
                if (dgCity.SelectedRows.Count == 1)//seçili satır 1 tane ise
                {
                    selectedID = Convert.ToInt32(dgCity.CurrentRow.Cells[0].Value);//seçili hücredeki ID alınır
                    var city = ctx.Cities.Find(selectedID);//bu ID ye sahip veri city nesnesine atanır
                    ctx.Cities.Remove(city);//bu nesne entityden silinir
                    ctx.SaveChanges();//değişiklikler veritabanına kaydedilir
                    FillCity();//datagrid yeniden doldurulur
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
                if (dgCity.SelectedRows.Count > 1)//seçili satır sayısı 1den fazlaysa
                {
                    foreach (DataGridViewRow item in dgCity.SelectedRows) //seçili satırla içinde item ile dönülür
                    {
                        selectedID = Convert.ToInt32(item.Cells[0].Value);//itemın olduğu satırın ID si alınır
                        var cityList = ctx.Cities.Find(selectedID);// bu ID Citiesde bulunarak cityList e atanır
                        ctx.Cities.Remove(cityList);//cityList silinir
                    }
                    ctx.SaveChanges();//silme döngüsü tamamlanınca değişiklikler kaydedilir
                    FillCity();//ve  datagrid yeniden doldurulur
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
