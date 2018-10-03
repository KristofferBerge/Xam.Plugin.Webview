using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp.Samples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserAgentSample : ContentPage
    {
        public UserAgentSample()
        {
            InitializeComponent();
            webViewElement.UserAgent = "CustomUserAgent";
            webViewElement.Source = "https://kristofferberge.no/static/useragent.html";
        }
    }
}