using System;
using System.Collections.Generic;
using System.Text;

namespace lands.Infrastructure
{

    using ViewModel;
    public class InstanceLocator
    {
        //Servir para encontrar los viewmodel
        #region Properties
            //Propiedad de tipo MainViewModel
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion
        //crt y tab tab para crear un constructor rápido
        #region Constructors
        public InstanceLocator()
        {
            //Pátron de diseno
            this.Main = new MainViewModel();       
        }
        #endregion
    }


}
