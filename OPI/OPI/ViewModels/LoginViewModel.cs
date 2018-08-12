using System;
using System.Collections.Generic;
using System.Text;

namespace OPI.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;

    public class LoginViewModel
    {
        #region Properties
        public String Usuario
        {
            get;
            set;
        }

        public String Contrasena
        {
            get;
            set;
        }

        public bool IsRunning
        {
            get;
            set;
        }

        public bool IsRemembered
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }

        }

        private void Login()
        {
            
        }
        #endregion
    }
}
