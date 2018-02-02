using System.Collections.Generic;

namespace JCSystem.Core.Repositories.Models
{
    public class User:EntityBase
    {
		public virtual List<FavoriteSong> FavoriteSongs { get; set; }
	    public string Password { get; set; }
	    public string UserName { get; set; }
	    public Role Role { get; set; }
	    public string LastMachineName { get; set; }
    }

	public enum Role
	{
		Admin,
		User
	}
}
