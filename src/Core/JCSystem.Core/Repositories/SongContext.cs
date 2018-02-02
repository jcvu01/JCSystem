using JCSystem.Core.Repositories.Models;
using JCSystem.Shared.Configuration;
using Microsoft.EntityFrameworkCore;

namespace JCSystem.Core.Repositories
{
    public sealed class SongContext:DbContext
    {
	    private readonly bool _created;
	    private readonly string _connectionString = @"Data Source=.\Songs.db";

	    public SongContext()
	    {
		    if (_created) return;

		    _created = true;
		    Database.EnsureDeleted();
		    Database.EnsureCreated();
	    }

	    public SongContext(ConnectionStrings connectionStrings)
	    {
		    _connectionString = connectionStrings.SongsDb;
	    }

	    protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
	    {
		    optionbuilder.UseSqlite(_connectionString);
	    }

	    protected override void OnModelCreating(ModelBuilder modelBuilder)
	    {
		    modelBuilder.Entity<Song>()
			    .HasIndex(p => new { p.ProperTitle, p.Artist, p.AlbumName, p.Title,p.Composer });
	    }

		public  DbSet<Song> Songs { get; set; }
		public DbSet<FavoriteSong> FavoriteSongs { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Zing> Zings { get; set; }
		public DbSet<KaraokeQueue> KaraokeQueues { get; set; }
	}
}
