using System;
using System.Collections.Generic;
using System.Linq;
using JCSystem.Core.Repositories.Interface;
using JCSystem.Core.Repositories.Models;
using JCSystem.Shared.Configuration;
using JCSystem.Shared.Models;

namespace JCSystem.Core.Repositories
{

	public class SongsManager : ISongsManager
	{
	    private readonly ConnectionStrings _connectionStrings;
	    private static int UPPERLIMIT;
        private static int _lastRandNumber;
        
        private static string[] _uniqueTitles;
        private static string[] _uniqueartists;

	    public SongsManager(ConnectionStrings connectionStrings)
	    {
		    _connectionStrings = connectionStrings;
	    }
        public Song GetSong(int songid)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var so = db.Songs.SingleOrDefault(s => s.Id == songid && s.Status != Status.Delete);
		        db.Dispose();
		        return so;
	        }
        }

        public Song GetRandom()
        {
	        using (var db = new SongContext(_connectionStrings))
			{ 
		        if (UPPERLIMIT < 1)
		        {
			        UPPERLIMIT = db.Songs.Count();

		        }
		        if (UPPERLIMIT < 1)
			        return null;

		        var rand = new Random();
		        var generated = rand.Next(1, UPPERLIMIT + 1);
		        var counter = 50;
		        while (counter > 0)
		        {
			        if (generated == _lastRandNumber)
			        {
				        while (generated == _lastRandNumber)
				        {
					        generated = rand.Next(1, UPPERLIMIT + 1);
				        }
			        }

			        var song = GetSong(generated);

			        if (song != null)
			        {
				        _lastRandNumber = generated;
				        return song;
			        }
			        else
				        generated = rand.Next(1, UPPERLIMIT + 1);
			        counter++;
		        }
		        return null;
	        }
        }

        public int SongCounts(SearchOptions option)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var count = 0;
		        switch (option)
		        {
			        case SearchOptions.All:
				        count = db.Songs.Count(s => s.Status != Status.Delete);
				        break;
			        case SearchOptions.Complete:
				        count = db.Songs.Count(s => s.Status == Status.Active);
				        break;
			        case SearchOptions.Incomplete:
				        count = db.Songs.Count(s => s.Status == Status.Incomplete);
				        break;
			        case SearchOptions.New:
				        count = db.Songs.Count(s => s.Status == Status.New);
				        break;


		        }
		        db.Dispose();

		        return count;
	        }
        }

        public List<Song> GetSongs(DateTime lastModifiedDate)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var returnList =
			        db.Songs.Where(s => s.ModifiedDateTime >= lastModifiedDate).OrderBy(s => s.Title).ToList();
		        ;
		        return returnList;
	        }
        }
        public List<Song> GetSongs(SearchOptions option)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        List<Song> returnList = null;
		        switch (option)
		        {
			        case SearchOptions.All:
				        returnList = db.Songs.Where(s => s.Status != Status.Delete).OrderBy(p => p.Title).ToList();
				        break;
			        case SearchOptions.Complete:
				        returnList = db.Songs.Where(s => s.Status == Status.Active).OrderBy(s => s.Title).ToList();
				        break;
			        case SearchOptions.Incomplete:
				        returnList = db.Songs.Where(s => s.Status == Status.Incomplete).OrderBy(s => s.Title).ToList();
				        break;
			        case SearchOptions.New:
				        returnList = db.Songs.Where(s => s.Status == Status.New).OrderBy(s => s.Title).ToList();
				        break;
			        case SearchOptions.Custom:
				        returnList = db.Songs.Where(s => s.Id > 9036).OrderBy(s => s.Title).ToList();
				        break;
			        case SearchOptions.Duplicates:
				        var results = from so in db.Songs
					        group so by so.Title
					        into Group
					        where Group.Count() > 1
					        select new {key = Group.Key, songs = Group};
				        returnList = new List<Song>();
				        foreach (var g in results)
				        {
					        foreach (var s in g.songs)
					        {
						        returnList.Add(s);
					        }
				        }
				        break;

		        }

		        return returnList;
	        }
        }

        public string[] GetSuggestedTitles()
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        if (_uniqueTitles == null || _uniqueTitles.Length < 1)
		        {
			        _uniqueTitles = (from so in db.Songs select so.Title).Distinct().ToArray();
		        }


		        return _uniqueTitles;
	        }
        }

        public string[] GetSuggestedArtists()
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        if (_uniqueartists == null || _uniqueartists.Length < 1)
		        {
			        _uniqueartists = (from so in db.Songs select so.Artist).Distinct().ToArray();
		        }


		        return _uniqueartists;
	        }
        }

        public List<Song> GetSongs(string title)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var results = db.Songs.Where(s => s.Title.Equals(title)).OrderBy(s => s.Title);
		        return results.OrderBy(s => s.Title).ToList();
	        }
        }

        public List<Song> GetSongsByTitleAndArtist(string title, string artist)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var results = db.Songs.Where(s => s.Title.Equals(title) && s.Artist.Equals(artist)).OrderBy(s => s.Title);
		        return results.OrderBy(s => s.Title).ToList();
	        }
        }

        public List<Song> GetSongsByAlpha(string alpha)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var results = db.Songs.Where(s => s.Status != Status.Delete && s.Alpha.Equals(alpha)).OrderBy(s => s.Title);
		        return results.ToList();
	        }
        }

        //public List<RankedSong> SearchSongs(string keywords, SearchOptions option)
        //{
        //    return SearchSongs(keywords, option, DateTime.Now);
        //}


        //public List<RankedSong> SearchSongs(string keywords, SearchOptions option,DateTime cutoffDate)
        //{
        //    keywords = keywords.Trim().Replace(" ", "+");
	       // using (var db = new SongContext(_connectionStrings))
	       // {
		      //  var songs = new List<RankedSong>();

		      //  switch (option)
		      //  {
			     //   case SearchOptions.Singer:
				    //    var results1 = db.udf_SongsSearchArtist(keywords, cutoffDate);
				    //    if (results1 != null)
				    //    {
					   //     foreach (var re in results1)
					   //     {
						  //      var s = new RankedSong();
						  //      s.Title = re.Title;
						  //      s.Id = re.SongId;
						  //      s.Artist = re.Artist;
						  //      s.Cutline = re.Cutline;
						  //      s.Rank = re.RANK.Value;
						  //      s.AlbumName = re.AlbumName;
						  //      s.songIcon = SongImageType(re.SongId);
						  //      songs.Add(s);
					   //     }
				    //    }
				    //    var zingResults3 = db.udf_ZingSingerSearch(keywords);
				    //    if (zingResults3 != null)
				    //    {
					   //     foreach (var re in zingResults3)
					   //     {
						  //      var s = new RankedSong();
						  //      s.Title = re.Title;
						  //      s.Id = re.Id;
						  //      s.Artist = re.singer;
						  //      s.Cutline = re.Cutline;
						  //      s.Rank = re.RANK.Value;
						  //      s.songIcon = SongImageType(re.Id);
						  //      songs.Add(s);
					   //     }
				    //    }
				    //    break;
			     //   case SearchOptions.Lyric:
				    //    var results2 = db.udf_SongsSearchLyrics(keywords, cutoffDate);
				    //    if (results2 != null)
				    //    {
					   //     foreach (var re in results2)
					   //     {
						  //      var s = new RankedSong();
						  //      s.Title = re.Title;
						  //      s.Id = re.SongId;
						  //      s.Artist = re.Artist;
						  //      s.Cutline = re.Cutline;
						  //      s.Rank = re.RANK.Value;
						  //      s.AlbumName = re.AlbumName;
						  //      s.songIcon = SongImageType(re.SongId);
						  //      songs.Add(s);
					   //     }
				    //    }

				    //    var zingResults2 = db.udf_ZingLyricSearch(keywords);
				    //    if (zingResults2 != null)
				    //    {
					   //     foreach (var re in zingResults2)
					   //     {
						  //      var s = new RankedSong();
						  //      s.Title = re.Title;
						  //      s.Id = re.Id;
						  //      s.Artist = re.singer;
						  //      s.Cutline = re.Cutline;
						  //      s.Rank = re.RANK.Value;
						  //      s.songIcon = SongImageType(re.Id);
						  //      songs.Add(s);
					   //     }
				    //    }
				    //    break;
			     //   default:
				    //    var results = db.udf_SongsSearch(keywords, cutoffDate);
				    //    if (results != null)
				    //    {
					   //     foreach (var re in results)
					   //     {
						  //      var s = new RankedSong();
						  //      s.Title = re.Title;
						  //      s.Id = re.SongId;
						  //      s.Artist = re.Artist;
						  //      s.Cutline = re.Cutline;
						  //      s.Rank = re.RANK.Value;
						  //      s.AlbumName = re.AlbumName;
						  //      s.songIcon = SongImageType(re.SongId);
						  //      songs.Add(s);
					   //     }
				    //    }

				    //    var zingResults = db.udf_ZingSearch(keywords);
				    //    if (zingResults != null)
				    //    {
					   //     foreach (var re in zingResults)
					   //     {
						  //      var s = new RankedSong();
						  //      s.Title = re.Title;
						  //      s.Id = re.Id;
						  //      s.Artist = re.singer;
						  //      s.Cutline = re.Cutline;
						  //      s.songIcon = SongImageType(re.Id);
						  //      s.Rank = re.RANK.Value;
						  //      songs.Add(s);
					   //     }
				    //    }
				    //    break;
		      //  }

		      //  return songs.OrderByDescending(s => s.Rank).ToList();

	       // }

        //}

        public List<Song> GetFeatureSongs()
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var results = from so in db.Songs
			        where so.Status != Status.Delete && so.Featured
			        orderby so.Id descending
			        select so;
		        return results.ToList();
	        }
        }
        public void DeleteSong(int songid)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var s = db.Songs.SingleOrDefault(p => p.Id == songid);
		        if (s != null)
		        {
			        s.Status = Status.Delete;
			        s.ModifiedDateTime = DateTime.Now;
		        }
		        //db.Songs.DeleteOnSubmit(s);
		        db.SaveChanges();
	        }
        }

        public int AddSong(Song s)
        {
            s.ModifiedDateTime = DateTime.Now;
            s.CreateDateTime = DateTime.Now;
	        using (var db = new SongContext(_connectionStrings))
	        {
		        db.Songs.Add(s);
		        db.SaveChanges();
	        }

	        return s.Id;
        }

        public void UpdateSong(Song s)
        {
			using (var db = new SongContext(_connectionStrings))
			{
				var so = db.Songs.SingleOrDefault(sn => sn.Id == s.Id);
				if (so != null)
				{
					so.Artist = s.Artist;
					so.Title = s.Title;
					so.MusicType = s.MusicType;
					so.Production = s.Production;
					so.Mode = s.Mode;
					so.Gender = s.Gender;
					so.Lyric = s.Lyric;
					so.Cutline = s.Cutline;
					so.VideoQuality = s.VideoQuality;
					so.Language = s.Language;
					so.Status = s.Status;
					so.AlbumName = s.AlbumName;
					so.ModifiedDateTime = DateTime.Now;
					so.Featured = s.Featured;
					so.VocalTrack = s.VocalTrack;
					so.Composer = s.Composer;
					db.SaveChanges();
				}
			}
        }

        public void UpdateSong(int songId, string title, string singer, int genderId, int vocalTrack, string alpha, 
            string listeningUrl, string watchVideo, string composer, int statusId, string cutline)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var so = db.Songs.SingleOrDefault(sn => sn.Id == songId);
		        if (so == null) return;

		        so.Artist = singer;
		        so.Title = title;
		        so.Alpha = alpha;
		        so.ListeningUrl = listeningUrl;
		        so.WatchUrl = watchVideo;
		        so.Gender = (Gender)genderId;
		        so.ModifiedDateTime = DateTime.Now;
		        so.VocalTrack = vocalTrack;
		        so.Composer = composer;
		        so.Status = (Status)statusId;
		        so.Cutline = cutline;
		        db.SaveChanges();
	        }
        }

        public void UpdateFilePath(int songid, string path)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var s = db.Songs.SingleOrDefault(p => p.Id == songid);
		        if (s == null) return;
		        s.FilePath = path;
		        s.ModifiedDateTime = DateTime.Now;
		        db.SaveChanges();
	        }
        }

        public List<Song> GetTop20PlayedSongs()
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var results = (from so in db.Songs orderby so.PlayedCount descending select so).Take(20);
		        var returnedList = results.ToList();
		        db.Dispose();
		        return returnedList;
	        }
        }

        public void PlayedCounter(int songid) 
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        Song s = db.Songs.SingleOrDefault(so => so.Id == songid);
		        if (s != null)
		        {
			        
			        s.PlayedCount += 1;
			        db.SaveChanges();
		        }
	        }
        }

        public string SongImageType(int soId)
        {
            return soId > 50000 ? "/App_Themes/Images/zing.png" : "/App_Themes/Images/video.png";
        }


        private static string VerifyCutline(string cutline)
        {
            if (string.IsNullOrEmpty(cutline))
                return cutline;

            var delim = new string[1];
            delim[0] = " ";
            var words = cutline.Split(delim, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length < 16)
                return cutline;
            var w = words.Take(15).ToArray();
            return String.Join(" ", w);
        }


        //#endregion
        //#region Categorized Tables

        //public List<Mood> GetMoods()
        //{
	       // using (var db = new SongContext(_connectionStrings))
	       // {
		      //  return db.Moods.ToList();
	       // }
        //}

        //public List<MusicType> GetMusicTypes()
        //{
	       // using (var db = new SongContext(_connectionStrings))
	       // {
		      //  return db.MusicTypes.ToList();
	       // }
        //}

        //public List<Production> GetProductions()
        //{
	       // using (var db = new SongContext(_connectionStrings))
	       // {
		      //  return db.Productions.ToList();
	       // }
        //}

        //#endregion

        
    }

    public class RankedSong : Song
    {
        public int Rank
        {
            get;
            set;
        }

        public string InQueueString
        {
            get;
            set;
        }

        public string songIcon { get; set; }
    }
}
