﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hs.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecuperaPass : ContentPage
	{
		public RecuperaPass ()
		{
			InitializeComponent ();
		}
		private void Recuperar(object sender, EventArgs e)
		{
			DisplayAlert("Exito", "Clave Recuperada", "Aceptar");
		}
	}
}