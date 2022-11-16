using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;

namespace TEA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Iniciar_Sesion : ContentPage
    {
        public Iniciar_Sesion()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "Admin" && txtContraseña.Text == "123")
            {
            /*Navigation.PushAsync(new Test_TEA());
            WebClient cliente = new WebClient();
            var parametros = new System.Collections.Specialized.NameValueCollection();
            parametros.Add("Usuario",txtUsuario.Text);
            parametros.Add("Contraseña", txtContraseña.Text);
            cliente.UploadValues("http:// 192.168.43.185:80/login_TEA.php", "POST", parametros);*/
               
                
           }
           else if (txtUsuario.Text != "Admin" && txtContraseña.Text != "123")
           {
             DisplayAlert("Alerta", "contraseña o correo electronico incorrecto", "ok");
           }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {

        }
    }
}