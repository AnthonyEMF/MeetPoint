using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MeetPoint.API.Database.Entities
{
	[Table("users", Schema = "dbo")]
	public class UserEntity : BaseEntity
	{
		[Required(ErrorMessage = "El primer nombre es requerido.")]
		[StringLength(50)]
		[Column("first_name")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "El segundo nombre es requerido.")]
		[StringLength(50)]
		[Column("last_name")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "El email es requerido.")]
		[StringLength(200)]
		[Column("email")]
		public string Email { get; set; }

		[Required(ErrorMessage = "La contraseña es requerida.")]
		[StringLength(100)]
		[Column("password")]
		public string Password { get; set; }

		[Required(ErrorMessage = "La locación es requerida.")]
		[StringLength(100)]
		[Column("location")]
		public string Location { get; set; }
	}
}
