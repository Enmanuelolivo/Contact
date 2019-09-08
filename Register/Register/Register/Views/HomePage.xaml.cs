using Register.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Register.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Register.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new ContactViewModel();
        }

         void Añadir(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new AddContactPage()));
        }
    }
}