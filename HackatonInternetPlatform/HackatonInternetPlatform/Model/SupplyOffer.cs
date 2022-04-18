using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    internal class SupplyOffer
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public string Comment { get; set; }
        public Supplier SupplierInfo { get; set; }
    }
}
