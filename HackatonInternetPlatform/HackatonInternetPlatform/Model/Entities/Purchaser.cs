using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    [Serializable]
    internal class Purchaser : User
    {

        private List<Request>? Requests { get; set; }
        //private List<Auction>? Auctions { get; set; }
        public Purchaser(string fullName, string contactData, string legalInformation, string login, string password, List<Request>? requests = null)
            : base(fullName, contactData, legalInformation, login, password)
        {
            FullName = fullName;
            ContactData = contactData;
            LegalInformation = legalInformation;
            Requests = requests;
            Login = login;
            Password = password;
            Requests = requests;
            //Auctions = auctions;
        }

        public bool AddRequest(string name, int count, string productType, int cost, char currency, string payMethod, string deliveryAdress, bool isValid)
        {
            Requests.Add(new Request(name, count, productType, cost, currency, payMethod, deliveryAdress, isValid));

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

        public bool UpdateRequest(int id, string name, int count, string productType, int cost, char currency, string payMethod, string deliveryAdress, DateTime dateEnd, bool isValid)
        {
            int index = FindRequstIndexById(id);

            if (index != -1)
            {
                Requests[index].Update(name, count, productType, cost, currency, payMethod, deliveryAdress, dateEnd, isValid);
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
                if (Requests[i].Id == Id)
                    return i;

            return -1;
        }
    }
}
