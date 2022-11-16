using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
namespace TEA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Test_TEA : ContentPage
    {
        public Test_TEA()
        {
            InitializeComponent();
        }

        private void btntest_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("http://espectroautista.info/MCHAT-es.html",BrowserLaunchMode.SystemPreferred);
                            
        }

        private void btntest_Clicked_1(object sender, EventArgs e)
        {

        }

        private void btnsiguiente_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}