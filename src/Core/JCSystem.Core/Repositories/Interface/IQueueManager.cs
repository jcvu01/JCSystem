using System;
using System.Collections.Generic;
using JCSystem.Core.Repositories.Models;

namespace JCSystem.Core.Repositories.Interface
{
	public interface IQueueManager
	{
		bool AddQueue(KaraokeQueue queue);
		bool CheckQueue(string machineName, string requester, int songId);
		void ClearQueue(string machineName);
		void DeleteQueue(int queueId);
		List<KaraokeQueue> GetQueueByMachineName(string machineName);
		List<KaraokeQueue> GetQueueByMachineName(string machineName, DateTime addedDate);
		List<KaraokeQueue> GetQueueByRequester(string machineName, string requester);
		List<Song> GetSongsInQueue(string machineName);
		void MarkQueueCompleted(int queueId);
	}
}