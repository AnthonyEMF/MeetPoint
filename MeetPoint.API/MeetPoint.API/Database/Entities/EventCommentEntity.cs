using System.ComponentModel.DataAnnotations.Schema;

namespace MeetPoint.API.Database.Entities
{
	[Table("events_comments", Schema = "dbo")]
	public class EventCommentEntity : BaseEntity
	{
		[Column("event_id")]
		public Guid EventId { get; set; }
		[ForeignKey(nameof(EventId))]
		public virtual EventEntity Event { get; set; }

		[Column("comment_id")]
		public Guid CommentId { get; set; }
		[ForeignKey(nameof(CommentId))]
		public virtual CommentEntity Comment { get; set; }
	}
}
