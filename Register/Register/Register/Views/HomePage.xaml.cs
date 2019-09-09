using Register.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Register.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Register.Models;

namespace Register.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage(ContactModel contacto)
        {
            InitializeComponent();
            BindingContext = new ContactViewModel(contacto);
        }

        
    }
}