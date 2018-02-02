using System;
using System.Collections.Generic;
using System.Linq;
using JCSystem.Core.Repositories.Interface;
using JCSystem.Core.Repositories.Models;
using JCSystem.Shared.Configuration;

namespace JCSystem.Core.Repositories
{
    public class QueueManager : IQueueManager
	{
	    private readonly ConnectionStrings _connectionStrings;

	    public QueueManager(ConnectionStrings connectionStrings)
	    {
		    _connectionStrings = connectionStrings;
	    }
        public List<KaraokeQueue> GetQueueByMachineName(string machineName, DateTime addedDate)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var queues = db.KaraokeQueues
			        .Where(q => q.MachineName == machineName && q.CreateDateTime > addedDate && q.RequestBy != "local" &&
			                    q.IsCompleted == false).OrderBy(q => q.Priority).ThenBy(q => q.CreateDateTime);
		        return queues.ToList();
	        }
        }

        public List<KaraokeQueue> GetQueueByMachineName(string machineName)
        {
            return GetQueueByMachineName(machineName, DateTime.Now.AddDays(-2));
        }

        public bool AddQueue(KaraokeQueue queue)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var que = db.KaraokeQueues.SingleOrDefault(q => q.Id == queue.Id);
		        if (que != null)
		        {
			        que.DatePlayed = queue.DatePlayed;
			        que.IsCompleted = que.IsCompleted;

		        }
		        else
		        {
			        db.KaraokeQueues.Add(queue);
		        }
		        try
		        {

			        db.SaveChanges();
			        return true;
		        }
		        catch (Exception ex)
		        {
			        throw ex;
		        }
	        }

        }


        public void DeleteQueue(int queueId)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var queue = db.KaraokeQueues.SingleOrDefault(q => q.Id == queueId);
		        if (queue != null)
		        {
			        db.KaraokeQueues.Remove(queue);
			        db.SaveChanges();
		        }
	        }
        }

        public void MarkQueueCompleted(int queueId)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var queue = db.KaraokeQueues.SingleOrDefault(q => q.Id == queueId);
		        if (queue != null)
		        {
			        queue.IsCompleted = true;
			        queue.ModifiedDateTime = DateTime.Now;
			        queue.DatePlayed = DateTime.Now;

			        db.SaveChanges();
		        }
	        }
        }

        public List<KaraokeQueue> GetQueueByRequester(string machineName, string requester)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var queues = db.KaraokeQueues
			        .Where(q => q.MachineName == machineName && q.IsCompleted == false && q.RequestBy == requester)
			        .OrderBy(q => q.Priority).ThenBy(q => q.CreateDateTime);
		        return queues.ToList();
	        }
        }

        public bool CheckQueue(string machineName, string requester, int songId)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        return db.KaraokeQueues.Any(q =>
				        q.MachineName == machineName && q.IsCompleted == false && q.RequestBy == requester && q.SongId == songId);
		       
	        }
        }

        public List<Song> GetSongsInQueue(string machineName)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var queues = from so in db.Songs
							 join que in db.KaraokeQueues on so.Id equals que.SongId
							 where que.MachineName == machineName
							 select so; 
					
					
		        return queues.ToList();
	        }

        }

        public void ClearQueue(string machineName)
        {
	        using (var db = new SongContext(_connectionStrings))
	        {
		        var queues = from q in db.KaraokeQueues where q.MachineName == machineName select q;
		        db.KaraokeQueues.RemoveRange(queues);
		        db.SaveChanges();
	        }
        }
    }
}
