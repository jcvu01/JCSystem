using System;
using System.Collections.Generic;
using JCSystem.Core.Repositories.Models;

namespace JCSystem.Core.Repositories.Interface
{
	public interface IZingsManager
	{
		void Delete(int id);
		Zing GetZing(int id);
		List<Zing> GetZings();
		List<Zing> GetZings(DateTime lastModifiedDate);
		List<Zing> GetZingsByAlpha(string alpha, Language language);
		bool IsExisted(int zingId);
		void Update(int id, string title, string singer, string alpha, string listenUrl, string watchingVideo, int genderId, string composer, int statusId, string cutline);
	}
}