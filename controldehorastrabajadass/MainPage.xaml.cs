using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace controldehorastrabajadass
{
    public partial class MainPage : ContentPage
    {
        private DateTime fechaInicio;
        private TimeSpan tiempoTrabajadoDiario;
        private TimeSpan tiempoTrabajadoSemanal;
        private TimeSpan tiempoTrabajadoMensual;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnStartClicked(object sender, EventArgs e)
        {
            fechaInicio = DateTime.Now;
        }

        private void OnStopClicked(object sender, EventArgs e)
        {
            if (fechaInicio != DateTime.MinValue)
            {
                TimeSpan tiempoTrabajadoActual = DateTime.Now - fechaInicio;
                tiempoTrabajadoDiario += tiempoTrabajadoActual;
                tiempoTrabajadoSemanal += tiempoTrabajadoActual;
                tiempoTrabajadoMensual += tiempoTrabajadoActual;
                fechaInicio = DateTime.MinValue;
                ActualizarEtiquetas();
            }
        }

        private void ActualizarEtiquetas()
        {
            lblHorasDiarias.Text = tiempoTrabajadoDiario.ToString(@"hh\:mm\:ss");
            lblHorasSemanales.Text = tiempoTrabajadoSemanal.ToString(@"hh\:mm\:ss");
            lblHorasMensuales.Text = tiempoTrabajadoMensual.ToString(@"hh\:mm\:ss");
        }
    }
}

