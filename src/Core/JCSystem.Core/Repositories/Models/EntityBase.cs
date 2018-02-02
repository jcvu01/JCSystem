using System;
using System.ComponentModel.DataAnnotations;

namespace JCSystem.Core.Repositories.Models
{
	public abstract class EntityBase
	{
		[Key]
		public int Id { get; protected set; }

		public DateTime? CreateDateTime { get; set; }

		public DateTime? ModifiedDateTime { get; set; }
	}
}
