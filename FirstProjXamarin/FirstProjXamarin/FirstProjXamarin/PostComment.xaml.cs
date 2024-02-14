using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstProjXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostComment : ContentPage
    {
        public PostComment()
        {
            InitializeComponent();
        }

        private void OnPostClicked(object sender, EventArgs e)
        {
            
            string firstName = firstNameEntry.Text;
            string lastName = lastNameEntry.Text;
            string comments = commentsEntry.Text;

            string message = $"{firstName} {lastName}\n{comments}";
             DisplayAlert("Posted Comments", message, "OK");

            ClearEntries();
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            ClearEntries();
        }

        private void ClearEntries()
        {
            firstNameEntry.Text = string.Empty;
            lastNameEntry.Text = string.Empty;
            commentsEntry.Text = string.Empty;
        }
    }
}
