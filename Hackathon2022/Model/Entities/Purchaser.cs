using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    [Serializable]
    internal class Purchaser : User, IReadOnlyPurchaser
    {
        public List<Request> Requests { get; private set; }
        //public List<Auction> Auctions { get; private set; }

        public Purchaser(string fullName, string contactData, string legalInformation, string login, string password, List<Request> requests/*, List<Auction> auctions*/)
            : base(fullName, contactData, legalInformation, login, password)
        {
            Requests = requests;
            //Auctions = auctions;
        }

        public bool AddRequest(string name, int count, string productType, int cost, char currency, string payMethod, string deliveryAdress, bool isValid, DateTime dateEnd)
        {
            Requests.Add(new Request(name, count, productType, cost, currency, payMethod, deliveryAdress, isValid, dateEnd));

            return true;
        }

        public bool RemoveRequest(int id)
        {
            int index = FindRequstIndexById(id);

            if (index != -1)
            {
                Requests.RemoveAt(index);
                return true;
            }

            return false;
        }

        public bool UpdateRequest(int id, string name, int count, string productType, int cost, char currency, string payMethod, string deliveryAdress, bool isValid)
        {
            int index = FindRequstIndexById(id);

            if (index != -1)
            {
                Requests[index].Update(name, count, productType, cost, currency, payMethod, deliveryAdress, isValid);
                return true;
            }

            return false;
        }

        public IReadOnlyRequest GetRequest(int id)
        {
            int index = FindRequstIndexById(id);

            if (index != -1)
                return Requests[index];

            return null;
        }

        public IReadOnlyList<IReadOnlyRequest> GetRequests()
        {
            return Requests;
        }

        public bool OpenRequest(int id)
        {
            int index = FindRequstIndexById(id);

            if (index != -1)
            {
                Requests[index].Open();
                return true;
            }

            return false;
        }

        public bool CloseRequest(int id)
        {
            int index = FindRequstIndexById(id);

            if (index != -1)
            {
                Requests[index].Close();
                return true;
            }

            return false;
        }

        public bool AddAuction()
        {
            return false;
        }

        private int FindRequstIndexById(int Id)
        {
            for (int i = 0; i < Requests.Count; i++)
                if (Requests[i].ID == Id)
                    return i;

            return -1;
        }
    }

    public interface IReadOnlyPurchaser
    {
        public List<Request> Requests { get; }
        //public List<Auction> Auctions { get; }
    }
}
