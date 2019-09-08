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
   public class RegisterLogViewModel:INotifyPropertyChanged
    {
       public RegisterModel RData { get; set; }
        public ICommand SaveRegister { get; set; }

        public string R { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public RegisterLogViewModel()
        {
            RData = new RegisterModel();
            SaveRegister = new Command(async () =>
             {
                 if (!Validations.NotEmpty(RData.Name))
                 {
                     R = "El Nombre esta vacio";
                 }
                 else if (!Validations.NotEmpty(RData.LastName))
                 {
                     R = "El Apellido esta vacio";
                 }
                 else if(!Validations.ValidateEmail(RData.Email))
                 {
                     R = "Esto no es un Correo Valido";
                 }
                 else if (!Validations.NotEmpty(RData.Email))
                 {
                     R = "Este Correo esta vacio";
                 }
                 else if (!Validations.NotEmpty(RData.Password) || !Validations.NotEmpty(RData.PasswordConfirm))
                 {
                     R = "Se requiere Contraseña";

                 }
                 else if (!Validations.PassVerification(RData.Password,RData.PasswordConfirm))
                 {
                     R = "Contraseñas no coinciden";
                 }

                 else
                 {
                     await App.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new HomePage()));
                 }
             }
            );


        }
    }
}
