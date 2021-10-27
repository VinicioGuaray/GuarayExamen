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
    public partial class Registro : ContentPage
    {
        int total = 1800;
        double mensual;
        double totalPagar;
        double valorAgregado = 0.05;
        string nombre;
        string usuario;
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario conectado " + usuario;
           this.usuario = usuario;
        }

        private void btncalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                int montoInicial =Convert.ToInt32(txtMontoInicial.Text);
                 nombre = txtNombre.Text;
                if(nombre==" ") {
                    DisplayAlert("Error", "El nombre no debe estar vacio", "ok");
                }
                else if (montoInicial < 1 || montoInicial>1800)
                {
                    DisplayAlert("Error", "El monto inicial no debe ser menor a 1 o mayor a 1800","ok");
                }
                else
                {
                    mensual = total - montoInicial;
                 mensual = Math.Round((mensual / 3),2)+(total*valorAgregado);
                    txtPagoMensual.Text = mensual.ToString();
                    btnGuaradr.IsEnabled = true;
                    totalPagar = mensual * 3;
                }

            }catch(Exception ex)
            {
                 DisplayAlert("Error", ex.Message, "ok");
            }
        }

        private async void btnGuaradr_Clicked(object sender, EventArgs e)
        {
            try
            {
                await  Navigation.PushAsync(new Resumen(this.usuario, nombre, totalPagar));

            }catch(Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Ok");
            }
        }
    }
}