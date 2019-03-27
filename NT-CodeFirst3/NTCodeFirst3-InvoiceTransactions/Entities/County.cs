using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTCodeFirst3_InvoiceTransactions.Entities
{    //Counties tablomuz ve kolonları için County classımız ve propertyleri:
    public class County
    {
        public County()
        {
            this.customers = new HashSet<Customer>();
        }
        public int CountyID { get; set; }
        public string Description { get; set; }
        public int CityID { get; set; }
        public virtual City cities { get; set; }
        public virtual ICollection<Customer> customers { get; set; }



    }
}
