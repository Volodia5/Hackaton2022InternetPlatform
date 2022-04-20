using HackatonInternetPlatform.Model.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    [Serializable]
    internal class TradingFloorData
    {
        private List<Purchaser> _purchasers;
        private List<Supplier> _suppliers;
        private List<Request> _requests;
        private List<Auction> _auctions;
        private List<SupplyOffer> _supplyOffers;

        public event Action AddedPurchaser;
        public event Action RemovedPurchaser;
        public event Action UpdatedPurchaser;

        public event Action AddedSupplyer;
        public event Action UpdatedSupplyer;
        public event Action RemovedSupplyer;

        public event Action AddedRequest;
        public event Action UpdatedRequest;
        public event Action RemovedRequest;

        public event Action AddedSupplyOffer;
        public event Action UpdatedSupplyOffer;
        public event Action RemovedSupplyOffer;

        public TradingFloorData()
        {
            Loader loader = new Loader();

            _purchasers = new List<Purchaser>();
            //_purchasers = loader.LoadPurchaser();
            //_suppliers = loader.LoadSuppliers();
            //_requests = loader.LoadRequest();
            //_supplyOffers = loader.LoadSupplyOffers();
        }

        public void Save()
        {
            Saver saver = new Saver();
            //saver.Save(this);
        }

        #region Purchaser CRUD
        public bool AddPurchaser(string fullName, string contactData, string legalInformation, string login, string password)
        {
            _purchasers.Add(new Purchaser(fullName, contactData, legalInformation, login, password));
            AddedPurchaser?.Invoke();

            return true;
        }

        public bool RemovePurchaser()
        {

            return true;
        }

        public bool UpdatePurchaser()
        {
            return true;
        }

        public bool GetPurchaser()
        {
            return true;
        }

        public bool GetPurchasers()
        {
            return true;
        }
        #endregion

        #region Supplier CRUD
        public bool AddSupplier()
        {
            return true;
        }

        public bool RemoveSupplier()
        {
            return true;
        }

        public bool UpdateSupplier()
        {
            return true;
        }

        public bool GetSupplier()
        {
            return true;
        }

        public bool GetSuppliers()
        {
            return true;
        }
        #endregion

        #region Request CRUD
        public bool AddRequest()
        {
            return true;
        }

        public bool RemoveRequest()
        {
            return true;
        }

        public bool UpdateRequest()
        {
            return true;
        }

        public bool GetRequest()
        {
            return true;
        }

        public bool GetRequests()
        {
            return true;
        }
        #endregion

        #region SupplyOffer CRUD
        public bool AddSupplyOffer()
        {
            return true;
        }

        public bool RemoveSupplyOffer()
        {
            return true;
        }

        public bool UpdateSupplyOffer()
        {
            return true;
        }

        public bool GetSupplyOffer()
        {
            return true;
        }

        public bool GetSupplyOffers()
        {
            return true;
        }
        #endregion

        #region Chat CRUD
        public bool AddChat()
        {
            return true;
        }

        public bool RemoveChat()
        {
            return true;
        }

        public bool UpdateChat()
        {
            return true;
        }

        public bool GetChat()
        {
            return true;
        }

        public bool GetChats()
        {
            return true;
        }
        #endregion

        #region Message CRUD
        public bool AddMessage()
        {
            return true;
        }

        //public bool RemoveMessage()
        //{
        //    return true;
        //}
        //                                не нужно
        //public bool UpdateMessage()
        //{
        //    return true;
        //}

        public bool GetMessage()
        {
            return true;
        }

        public bool GetMessages()
        {
            return true;
        }
        #endregion

        public void FilterRequst()
        {

        }
    }
}
