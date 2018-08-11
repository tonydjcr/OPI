using System;
using System.Collections.Generic;
using System.Text;

namespace OPI.ViewModels
{

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
            get;
            set;
        }
        #endregion
    }
}
