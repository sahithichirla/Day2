using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginReg
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginForm : ContentPage
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

            if (username == "admin" && password == "admin")
            {

                Navigation.PushModalAsync(new WelcomePage());

            }
            else
            {

                DisplayAlert("Error", "Invalid username or password", "OK");
            }
        }
    }
}