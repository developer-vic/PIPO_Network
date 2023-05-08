using System;
using Xamarin.Forms;

namespace PIPO_Network
{
    public class WebPage : ContentPage
    {
        public WebPage()
        {
            var browser = new WebView();
            browser.Source = "https://lepipo.net/";
            Content = browser;
        }
    }
}
