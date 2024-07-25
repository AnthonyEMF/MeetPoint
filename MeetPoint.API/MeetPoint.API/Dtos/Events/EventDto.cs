using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MeetPoint.API.Dtos.Categories;

namespace MeetPoint.API.Dtos.Events
{
	public class EventDto
	{
        public Guid Id { get; set; }

        public virtual CategoryDto Category { get; set; }

		public Guid OrganizerId { get; set; } //public virtual UserDto Organizer { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public string Ubication { get; set; }

		public DateTime Date { get; set; }

        public DateTime PublicationDate { get; set; }
    }
}
