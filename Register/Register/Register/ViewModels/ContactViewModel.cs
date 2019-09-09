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

       
        public ContactViewModel(ContactModel contacto)
        {
         
            AddContact = new Command(async () =>
            {
                string N = contacto.Nombre;
                string T = contacto.Telefono;
                Contacts.Add(contacto);

                MessagingCenter.Subscribe<AddContactViewModel, ContactModel>(this, "NuevoContacto", ((sender, param) =>
                {
                    Contacts.Add(param);
                    MessagingCenter.Unsubscribe<AddContactViewModel,ContactModel>(this, "NuevoContacto");
                }));
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new AddContactPage(new ContactModel())));

            });
        }
    }
}
