using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana1EdisonMendozaB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            
                double dato1 = Convert.ToDouble(txtDato1.Text);
                double dato2 = Convert.ToDouble(txtDato2.Text);
                double seguimiento1 = (dato1 * 0.30);
                double examen1 = (dato2 * 0.20);
                double notaparcial1 = seguimiento1 + examen1;
                txtResultado.Text = notaparcial1.ToString();

            {
                double dato3 = Convert.ToDouble(txtDato3.Text);
                double dato4 = Convert.ToDouble(txtDato4.Text);
                double seguimiento2 = (dato3 * 0.30);
                double examen2 = (dato4 * 0.20);
                double notaparcial2 = seguimiento2 + examen2;
                txtResultado1.Text = notaparcial2.ToString();
                double final = notaparcial1 + notaparcial2;
                txtFinal.Text = final.ToString();
                

                
            }
            
                
               

            
            
            
        }



        private void btnSumar2_Clicked(object sender, EventArgs e)
        {
            

        }

        private void btnResultado_Clicked(object sender, EventArgs e)
        {
            
         



        }
    }
}
