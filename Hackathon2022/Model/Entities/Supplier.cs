﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    [Serializable]
    public class Supplier : User, IReadOnlySupplier
    {
        public List<SupplyOffer> SupplyOffers { get; private set; }

        public Supplier(string fullName, string contactData, string legalInformation, string login, string password, List<SupplyOffer> offers)
            : base(fullName, contactData, legalInformation, login, password)
        {
            SupplyOffers = offers;
        }

        public bool AddSupplyOffer(int cost, string comment, Supplier supplierInfo)
        {
            if (supplierInfo != null)
            {
                SupplyOffers.Add(new SupplyOffer(cost, comment, supplierInfo));
                return true;
            }

            return false;
        }

        public bool RemoveSupplyOffer(int id)
        {
            int index = FindSupplyOfferIndexById(id);

            if (index != -1)
            {
                SupplyOffers.RemoveAt(index);
                return true;
            }

            return false;
        }

        public bool UpdateSupplyOffer(int id, int cost, string comment, Supplier supplierInfo)
        {
            int index = FindSupplyOfferIndexById(id);

            if (index != -1)
            {
                SupplyOffers[index].Update(cost, comment, supplierInfo);
                return true;
            }

            return false;
        }

        public IReadOnlySupplyOffer GetSupplyOffer(int id)
        {
            int index = FindSupplyOfferIndexById(id);

            if (index != -1)
                return SupplyOffers[index];

            return null;
        }

        public IReadOnlyList<IReadOnlySupplyOffer> GetSupplyOffers()
        {
            return SupplyOffers;
        }

        private int FindSupplyOfferIndexById(int Id)
        {
            for (int i = 0; i < SupplyOffers.Count; i++)
                if (SupplyOffers[i].ID == Id)
                    return i;

            return -1;
        }
    }

    public interface IReadOnlySupplier
    {
        public List<SupplyOffer> SupplyOffers { get; }
    }
}
