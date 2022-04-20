using HackatonInternetPlatform.Model;
using HackatonInternetPlatform.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Presenter
{
    public class LoginPresenter
    {
        private TradingFloorData _model;
        private LoginForm _view;
        
        public LoginPresenter(TradingFloorData model, LoginForm view)
        {
            _model = model;
            _view = view;

            _view.OpeningRegisterForm += OnOpeningRegisterForm;
        }

        public void OnOpeningRegisterForm()
        {
            RegistrationForm view = new RegistrationForm();
            SignUpPresenter presenter = new SignUpPresenter(_model, view);
            _view.Hide();
            view.ShowDialog();
        }
    }
}
