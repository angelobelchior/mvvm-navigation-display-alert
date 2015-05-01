using System;

namespace Views.Services
{
	public class NavigationService : ViewModels.Services.INavigationService
	{
		#region INavigationService implementation

		public async System.Threading.Tasks.Task NavigateToLogin ()
		{
			await MvvmApp.App.Current.MainPage.Navigation.PushAsync (new Views.LoginView());
		}

		public async System.Threading.Tasks.Task NavigateToRegister ()
		{
			await MvvmApp.App.Current.MainPage.Navigation.PushAsync (new Views.RegisterView());
		}

		public async System.Threading.Tasks.Task NavigateToMain ()
		{
			await MvvmApp.App.Current.MainPage.Navigation.PushAsync (new Views.MainView());
		}

		#endregion

		public NavigationService ()
		{
		}
	}
}

