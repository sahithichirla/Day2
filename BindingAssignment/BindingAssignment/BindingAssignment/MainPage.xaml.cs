using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BindingAssignment
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Entry entry = new Entry();

            // Create a Label
            Label label = new Label();

            // Set up binding between Entry's Text property and Label's Text property
            label.SetBinding(Label.TextProperty, new Binding("Text", source: entry));

            // Add Entry and Label to the layout
            StackLayout stackLayout = new StackLayout();
            stackLayout.Children.Add(entry);
            stackLayout.Children.Add(label);

            // Set the content of the page
            Content = stackLayout;
        }
    }
}
