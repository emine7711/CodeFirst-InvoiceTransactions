using NTCodeFirst3_InvoiceTransactions.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTCodeFirst3_InvoiceTransactions
{
    public partial class FormInvoiceDetail : Form
    {
      
        INVOICECONTEXT ctx = new INVOICECONTEXT();
        List<FakeDetail> invoiceDet = new List<FakeDetail>();
        public static int selectedID;

        public FormInvoiceDetail()
        {
            InitializeComponent();
        }
        //İlk açıldığında ve gerektiği zamanlarda alanların boş gelmesini sağlayan metot
        public void FirstViewInvH()
        {
            txtInvoiceID.Text = " ";
            dtpInvoice.Value = DateTime.Now;
            dtpPayment.Value = DateTime.Now;
            txtDelivery.Text = " ";
            txtInvoiceAmount.Text = " ";
            cbCustomer.Text = " ";
        }
        //Invoice Header alanını sql tablosundan dolduran metot
        public void FillInvoiceH()
        {
             int selectedID = Convert.ToInt32(txtInvoiceID.Text);
            var invH = ctx.InvoiceHeaders.Find(selectedID);
            dtpInvoice.Value = invH.InvoiceDate;
            dtpPayment.Value = invH.PaymentDate;
            txtInvoiceAmount.Text = invH.TotalAmount.ToString(); ;
            txtDelivery.Text = invH.DeliveryNote.ToString();
            cbCustomer.SelectedValue = invH.CustomerID;
        }
        //Customer comboboxını dolduran metot
        public void FillCustomCombo()
        {
            var custList = ctx.Customers.ToList();
            cbCustomer.DisplayMember = "CompanyName";
            cbCustomer.ValueMember = "CustomerID";
            cbCustomer.DataSource = custList;
        }
        //Invoice Detay gösteren datagridi FakeDetail classından türetilen invoiceDet list i ile dolduran ve hemen altında Nükhet Tunçbilek Hocamın anlık çözüm için yazdığı el emeği göz nuru kod bloğunu barındıran metot<3 (list oluşturulma sebebi için satır259a gidin)

        public void FillInvoiceD()
        {
            dgInvoiceD.DataSource = null;
            dgInvoiceD.DataSource = invoiceDet;
            txtInvoiceAmount.Text = CalculateInvoiceAmount().ToString() ;
            //dgInvoiceD.Rows.Clear();
            //var index = 0;
            //foreach (FakeDetail item in invoiceDet)
            //{
            //    index = dgInvoiceD.Rows.Add();
            //    dgInvoiceD.Rows[index].Cells["ProductID"].Value = item.ProductID;
            //    dgInvoiceD.Rows[index].Cells["UnitPrice"].Value = item.UnitPrice;
            //    dgInvoiceD.Rows[index].Cells["Quantity"].Value = item.Quantity;
            //    dgInvoiceD.Rows[index].Cells["VATAmount"].Value = item.VATAmount;
            //    dgInvoiceD.Rows[index].Cells["AmountWithVAT"].Value = item.AmountWithVAT;
            //    dgInvoiceD.Rows[index].Cells["Description"].Value = item.Description;
            //    index++;
            //}
        }
    
        public void FillProductCombo()//Product comboboxını doldurur
        {
            var proList = ctx.Products.ToList();
            cbProduct.DisplayMember = "ProductName";
            cbProduct.ValueMember = "ProductID";
            cbProduct.DataSource = proList;
        }
        public void FillUnitCombo()//Unit comboboxını doldurur
        {
            var unitList = ctx.Units.ToList();
            cbUnit.DisplayMember = "UnitName";
            cbUnit.ValueMember = "UnitID";
            cbUnit.DataSource = unitList;
        }

        public decimal CalculateAmount(string amount, string VAT)//Girilen KDV oranı ve birim fiyatı ile KDVli fiyat hesaplama
        {
            if (VAT is "" && amount is "")//Vat ve unitprice null gelirse
            {
                VAT = 0.ToString();
                amount = 0.ToString();
            }
            else if (VAT is "")//Sadece VAT null gelirse
            {
                VAT = 0.ToString();
            }
            else if (amount is "")//Sadece UnitPrice null gelirse
            {
                amount = 0.ToString();
            }
            decimal dVAT = Convert.ToDecimal(VAT);
            decimal damount = Convert.ToDecimal(amount);
            damount = damount * (1 + dVAT);
            return damount;
        }
        public decimal CalculateInvoiceAmount()//Faturaya ait Detayların tutarları toplamını hesaplama
        {
            decimal invoiceAmount = 0;
            foreach (FakeDetail item in invoiceDet)
            {
                invoiceAmount += item.TotalAmount;
            }
            return invoiceAmount;
        }
        //Oluşturulmuş bir siparişe ait detayları veritabanından çekerek gösteren metot(Oluşturulmuş faturanın detayları üzerinde değişiklik yapmaya izin vermez bu yüzden butonların enable larını false yapar)
        public void OldDetail()
        {
            selectedID = Convert.ToInt32(txtInvoiceID.Text);
            var reelDet = ctx.InvoiceDetails.Where(x => x.InvoiceID == selectedID).Select(x => new
            {
                x.ProductID,
                x.UnitPrice,
                x.Quantity,
                x.VATAmount,
                x.AmountWithVAT,
                x.Description
            }).ToList();
            dgInvoiceD.DataSource = reelDet;
            btnInsertPro.Enabled = false;
            btnDeleteID.Enabled = false;
            btnUpdateID.Enabled = false;
            btnMDeleteID.Enabled = false;
            btnInsertID.Enabled = false;
        }
        private void FormInvoiceDetail_Load(object sender, EventArgs e)
        {
            FillCustomCombo();
            FillProductCombo();
            FillUnitCombo();
            FirstViewInvH();
        }

        // textbox a ID girilip Enter butonuna basıldığında header alanındaki combolar dolar ve Old detail metodu çalışır.IDye ait hem header hem detay bilgileri veritabanından çekilerek ilgili alanlarda gösterilir
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                FillCustomCombo();
                FillInvoiceH();
                OldDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Header kısmına ait güncelleme işlemini yapan buton eventi
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                selectedID = Convert.ToInt32(txtInvoiceID.Text);
                var invH = ctx.InvoiceHeaders.Find(selectedID);
                invH.InvoiceDate = dtpInvoice.Value;
                invH.PaymentDate = dtpPayment.Value; ;
                invH.CustomerID = Convert.ToInt32(cbCustomer.SelectedValue);
                invH.DeliveryNote = Convert.ToInt32(txtDelivery.Text);
                invH.TotalAmount = Convert.ToDecimal(txtInvoiceAmount.Text);
                ctx.SaveChanges();
                MessageBox.Show("Update is successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Header kısmına ait silme işlemini yapan buton eventi
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                selectedID = Convert.ToInt32(txtInvoiceID.Text);
                var invH = ctx.InvoiceHeaders.Find(selectedID);
                ctx.InvoiceHeaders.Remove(invH);
                ctx.SaveChanges();
                MessageBox.Show("Delete is successful!");
                FirstViewInvH();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Product seçildiğinde o ürüne ait birim ve fiyatı ilgili alanlara getiren event
        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateAmount(txtUnitPrice.Text, txtVAT.Text);
            selectedID = Convert.ToInt32(cbProduct.SelectedValue);
            var pro = ctx.Products.Where(x => x.ProductID == selectedID).FirstOrDefault();
            cbUnit.SelectedValue = pro.UnitID;
            txtUnitPrice.Text = pro.UnitPrice.ToString();
            txtVAT.Text = 0.18.ToString();
        }
        //UnitPrice değişirse Calculate metodu çağrılır ve girilen değere göre yeniden KDVli tutar hesaplanır
        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            string amount = txtUnitPrice.Text;
            string VAT = txtVAT.Text;
            txtWithVAT.Text = CalculateAmount(amount, VAT).ToString();
        }

        //KDV oranı değştirildiğinde  Calculate metodu çağrılır ve KDVli fiyat yeniden hesaplanılır
        private void txtVAT_TextChanged(object sender, EventArgs e)
        {
            string amount = txtUnitPrice.Text;
            string VAT = txtVAT.Text;
            txtWithVAT.Text = CalculateAmount(amount, VAT).ToString();
        }

        //Header alanındaki bilgilerle fatura kaydedip ID oluşturan metot
        public void SaveInvoice()
        {
                InvoiceHeader invH = new InvoiceHeader();
                invH.InvoiceDate = dtpInvoice.Value;
                invH.PaymentDate = dtpPayment.Value; ;
                invH.CustomerID = Convert.ToInt32(cbCustomer.SelectedValue);
                invH.DeliveryNote = Convert.ToInt32(txtDelivery.Text);
                invH.TotalAmount = Convert.ToDecimal(txtInvoiceAmount.Text);
                ctx.InvoiceHeaders.Add(invH);
                ctx.SaveChanges();
                txtInvoiceID.Text = invH.InvoiceID.ToString();
        }

        //Detail alanındaki bilgilerle ve yukarıdaki metodun oluşturduğu ID ile detay oluşturup veritabanına kaydeden metot
        public void SaveDetail()
        {
                foreach (FakeDetail item in invoiceDet)
                {
                    InvoiceDetail invD = new InvoiceDetail();
                    invD.InvoiceID = Convert.ToInt32(txtInvoiceID.Text);
                    invD.ProductID = item.ProductID;
                    invD.Quantity = item.Quantity;
                    invD.UnitPrice = item.UnitPrice;
                    invD.VATAmount = item.VATAmount;
                    invD.AmountWithVAT = item.AmountWithVAT;
                    invD.Description = item.Description;
                    ctx.InvoiceDetails.Add(invD);
                }
                ctx.SaveChanges();
                FillInvoiceD();
        }

        //Detay alanındaki insert butonu ile ilgili bilgiler Fake Detail sınıfından üretilen list'e kaydedilir.Bunun sebebi veritabanına ekleme yapmadan önce tüm detayların burada görüntülenip kesinleştirilmek istenmesidir. 
        private void btnInsertPro_Click(object sender, EventArgs e)
        {
            invoiceDet.Add(new FakeDetail
            {
                ProductID = (int)cbProduct.SelectedValue,
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                Quantity = Convert.ToInt32(txtQuantity.Text),
                VATAmount = Convert.ToDecimal(txtVAT.Text),
                AmountWithVAT = Convert.ToDecimal(txtWithVAT.Text),
                TotalAmount = Convert.ToDecimal(txtWithVAT.Text) * Convert.ToInt32(txtQuantity.Text),
                Description = txtDescription.Text.ToString()
            });
            FillInvoiceD();
        }

        //Diğer CellClick eventlerinde olduğu gibi datagriddeki seçilen alanları ilgili alanlara atar
        private void dgInvoiceD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbProduct.SelectedValue = dgInvoiceD.CurrentRow.Cells[0].Value;
                txtQuantity.Text = dgInvoiceD.CurrentRow.Cells[2].Value.ToString();
                txtUnitPrice.Text = dgInvoiceD.CurrentRow.Cells[1].Value.ToString();
                txtVAT.Text = dgInvoiceD.CurrentRow.Cells[3].Value.ToString();
                txtWithVAT.Text = dgInvoiceD.CurrentRow.Cells[4].Value.ToString();
                txtDescription.Text = dgInvoiceD.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Diğer update eventlerinde olduğu gibi datagriddeki seçilen verileri ilgili alanlardakilerle günceller
        private void btnUpdateID_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedProID = Convert.ToInt32(dgInvoiceD.CurrentRow.Cells[0].Value);
                var invD = invoiceDet.Where(x => x.ProductID == selectedProID).FirstOrDefault();
                invoiceDet.Remove(invD);
                FakeDetail invDet = new FakeDetail();
                invDet.ProductID = Convert.ToInt32(cbProduct.SelectedValue);
                invDet.Quantity = Convert.ToInt32(txtQuantity.Text);
                invDet.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                invDet.VATAmount = Convert.ToDecimal(txtVAT.Text);
                invDet.AmountWithVAT = Convert.ToDecimal(txtWithVAT.Text);
                invDet.Description = txtDescription.Text;
                invoiceDet.Add(invDet);
                FillInvoiceD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Seçili satır sayısı bir tane ise seçili satırı listten kaldırır
        private void btnDeleteID_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgInvoiceD.SelectedRows.Count == 1)
                {
                    int selectedProID = Convert.ToInt32(dgInvoiceD.CurrentRow.Cells[0].Value);
                    var invD = invoiceDet.Where(x=>x.ProductID==selectedProID).FirstOrDefault();
                    invoiceDet.Remove(invD);
                    FillInvoiceD();
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

        //Seçili satır sayısı birden fazla ise seçili satırları listten kaldırır.
        private void btnMDeleteID_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgInvoiceD.SelectedRows.Count > 1)
                {
                    foreach (DataGridViewRow item in dgInvoiceD.SelectedRows)
                    {
                        int selectedProID = Convert.ToInt32(dgInvoiceD.CurrentRow.Cells[0].Value);
                        var invD = invoiceDet.Where(x => x.ProductID == selectedProID).FirstOrDefault();
                        invoiceDet.Remove(invD);
                        FillInvoiceD();
                    }
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

        //En alttaki insert butonuna basıldığında önce fatura sonra detayları veritabanına kaydedilir.Transaction classı kullanılarak kaydetme işlemleri sırasında herhangi bir hata oluşursa veritabanının ilgili fatura kaydedilmeden önceki hale dönüşmesi sağlanır
        private void btnInsertID_Click(object sender, EventArgs e)
        {
            DbContextTransaction tran = ctx.Database.BeginTransaction();
            try
            {
                SaveInvoice();
                SaveDetail();
                tran.Commit();
                MessageBox.Show("Invoice is saved together its details!");
                OldDetail();
            }
            catch (Exception)
            {
                tran.Rollback();
                MessageBox.Show("Beklenmeyen bir hata oluştu.");
            }
        }

        //Alanları temizleyip formu açıldığı andaki görünümüne kavuşturur ve kaydetme işlemiyle kullanıma kapatılan butonları kullanıma açar
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgInvoiceD.Columns.Clear();
            invoiceDet.Clear();
            FirstViewInvH();
            btnInsertID.Enabled = true;
            btnInsertPro.Enabled = true;
            btnUpdateID.Enabled = true;
            btnDeleteID.Enabled = true;
            btnMDeleteID.Enabled = true;
        }
    }
}
