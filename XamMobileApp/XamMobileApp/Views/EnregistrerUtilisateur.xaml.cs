using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnregistrerUtilisateur : ContentPage
    {
        public EnregistrerUtilisateur()
        {
            InitializeComponent();
        }

        private void EnregistrerPrenom(object sender, EventArgs e)
        {
            Application.Current.Properties["username"] = this.prenom.Text;
            this.Navigation.PopAsync();
        }
    }
}