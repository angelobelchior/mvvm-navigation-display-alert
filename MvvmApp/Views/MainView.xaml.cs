using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Views
{
	public partial class MainView : ContentPage
	{
		public MainView ()
		{
			InitializeComponent ();
			this.BindingContext = new ViewModels.MainViewModel ();
		}
	}
}

