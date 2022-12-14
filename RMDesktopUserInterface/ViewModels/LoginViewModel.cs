using Caliburn.Micro;
using RMDesktopUserInterface.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMDesktopUserInterface.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _userName;
        private string _password;

        private IAPIHelper _apiHelper;

        public LoginViewModel(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }
        public string UserName {
            get { return _userName; }
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
            }
        }

        public string Password
        {
            get { return _password; }
            set {
                
                _password = value; 
                
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogin);

            }
        }

        public bool CanLogin
        {
            get {
                bool output = false;

                if (UserName?.Length > 0 && Password?.Length > 0)
                {
                    output = true;

                }

                return output;
            }
        }

        private bool _isErrorVisible;

        public bool IsErrorVisible
        {
            get { return ErrorMessage?.Length > 0 ? true: false ; }
            
        }

        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value;
                NotifyOfPropertyChange(() => IsErrorVisible);
                NotifyOfPropertyChange(() => ErrorMessage);
            }
        }




        public async Task Login()
        {
            try
            {
                ErrorMessage = "";
                var result = await _apiHelper.Authenticate(UserName, Password);
               
            }   catch(Exception ex)
            {
                ErrorMessage = ex.Message;
            }  
        }

     


    }
}
