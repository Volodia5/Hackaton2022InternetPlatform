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
        private List<Request> _requests { get; set; }
        private List<Auction> _auctions { get; set; }

        public Purchaser(string fullName, string contactData, string legalInformation, string login, string password, List<Request> requests, List<Auction> auctions) 
            : base(fullName, contactData, legalInformation, login, password)
        {
            _requests = requests;
            _auctions = auctions;
        }

        public bool AddRequest()
        {
            return false;
        }

        public bool RemoveRequest()
        {
            return false;
        }

        public bool UpdateRequest()
        {
            return false;
        }

        public void GetRequest()
        {

        }

        public void GetRequests()
        {

        }

        public void OpenRequest()
        {

        }

        public void CloseRequest()
        {

        }

        public bool AddAuction()
        {
            return false;
        }


    }
}
