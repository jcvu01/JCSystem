using System.Collections.Generic;
using JCSystem.Core.Repositories.Models;

namespace JCSystem.Core.Repositories.Interface
{
	public interface IUsersManager
	{
		List<User> GetLastFiveActiveUsers(string machineName);
		User RegisterUser(string username, string password);
		User UserLogin(string user, string password, string machineName);
	}
}