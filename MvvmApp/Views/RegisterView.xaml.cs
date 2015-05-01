using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Views
{
	public partial class RegisterView : ContentPage
	{
		public RegisterView ()
		{
			InitializeComponent ();
			this.BindingContext = new ViewModels.RegisterViewModel ();
		}
	}
}

