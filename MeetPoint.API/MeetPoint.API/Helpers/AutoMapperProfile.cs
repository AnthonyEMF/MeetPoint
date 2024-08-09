using AutoMapper;
using MeetPoint.API.Database.Entities;
using MeetPoint.API.Dtos.Attendances;
using MeetPoint.API.Dtos.Categories;
using MeetPoint.API.Dtos.Comments;
using MeetPoint.API.Dtos.Events;
using MeetPoint.API.Dtos.Users;

namespace MeetPoint.API.Helpers
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			MapsForCategories();
			MapsForEvents();
			MapsForUsers();
			MapsForAttendances();
			MapsForComments();
		}

		private void MapsForCategories()
		{
			CreateMap<CategoryEntity, CategoryDto>();
			CreateMap<CategoryCreateDto, CategoryEntity>();
			CreateMap<CategoryEditDto, CategoryEntity>();
		}

		private void MapsForEvents()
		{
			CreateMap<EventEntity, EventDto>()
				.ForMember(dest => dest.Attendances, opt => opt
				.MapFrom(src => src.Attendances
				.Select(ea => ea.Attendance.State) // TODO: Ademas del state, concatenar el nombre de Usuario
				.ToList()))
				.ForMember(dest => dest.Comments, opt => opt
				.MapFrom(src => src.Comments
				.Select(ec => ec.Comment.Content)
				.ToList()));

			CreateMap<EventCreateDto, EventEntity>();
			CreateMap<EventEditDto, EventEntity>();
		}

		private void MapsForUsers()
		{
			CreateMap<UserEntity, UserDto>();
			CreateMap<UserCreateDto, UserEntity>();
			CreateMap<UserEditDto, UserEntity>();
		}

		private void MapsForAttendances()
		{
			CreateMap<AttendanceEntity, AttendanceDto>();
			CreateMap<AttendanceCreateDto, AttendanceEntity>();
			CreateMap<AttendanceEditDto, AttendanceEntity>();
		}

		private void MapsForComments()
		{
			CreateMap<CommentEntity, CommentDto>();
			CreateMap<CommentCreateDto, CommentEntity>();
			CreateMap<CommentEditDto, CommentEntity>();
		}
	}
}
