using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetPoint.API.Database.Entities
{
	[Table("events", Schema = "dbo")]
	public class EventEntity : BaseEntity
	{
		[Column("category_id")]
        public Guid CategoryId { get; set; }

		[Column("organizer_id")]
		public Guid OrganizerId { get; set; }

		[Required(ErrorMessage = "El campo título es requerido.")]
		[StringLength(50)]
		[Column("title")]
		public string Title { get; set; }

		[MinLength(10, ErrorMessage = "El campo descripción debe tener al menos 10 caracteres.")]
		[StringLength(300)]
		[Column("description")]
		public string Description { get; set; }

		[Required(ErrorMessage = "El campo ubicación es requerido.")]
		[StringLength(100)]
		[Column("ubication")]
		public string Ubication { get; set; }

		[Required(ErrorMessage = "El campo fecha es requerido.")]
		[Column("date")]
		public DateTime Date { get; set; }

		[Required(ErrorMessage = "El campo fecha de publicación es requerido.")]
		[Column("publication_date")]
        public DateTime PublicationDate { get; set; }
    }
}
