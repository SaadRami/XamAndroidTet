using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamMobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DefinirUtilisateur(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Views.EnregistrerUtilisateur());
        }

        protected override void OnAppearing()
        {
            SetWelcomeMessage();
        }

        private void SetWelcomeMessage()
        {
            String StrWelcomeMessage = "Bienvenue dans l'application ";

            if (Application.Current.Properties.ContainsKey("username"))
            {
                StrWelcomeMessage += Application.Current.Properties["username"] as string;
            }
            else
            {
                StrWelcomeMessage += "Utilisateur non enregistré";
            }

            welcomeMessage.Text = StrWelcomeMessage;
        }
    }
}
