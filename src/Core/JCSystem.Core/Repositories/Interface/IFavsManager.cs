using System.Collections.Generic;
using JCSystem.Core.Repositories.Models;

namespace JCSystem.Core.Repositories.Interface
{
	public interface IFavsManager
	{
		void AddFavs(FavoriteSong fav);
		void AddFavs(int songid, int userId);
		void DeleteFavs(int favId);
		List<Song> GetFavsByUser(int userId);
		FavoriteSong GetFavSong(int favId);
		FavoriteSong GetFavSong(int songid, int userId);
	}
}