using HackatonInternetPlatform.Model;
using HackatonInternetPlatform.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Presenter
{
    internal class SignUpPresenter
    {
        private TradingFloorData _model;
        private RegistrationForm _view;

        public SignUpPresenter(TradingFloorData model, RegistrationForm view)
        {
            _model = model;
            _view = view;

            //_model.AddedPurchaser += OnAddedPurchaser;
            _view.AddingPurchaser += OnAddingPurchaser;
            _view.AddingSupplier += OnAddingSupplier;
            //_model.RemovedPurchaser += OnRemovedPurchaser;
            //_model.UpdatedPurchaser += OnUpdatedPurchaser;
            //_model.TookPurchaser += OnTookPurchaser;
        }

        //public void OnAddedPurchaser() =>
        private void OnAddingPurchaser(string fullName, string contactData, string legalInformation, string login, string password) 
            => _model.AddPurchaser(fullName, contactData, legalInformation, login, password);

        private void OnAddingSupplier(string fullName, string contactData, string legalInformation, string login, string password)
            => _model.AddSupplier(fullName, contactData, legalInformation, login, password);

        //private void OnRemovedPurchaser(int id) => _model.RemovePurchaser(id);

        //private void OnAddedPurchaser(string fullName, string contactData, string legalInformation, 
        //    string login, string password, List<Request> requests, List<Auction> auctions) => _model.AddPurchaser(fullName, contactData, 
        //        legalInformation, login, password, requests, auctions);
        //private void OnUpdatedPurchaser() => _model.UpdatePurchaser();

        //private void OnTookPurchaser() => _model.TakePurchaser();
    }
}
