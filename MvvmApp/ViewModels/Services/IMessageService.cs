using System;
using System.Threading.Tasks;

namespace ViewModels.Services
{
	public interface IMessageService
	{
		Task ShowAsync(string message);
	}
}