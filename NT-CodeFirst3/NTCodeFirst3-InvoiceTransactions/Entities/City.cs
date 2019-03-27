using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTCodeFirst3_InvoiceTransactions.Entities
{   //Veritabanında Cities tablosunu oluşturacak olan City classımızı ve kolonlarını oluşturacak olan propertylerimizi tanımladık
    public class City
    {
        public City()
        {
            this.counties = new HashSet<County>();
        }
        public int CityID { get; set; }
        public string Description { get; set; }
        public virtual ICollection<County> counties { get; set; }//Bir şehrin birden fazla ilçesi olduğu için collection tanımladık
    }
}
