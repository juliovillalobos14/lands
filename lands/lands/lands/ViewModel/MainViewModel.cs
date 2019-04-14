

namespace lands.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    //Esta es la clase más importante de todas
    public class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }
        #endregion
        //Instanciar en el constructor
        #region Constructors
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
        #endregion


    }


}
