using System.Collections.Generic;
using System.Linq;
using JCSystem.Core.Repositories.Interface;
using JCSystem.Core.Repositories.Models;
using JCSystem.Shared.Configuration;

namespace JCSystem.Core.Repositories
{
    public class FavsManager : IFavsManager
	{
	    private readonly ConnectionStrings _connectionStrings;

	    public FavsManager(ConnectionStrings connectionStrings)
	    {
		    _connectionStrings = connectionStrings;
	    }
        public void AddFavs(FavoriteSong fav)
        {
			using (var db = new SongContext(_connectionStrings))
			{
				db.FavoriteSongs.Add(fav);
		        db.SaveChanges();
	        }
        }

        public void AddFavs(int songid, int userId)
        {
            if (GetFavSong(songid, userId) == null)
            {
                var fa = new FavoriteSong
                {
                    SongId = songid,
                    UserId = userId
                };
                AddFavs(fa);
            }
        }

        public void DeleteFavs(int favId)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var fav = db.FavoriteSongs.SingleOrDefault(f => f.Id == favId);
		        if (fav != null)
		        {
			        db.FavoriteSongs.Remove(fav);
			        db.SaveChanges();
		        }
	        }
        }

        public List<Song> GetFavsByUser(int userId)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var user = db.Users.SingleOrDefault(x=>x.Id==userId);
		        var favList = new List<Song>();
		        if (user == null ||!user.FavoriteSongs.Any() ) return favList;
		        
			        foreach (var f in user.FavoriteSongs)
			        {
				        var song = db.Songs.SingleOrDefault(x => x.Id == f.SongId);
				        if (song != null)
				        {
					        favList.Add(song);
				        }
				        else
				        {
					        DeleteFavs(f.Id);
				        }

			        }
		        
		        return favList.OrderBy(f => f.ProperTitle).ToList();
	        }
        }

        public FavoriteSong GetFavSong(int favId)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        return db.FavoriteSongs.SingleOrDefault(f => f.Id == favId);
	        }
        }

        public  FavoriteSong GetFavSong(int songid, int userId)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        return db.FavoriteSongs
			        .SingleOrDefault(f => f.UserId == userId && f.SongId == songid);
	        }
        }
    }

    public class ExtendedKaraokeFavorite : FavoriteSong
    {
        public string SongTitle
        {
            get;
            set;
        }

        public string Singer
        {
            get;
            set;
        }

        public string InQueueString
        {
            get;
            set;
        }
    }
}
