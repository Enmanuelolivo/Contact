using Register.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Register.ViewModels
{
   public class AddContactViewModel:INotifyPropertyChanged
    {
        public ICommand AddNewContact { get; set; }

        public ContactModel Contacto { get; set; } = new ContactModel();
        public event PropertyChangedEventHandler PropertyChanged;


        public AddContactViewModel(ContactModel contact)
        {
            AddNewContact = new Command<ContactModel>((param) =>
            {
            
            MessagingCenter.Send<AddContactViewModel, ContactModel>(this, "NuevoContacto", Contacto);

            });
        }
    }
}
