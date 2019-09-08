using Register.Helpers;
using Register.Models;
using Register.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Register.ViewModels
{
   public class LoginViewModel:INotifyPropertyChanged
    {
        public Login U { get; set; }
        public ICommand SaveData { get; set; }
        public ICommand RegisterPage { get; set; }

        public string r { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginViewModel()
        {
            U = new Login();
            SaveData = new Command(async () =>
             {
                 if (!Validations.NotEmpty(U.User))
                 {
                     r = "Este campo esta vacio";
                 }
                 else if (!Validations.NotEmpty(U.password))
                 {
                     r = "Este campo esta vacio";
                 }
                 else
                 {
                     await App.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new HomePage()));
                 }

                 RegisterPage = new Command(async () =>
                  {
                      await App.Current.MainPage.Navigation.PushModalAsync(new RegisterPage());
                  });

             });
        }
      
    }
}
