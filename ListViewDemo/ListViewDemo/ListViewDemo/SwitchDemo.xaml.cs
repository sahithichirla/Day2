using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwitchDemo : ContentPage
    {
        public SwitchDemo()
        {
            InitializeComponent();
        }
        //private void Switch_Toggled(object sender, ToggledEventArgs e)
        //{
        //    l1.IsVisible = e.Value;
        //}
    }
}