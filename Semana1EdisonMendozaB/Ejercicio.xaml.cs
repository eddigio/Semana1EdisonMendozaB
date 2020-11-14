using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana1EdisonMendozaB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ejercicio : ContentPage
    {
        public Ejercicio()
        {
            InitializeComponent();
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            try
            {
                double dato1 = Convert.ToDouble(txtDato1.Text);
                double dato2 = Convert.ToDouble(txtDato2.Text);
                double suma = dato1 + dato2;
                txtResultado.Text = suma.ToString();

            }
            catch (Exception ex){
                DisplayAlert("Mensaje", "Erro" + ex.Message, "ok");

            }
           



        }
    }
}