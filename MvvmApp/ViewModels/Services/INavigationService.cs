using System;
using System.Threading.Tasks;

namespace ViewModels.Services
{
	public interface INavigationService
	{
		Task NavigateToLogin();
		Task NavigateToRegister();
		Task NavigateToMain();
	}
}