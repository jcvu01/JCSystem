using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace JCSystem.Core.Repositories.Models
{
    public class Song:EntityBase
    {
		public string Title { get; set; }
		public string ProperTitle { get; set; }
		public string Artist { get; set; }
		public string Cutline { get; set; }
		public string Lyric { get; set; }
		public Language Language { get; set; }
		public virtual Mood Mode { get; set; }
		public Gender Gender { get; set; }
		public MusicType MusicType { get; set; }
		public string FilePath { get; set; }
		public VideoQuality VideoQuality { get; set; }
		public string Production { get; set; }
		public string AlbumName { get; set; }
		public Status Status { get; set; } 
		public string Alpha { get; set; }
		public int PlayedCount { get; set; }
		public int VocalTrack { get; set; }
		public bool Featured { get; set; }
		public string Composer { get; set; }
		public string ListeningUrl { get; set; }
		public string WatchUrl { get; set; }
    }

	public enum Language
	{
		English,
		Vietnamese
	}

	public enum Gender
	{
		Male,
		Female,
		Duel,
		Group
	}

	public enum MusicType
	{
		
	}

	public enum VideoQuality
	{
		Excellent,
		Good,
		Bad
	}

	public enum Status
	{
		Active = 2,
		Delete=9,
		New=3,
		Incomplete=1
	}
}
