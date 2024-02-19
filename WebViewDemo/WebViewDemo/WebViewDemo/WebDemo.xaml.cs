using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebViewDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebDemo : ContentPage
    {
        public WebDemo()
        {
            InitializeComponent();
            var browser = new WebView();

            var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"
            <html>
                <body>

                    <h1>Xamarin.Forms</h1>

                    <p>Welcome to WebView.</p>

                </body>
            </html> ";

            browser.Source = htmlSource;
        }
        void webviewNavigating(object sender, WebNavigatingEventArgs e)

        {

            labelLoading.IsVisible = true;

        }

        void webviewNavigated(object sender, WebNavigatedEventArgs e)

        {

            labelLoading.IsVisible = false;

        }
    }
}
   