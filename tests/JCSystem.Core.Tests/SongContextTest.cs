using System.Linq;
using FluentAssertions;
using JCSystem.Core.Repositories;
using Xunit;

namespace JCSystem.Core.Tests
{
    public class SongContextTest
    {
        [Fact]
        public void CreateDatabaseSuccess()
        {
	        var context = new SongContext();
	        context.Songs.Count().Should().Be(0);
        }
    }
}
