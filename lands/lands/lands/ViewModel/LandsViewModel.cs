
namespace lands.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    using Models;
    using Services;
    using Xamarin.Forms;
    public class LandsViewModel: BaseViewModel
    {
        #region Services
        private ApiService apiService;
        #endregion

        //Lista de países
        #region Attributes
        private ObservableCollection<Land> lands;
        #endregion
        
        #region Properties
        public ObservableCollection<Land> Lands
        {
            get { return this.lands; }
            set { SetValue(ref this.lands, value); }
        }
        #endregion

        #region Constructores
        //Cargar los países
        public LandsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadLands();
        }
        #endregion

        #region Methods
        private async void LoadLands()
        {
            //Tiene 3 sobrecargar
            //urlbase
            //prefijo
            //el controlador

            //Checar la conexión
            var connection = await this.apiService.CheckConnection();

            if (!connection.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    connection.Message,
                    "Accept");
                //Metodo para apilar push
                //Metodo para desapilar pup
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
                
            }

            var response = await this.apiService.GetList<Land>(
                "https://restcountries.eu",
                "/rest",
                "/v2/all");

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Accept");
                return;
            }

            var list = (List<Land>)response.Result;
            this.Lands = new ObservableCollection<Land>(list);
        }
        #endregion
    }
}
