using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetPoint.API.Database.Entities
{
	[Table("attendances", Schema = "dbo")]
	public class AttendanceEntity : BaseEntity
	{
		[Column("user_id")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Especificar el estado de la asistencia es requerido.")]
		[StringLength(10)]
		[Column("state")]
		public string State { get; set; }

		// Evento al que pertenece la asistencia
		public virtual IEnumerable<EventAttendanceEntity> Event { get; set; }
	}
}
