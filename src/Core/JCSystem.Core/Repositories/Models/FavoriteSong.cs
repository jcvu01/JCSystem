namespace JCSystem.Core.Repositories.Models
{
    public class FavoriteSong:EntityBase
    {
	    public int UserId { get; set; }
	    public int SongId { get; set; }
    }
}
