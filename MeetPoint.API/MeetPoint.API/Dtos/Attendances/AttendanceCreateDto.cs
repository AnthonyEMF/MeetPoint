using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MeetPoint.API.Dtos.Attendances
{
	public class AttendanceCreateDto
	{
		public string UserId { get; set; }

		[Required(ErrorMessage = "Especificar el estado de la asistencia es requerido.")]
		public string State { get; set; }

		public virtual List<string> EventsList { get; set; }
	}
}
