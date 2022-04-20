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
        private List<SupplyOffer>? _supplyOffers = new List<SupplyOffer>();
        public Supplier(string fullName, string contactData, string legalInformation, string login, string password, List<SupplyOffer> offers)
            : base(fullName, contactData, login, password, legalInformation)
        {
            FullName = fullName;
            ContactData = contactData;
            LegalInformation = legalInformation;
            Login = login;
            Password = password;
            _supplyOffers = offers;
        }

        public bool AddSupplyOffer()
        {
            return false;
        }

        public bool RemoveSupplyOffer()
        {
            return false;
        }

        public bool UpdateSupplyOffer()
        {
            return false;
        }

        public void GetSupplyOffer()
        {

        }

        public void GetSupplyOffers()
        {

        }
    }
}
