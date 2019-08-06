using OAuth.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace OAuth.ViewModel
{
    public class MainPageViewModel
    {
        public ICommand LoginFacebookCommand { get; set; }

        public MainPageViewModel()
        {
            LoginFacebookCommand = new Command(FacebookLogin);
        }

        private void FacebookLogin()
        {
            App.Current.MainPage = new LoginFacebook();
        }
    }
}
