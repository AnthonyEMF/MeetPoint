using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetPoint.API.Database.Entities
{
	[Table("comments", Schema = "dbo")]
	public class CommentEntity : BaseEntity
	{
		// Usuario autor del comentario
		[Column("user_id")]
		public Guid UserId { get; set; }

		[Required(ErrorMessage = "Es requerido escribir el contenido del comentario.")]
		[StringLength(200)]
		[Column("content")]
		public string Content { get; set; }

		[Column("publication_date")]
		public DateTime PublicationDate { get; set; }

		// Evento al que pertenece el comentario
		public virtual IEnumerable<EventCommentEntity> Event { get; set; }
	}
}
