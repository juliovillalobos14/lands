

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
        //No se carga en el constructor
        public LandsViewModel Lands
        {
            get;
            set;
        }
        #endregion
        //Instanciar en el constructor
        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Sinlgeton
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }

        #endregion

    }


}
