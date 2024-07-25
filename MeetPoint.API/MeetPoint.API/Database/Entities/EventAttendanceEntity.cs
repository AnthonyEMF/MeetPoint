using System.ComponentModel.DataAnnotations.Schema;

namespace MeetPoint.API.Database.Entities
{
	[Table("events_attendances", Schema = "dbo")]
	public class EventAttendanceEntity : BaseEntity
	{
		[Column("event_id")]
		public Guid EventId { get; set; }
		[ForeignKey(nameof(EventId))]
		public virtual EventEntity Event { get; set; }

		[Column("attendance_id")]
		public Guid AttendanceId { get; set; }
		[ForeignKey(nameof(AttendanceId))]
		public virtual AttendanceEntity Attendance { get; set; }
	}
}
