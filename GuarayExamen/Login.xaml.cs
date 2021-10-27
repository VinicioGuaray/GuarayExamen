using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuarayExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string password = txtPassword.Text;

                if (usuario == " ")
                {
                    await DisplayAlert("Error", "El usuario no debe estar vacio", "Ok");
                }
                else if (password == " ")
                {
                    await DisplayAlert("Error", "El password no debe estar vacio", "Ok");
                }
                else
                {
                    if (usuario == "estudiante2021" && password == "uisrael2021")
                    {
                        await Navigation.PushAsync(new Registro(usuario));
                    }
                    else
                    {
                        await DisplayAlert("Error", "Usuario o Password incorrectos", "ok");
                        txtPassword.Text = " ";
                        txtUsuario.Text = " ";
                    }
                }
            }catch(Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "ok");
            }
        }
    }
}