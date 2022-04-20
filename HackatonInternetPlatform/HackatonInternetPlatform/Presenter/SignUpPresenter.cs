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
            _model.RemovedPurchaser += OnRemovedPurchaser;
            _model.UpdatedPurchaser += OnUpdatedPurchaser;
            //_model.TookPurchaser += OnTookPurchaser;
        }

        private void OnRemovedPurchaser() => _model.RemovePurchaser();

        //private void OnAddedPurchaser() => _model.AddPurchaser();

        private void OnUpdatedPurchaser() => _model.UpdatePurchaser();

        //private void OnTookPurchaser() => _model.TakePurchaser();
    }
}
