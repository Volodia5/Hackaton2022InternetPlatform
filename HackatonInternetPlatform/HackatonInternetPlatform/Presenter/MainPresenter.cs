using HackatonInternetPlatform.Model;
using HackatonInternetPlatform.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Presenter
{
    internal class MainPresenter
    {
        private TradingFloorData _model;
        private LoginForm _view;

        public MainPresenter(TradingFloorData model, LoginForm view)
        {
            _model = model;
            _view = view;


        }
    }
}
