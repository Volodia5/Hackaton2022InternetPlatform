using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    [Serializable]
    internal class Supplier : User
    {
        private List<SupplyOffer>? _supplyOffers { get; set; }
        public Supplier(string fullName, string contactData, string legalInformation, List<SupplyOffer> offers)
            : base(fullName, contactData, legalInformation)
        {
            FullName = fullName;
            ContactData = contactData;
            LegalInformation = legalInformation;
            _supplyOffers = offers;
        }
    }
}
