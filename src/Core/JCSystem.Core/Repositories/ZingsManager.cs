using System;
using System.Collections.Generic;
using System.Linq;
using JCSystem.Core.Repositories.Interface;
using JCSystem.Core.Repositories.Models;
using JCSystem.Shared.Configuration;

namespace JCSystem.Core.Repositories
{
   public class ZingsManager : IZingsManager
	{
	    private readonly ConnectionStrings _connectionStrings;

	    public ZingsManager(ConnectionStrings connectionStrings)
	    {
		    _connectionStrings = connectionStrings;
	    }
        public Zing GetZing(int id)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        return db.Zings.SingleOrDefault(s => s.Id == id && s.Status != Status.Delete);
	        }
        }

        public  bool IsExisted(int zingId)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        return db.Zings.Any(s => s.ZingId == zingId);
	        }
        }

        public List<Zing> GetZings()
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        return db.Zings.Where(z => z.Status != Status.Delete).OrderBy(s => s.Title).ToList();
	        }
        }

        public List<Zing> GetZings(DateTime lastModifiedDate)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        return
			        db.Zings.Where(s => s.ModifiedDateTime >= lastModifiedDate).OrderBy(s => s.Title).ToList();
		        
	        }
        }

        
        

        public List<Zing> GetZingsByAlpha(string alpha, Language language)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        return db.Zings.Where(s => s.Status != Status.Delete && s.Language == language && s.Alpha.Equals(alpha))
			        .OrderBy(s => s.Title).ToList();
	        }
        }

       public void Update(int id, string title, string singer, string alpha, string listenUrl, string watchingVideo, int genderId,string composer, int statusId, string cutline)
       {
	       using (var db = new SongContext(_connectionStrings))
	       {
		       var so = db.Zings.SingleOrDefault(s => s.Id == id && s.Status != Status.Delete);
		       if (so == null) return;
		       so.Alpha = alpha;
		       so.ModifiedDateTime = DateTime.Now;
		       so.ListeningUrl = listenUrl;
		       so.Artist = singer;
		       so.Title = title;
		       so.WatchVideo = watchingVideo;
		       so.Gender = (Gender)genderId;
		       so.Composer = composer;
		       so.Status = (Status)statusId;
		       so.Cutline = cutline;
		       db.SaveChanges();
	       }

       }

	    public void Delete(int id)
	    {
		    using (var db = new SongContext(_connectionStrings))
		    {
			    var so = db.Zings.SingleOrDefault(s => s.Id == id && s.Status != Status.Delete);
			    if (so != null)
			    {
				    so.Status = Status.Delete;
				    so.ModifiedDateTime = DateTime.Now;
				    db.SaveChanges();
			    }

		    }
	    }
    }
}
