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
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Login(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LoginForm());

        }

        private void Register(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Reg());

        }
    }
}