using System;

namespace JCSystem.Core.Repositories.Models
{
   public class KaraokeQueue: EntityBase
    {
	    public string MachineName { get; set; }
	    public string RequestBy { get; set; }
	    public bool IsCompleted { get; set; }
	    public int Priority { get; set; }
	    public DateTime? DatePlayed { get; set; }
	    public int SongId { get; set; }
    }
}
