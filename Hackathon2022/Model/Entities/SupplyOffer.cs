using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    public class SupplyOffer : IReadOnlySupplyOffer
    {
        private static int _id;

        public int ID { get; private set; }
        public int Cost { get; private set; }
        public string Comment { get; private set; }
        public Supplier SupplierInfo { get; private set; }

        static SupplyOffer()
        {
            _id = 0;
        }

        public SupplyOffer(int cost, string comment, Supplier supplierInfo)
        {
            ID = ++_id;
            Cost = cost;
            Comment = comment;
            SupplierInfo = supplierInfo;
        }

        public void Update(int cost = -1, string comment = null, Supplier supplierInfo = null)
        {
            if (cost != -1)
                Cost = cost;
            if (comment != null)
                Comment = comment;
            if (supplierInfo != null)
                SupplierInfo = supplierInfo;
        }

        public static int GetCurrentId()
        {
            return _id;
        }

        public static void SetCurrentId(int id)
        {
            _id = id;
        }
    }

    public interface IReadOnlySupplyOffer
    {
        public int ID { get; }
        public int Cost { get; }
        public string Comment { get; }
        public Supplier SupplierInfo { get; }
    }
}
