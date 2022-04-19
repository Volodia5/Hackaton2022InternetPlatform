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
        private List<SupplyOffer> _supplyOffers;

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

        public bool AddPurchaser()
        {
            Purchaser purchaser = Purchaser(Purchaser);

            return true;
        }
    }
}
