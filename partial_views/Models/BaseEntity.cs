using System;
namespace partial_views.Models
{
	public abstract  class BaseEntity
	{
		public int Id { get; set; }
        public bool SoftDeleted { get; set; } = false;

    }
}

