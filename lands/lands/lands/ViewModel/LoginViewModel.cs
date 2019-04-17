
namespace lands.ViewModel
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Text;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    //Heredamos una interfaz para actualizas
    public class LoginViewModel : BaseViewModel
    {
        

        #region Attributes
        private string password;
        private bool isRunning;
        private bool isEnabled;
        private string email;
        #endregion

        #region Properties
        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }
        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }
        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }
        public bool IsRemembered
        {
            get;
            set;
        }
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                //Este objeto usa el nugget ligh lymbs
                return new RelayCommand(Login);
            }
        }
        #endregion

        #region Metodos
        //Método de login
        //Método asincrono
        private async void Login()
        {
            //Validar que el usuario haya dígitado el email y password
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an email",
                    "Accept");
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an password",
                    "Accept");
            }

            this.isRunning = true;
            this.IsEnabled = false;


            //Mover a otra página cuando haga login
            if (this.Email != "jzuluaga55@gmail.com" || this.Password != "1234")
            {

                this.isRunning = false;
                this.IsEnabled = true;


                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email or password incorrect",
                    "Accept");
                this.Password = string.Empty;

                return;
            }

            this.isRunning = false;
            this.IsEnabled = true;


            this.Email = string.Empty;
            this.Password = string.Empty;

            //Lamada a la página de lands despues de hacer login
            MainViewModel.GetInstance().Lands = new LandsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new LandsPage());
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.isEnabled = true;

            //De manera temporal para entrar en automatico
            this.Email = "jzuluaga55@gmail.com";
            this.Password = "1234";

            //http://restcountries.eu            //rest/v2/all﻿
        }
        #endregion

    }
}
