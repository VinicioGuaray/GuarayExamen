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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario,string nombre,double total)
        {
            InitializeComponent();
            txtNombre.Text = nombre;
            txtUsuario.Text = usuario;
            txtTotalPago.Text = total.ToString();
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Salir", "Suerte en tu curso...", "Ok");
            System.Environment.Exit(0);


        }
    }
}