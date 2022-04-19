using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    internal class SupplyOffer
    {
        private static int _id;
        public int Id { get; set; }
        public int Cost { get; set; }
        public string Comment { get; set; }
        public Supplier SupplierInfo { get; set; }

        static SupplyOffer()
        {
            _id = 0;
        }

        public SupplyOffer()
        {
            Id = ++_id;
        }

        public void Update()
        {

        }
    }
}
