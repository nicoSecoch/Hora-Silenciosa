﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HSpdv
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void IniciarSesion(object sender, EventArgs args)
        {
            if (txtCorreo.Text == "Correo@correo.cl" && txtContra.Text == "1234")
            {
                DisplayAlert("Mensaje", "Sesion Iniciada", "OK");
            }
            else
            {
                DisplayAlert("Mensaje", "Usuario y/o Contraseña Incorrectos", "OK");
            }
            
        }
    }
}
