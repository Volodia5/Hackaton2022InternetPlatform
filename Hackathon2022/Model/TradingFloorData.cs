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

        public event Action AddedPurchaser;
        public event Action AddedSupplyer;
        public event Action AddedRequest;
        public event Action AddedSupplyOffer;

        public event Action RemovedPurchaser;
        public event Action RemovedSupplyer;
        public event Action RemovedRequest;
        public event Action RemovedSupplyOffer;

        public event Action UpdatedPurchaser;
        public event Action UpdatedSupplyer;
        public event Action UpdatedRequest;
        public event Action UpdatedSupplyOffer;

        public TradingFloorData()
        {
            Loader loader = new Loader();

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
        public bool AddPurchaser(string fullName, string contactData, string legalInformation, string login, string password, List<Request> requests/*, List<Auction> auctions*/)
        {
            if (requests != null)
            {
                _purchasers.Add(new Purchaser(fullName, contactData, legalInformation, login, password, requests));
                AddedPurchaser?.Invoke();
                return true;
            }

            return false;
        }

        public bool RemovePurchaser(int id)
        {
            bool result = RemoveUser(id, _purchasers, i => _purchasers.RemoveAt(i));
            if (result)
                RemovedPurchaser?.Invoke();

            return result;
        }

        public bool UpdatePurchaser(int purchaserID, string fullName = null, string contactData = null, string legalInformation = null, string login = null, string password = null)
        {
            bool result = UpdateUser(purchaserID, _purchasers, fullName, contactData, legalInformation, login, password);
            if (result)
                UpdatedPurchaser?.Invoke();

            return result;
        }

        public IReadOnlyPurchaser GetPurchaser(int id)
        {
            return (IReadOnlyPurchaser)GetUserById(id, _purchasers);
        }

        public IReadOnlyList<IReadOnlyPurchaser> GetPurchasers()
        {
            return _purchasers;
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

        public void OpenRequest()
        {

        }

        public void CloseRequest()
        {

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

        public bool RemoveMessage()
        {
            return true;
        }

        public bool UpdateMessage()
        {
            return true;
        }

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

        #region Privete methods
        private bool RemoveUser(int id, IEnumerable<User> users, Action<int> userRemove)
        {
            int index = FindUserIndexById(id, users);

            if (index != -1)
            {
                userRemove(index);
                return true;
            }

            return false;
        }

        private bool UpdateUser(int Id, IEnumerable<User> users, string fullName = null, string contactData = null, string legalInformation = null, string login = null, string password = null)
        {
            int index = FindUserIndexById(Id, users);

            if (index != -1)
            {
                users.ToList()[index].Update(fullName, contactData, legalInformation, login, password);
                return true;
            }

            return false;
        }

        private int FindUserIndexById(int Id, IEnumerable<User> users)
        {
            List<User> usersList = users.ToList();

            for (int i = 0; i < usersList.Count; i++)
                if (usersList[i].ID == Id)
                    return i;

            return -1;
        }

        private IReadOnlyUser GetUserById(int id, IEnumerable<User> users)
        {
            int index = FindUserIndexById(id, users);

            if (index != -1)
                return users.ToList()[index];
            else
                return null;
        }
        #endregion
    }
}
