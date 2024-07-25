using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetPoint.API.Database.Entities
{
	[Table("events", Schema = "dbo")]
	public class EventEntity : BaseEntity
	{
		// Categoria a la que pertenece el evento
		[Column("category_id")]
        public Guid CategoryId { get; set; }
		[ForeignKey(nameof(CategoryId))]
		public virtual CategoryEntity Category { get; set; }

		// Creador del evento
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

		[Column("publication_date")]
        public DateTime PublicationDate { get; set; }

		// Comentarios del evento
		public virtual IEnumerable<EventCommentEntity> Comments { get; set; }

		// Asistencias del evento
		public virtual IEnumerable<EventAttendanceEntity> Attendances { get; set; }
	}
}
