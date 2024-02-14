using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FontSizeAssignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class page1 : ContentPage
    {
        public page1()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label1.Text = $"Font Size:{e.NewValue}";
            label2.FontSize = e.NewValue;
        }
    }
}