using System;
using System.Collections.Generic;
using JCSystem.Core.Repositories.Models;
using JCSystem.Shared.Models;

namespace JCSystem.Core.Repositories.Interface
{
	public interface ISongsManager
	{
		int AddSong(Song s);
		void DeleteSong(int songid);
		List<Song> GetFeatureSongs();
		Song GetRandom();
		Song GetSong(int songid);
		List<Song> GetSongs(DateTime lastModifiedDate);
		List<Song> GetSongs(SearchOptions option);
		List<Song> GetSongs(string title);
		List<Song> GetSongsByAlpha(string alpha);
		List<Song> GetSongsByTitleAndArtist(string title, string artist);
		string[] GetSuggestedArtists();
		string[] GetSuggestedTitles();
		List<Song> GetTop20PlayedSongs();
		void PlayedCounter(int songid);
		int SongCounts(SearchOptions option);
		string SongImageType(int soId);
		void UpdateFilePath(int songid, string path);
		void UpdateSong(int songId, string title, string singer, int genderId, int vocalTrack, string alpha, string listeningUrl, string watchVideo, string composer, int statusId, string cutline);
		void UpdateSong(Song s);
	}
}