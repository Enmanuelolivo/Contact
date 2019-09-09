using Register.Models;
using Register.ViewModels;
using System;
using System.Collections.Generic;
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
        public AddContactPage(ContactModel contact)
        {
            InitializeComponent();
            BindingContext = new AddContactViewModel(contact);
        }
    }
  }


