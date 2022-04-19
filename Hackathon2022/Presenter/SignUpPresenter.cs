using HackatonInternetPlatform;
using HackatonInternetPlatform.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hackathon2022.Presenter
{
    internal class SignUpPresenter
    {
        private TradingFloorData _model;
        private LoginForm _view;

        public SignUpPresenter(TradingFloorData data, LoginForm view)
        {
            _model = data;
            _view = view;

            _model.AddedPurchaser += OnAddedPurchaser;
            _model.RemovedPurchaser += OnRemovedPurchaser;
            _model.UpdatedPurchaser += OnUpdatedPurchaser;
            _model.TookPurchaser += OnTookPurchaser;
        }

        private void OnRemovedPurchaser() => _model.RemovePurchaser();

        private void OnAddedPurchaser() => _model.AddPurchaser();

        private void OnUpdatedPurchaser() => _model.UpdatePurchaser();

        private void OnTookPurchaser() => _model.TakePurchaser();
    }
}
