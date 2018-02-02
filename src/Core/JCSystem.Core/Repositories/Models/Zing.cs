using System.Collections.Specialized;

namespace JCSystem.Core.Repositories.Models
{
    public class Zing:EntityBase
    {
		public Status Status { get; set; }
	    public int ZingId { get; set; }
	    public string Title { get; set; }
	    public Language Language { get; set; }
	    public string Alpha { get; set; }
	    public string Artist { get; set; }
	    public string ListeningUrl { get; set; }
	    public string WatchVideo { get; set; }
	    public Gender Gender { get; set; }
	    public string Composer { get; set; }
	    public string Cutline { get; set; }
    }
}
