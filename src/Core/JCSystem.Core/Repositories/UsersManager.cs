using System;
using System.Collections.Generic;
using System.Linq;
using JCSystem.Core.Repositories.Interface;
using JCSystem.Core.Repositories.Models;
using JCSystem.Shared.Configuration;

namespace JCSystem.Core.Repositories
{
    public class UsersManager : IUsersManager
	{
	    private readonly ConnectionStrings _connectionStrings;

	    public UsersManager(ConnectionStrings connectionStrings)
	    {
		    _connectionStrings = connectionStrings;
	    }
        public  User RegisterUser(string username, string password)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        if (IsUserNameExisted(username))
		        {
			        throw new Exception("Username is already existed");
		        }
		        var user = new User
		        {
			        Password = password,
			        UserName = username,
			        CreateDateTime = DateTime.Now,
			        Role = Role.Admin
		        };
		        db.Users.Add(user);
		        db.SaveChanges();
		        return user;
	        }
        }

        private bool IsUserNameExisted(string username)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        int found = db.Users.Count(u => u.UserName == username);
		        return found > 0;
	        }
        }

        public User UserLogin(string user, string password, string machineName)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var usr = db.Users.SingleOrDefault(u => u.UserName == user && u.Password == password);
		        if (usr == null)
			        return null;

		        usr.ModifiedDateTime = DateTime.Now;
		        usr.LastMachineName = machineName;
		        db.SaveChanges();

		        return usr;
	        }
        }

        public List<User> GetLastFiveActiveUsers(string machineName)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var users = db.Users.Where(u => u.LastMachineName == machineName).OrderByDescending(u => u.ModifiedDateTime);
		        return users.Count() > 5 ? users.Take(5).ToList() : users.ToList();
	        }
        }
    }
}
