using Register.Models;
using Register.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Register.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactPage : ContentPage
    {
        public AddContactPage()
        {
            InitializeComponent();
            BindingContext = new ContactViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            ContactModel NewContact = new ContactModel()
            {
                Nombre = Name.Text,

                Telefono = Phone.Text
            };

            MessagingCenter.Send(NewContact, "Nuevo Contacto Añadido");

         


        }
    }
}
