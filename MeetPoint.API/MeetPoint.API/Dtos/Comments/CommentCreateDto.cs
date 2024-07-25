using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MeetPoint.API.Dtos.Comments
{
	public class CommentCreateDto
	{
		public Guid UserId { get; set; }

		[Required(ErrorMessage = "Es requerido escribir el contenido del comentario.")]
		public string Content { get; set; }

		public DateTime PublicationDate { get; set; }

		public virtual List<string> EventsList { get; set; }
	}
}
