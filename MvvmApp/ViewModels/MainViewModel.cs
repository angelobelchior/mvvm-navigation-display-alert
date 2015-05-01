using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ViewModels
{
	public class MainViewModel : ViewModelBase
	{
		public ICommand RegisterCommand {
			get;
			set;
		}

		private readonly Services.IMessageService _messageService;
		private readonly Services.INavigationService _navigationService;
		public MainViewModel ()
		{
			this.RegisterCommand = new Command (this.Register);

			this._messageService = DependencyService.Get<Services.IMessageService> ();
			this._navigationService = DependencyService.Get<Services.INavigationService> ();
		}

		private async void Register()
		{
			await this._messageService.ShowAsync ("Vou para a Register View");
			await this._navigationService.NavigateToRegister ();
		}
	}
}

