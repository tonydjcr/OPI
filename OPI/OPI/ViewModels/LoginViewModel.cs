using System;
using System.Collections.Generic;
using System.Text;

namespace OPI.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;

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

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Usuario))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debe ingresar su nombre de usuario.",
                    "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.Contrasena))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debe ingresar su contraseña.",
                    "Aceptar");
                return;
            }

            if (this.Usuario != "tony" || this.Contrasena != "hola")
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Usuario o contrasena incorrecta",
                    "Aceptar");
                return;
            }
        }
        #endregion
    }
}
