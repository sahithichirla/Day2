using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactPage : ContentPage
	{
		public ContactPage ()
		{
			InitializeComponent ();
            list1.ItemsSource = new List<Contact>{

                new Contact { Name = "abc", ImageUrl = "http://lorempixel.com/100/100/people/1",Status = "Hey, let's talk!" },

                new Contact { Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, let's talk!" }

            };
        }
        public class Contact

        {

            public string Name { get; set; }

            public string Status { get; set; }

            public string ImageUrl { get; set; }

        }

        private void List1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
        }
    }
}