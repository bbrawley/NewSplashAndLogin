using NewSplashAndLogin.Views;
using System;
using Xamarin.Forms;

namespace NewSplashAndLogin.Droid
{
    internal class App : Application
    {
        //public partial class App : Application
       // {
            public App()
            {
                InitializeComponent();
                MainPage = new LoginPage();
            }
   // ...
private void InitializeComponent()
            {
                throw new NotImplementedException();
            }
       // }
    }
}