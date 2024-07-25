using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MeetPoint.API.Dtos.Events
{
	public class EventCreateDto
	{
        public Guid CategoryId { get; set; }

        public Guid OrganizerId { get; set; }

        [Required(ErrorMessage = "El campo título es requerido.")]
		[StringLength(50)]
		public string Title { get; set; }

		[MinLength(10, ErrorMessage = "El campo descripción debe tener al menos 10 caracteres.")]
		[StringLength(300)]
		public string Description { get; set; }

		[Required(ErrorMessage = "El campo ubicación es requerido.")]
		[StringLength(100)]
		public string Ubication { get; set; }

		[Required(ErrorMessage = "El campo fecha es requerido.")]
		public DateTime Date { get; set; }

        public DateTime PublicationDate { get; set; }
    }
}
