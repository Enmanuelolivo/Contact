using Register.Models;
using Register.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Register.ViewModels
{
    public class ContactViewModel:INotifyPropertyChanged
    {
        public ContactModel contacto { get; set; } = new ContactModel();
        public ObservableCollection<ContactModel> Contacts { get; set; } = new ObservableCollection<ContactModel>();
        public ICommand AddContact { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;


        public ContactViewModel()
        {
            ContactModel micontacto = new ContactModel();
            micontacto.Nombre = "Juan";
            micontacto.Telefono = "8298042221";
            Contacts.Add(micontacto);

            AddContact = new Command(async () =>
            {
                string N = micontacto.Nombre;
                string T = micontacto.Telefono;
                Contacts.Add(micontacto);
                MessagingCenter.Send<ContactViewModel, ContactModel>(this, "newContact",micontacto);

                await App.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new HomePage()));
            });
        }
    }
}
